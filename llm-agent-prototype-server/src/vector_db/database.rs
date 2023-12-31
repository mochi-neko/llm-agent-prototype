use std::{collections::HashMap, fmt::Formatter};

use anyhow::Result;
use chrono::{DateTime, Utc};
use qdrant_client::{
    prelude::{Payload, QdrantClient},
    qdrant::{
        vectors_config::Config, CreateCollection, Distance, Filter,
        PointStruct, ScoredPoint, SearchPoints, Value, VectorParams,
        VectorsConfig,
    },
};

use crate::vector_db::embeddings;

#[derive(Debug)]
pub(crate) struct Record {
    pub(crate) text: String,
    pub(crate) datetime: DateTime<Utc>,
    pub(crate) author: String,
}

impl Record {
    pub(crate) fn new(
        text: String,
        author: String,
    ) -> Self {
        Self {
            text,
            datetime: Utc::now(),
            author,
        }
    }

    fn to_payload(&self) -> Payload {
        let mut map = HashMap::new();

        map.insert(
            "text".to_string(),
            Value::from(self.text.clone()),
        );

        map.insert(
            "datetime".to_string(),
            Value::from(
                self.datetime
                    .format("%Y-%m-%dT%H:%M:%S%.3f")
                    .to_string(),
            ),
        );

        map.insert(
            "author".to_string(),
            Value::from(self.author.clone()),
        );

        Payload::new_from_hashmap(map)
    }

    pub(crate) fn from_payload(payload: HashMap<String, Value>) -> Self {
        let text = payload
            .get("text")
            .unwrap()
            .to_string()
            .parse::<String>()
            .unwrap();

        let datetime = payload
            .get("datetime")
            .unwrap()
            .to_string()
            .parse::<DateTime<Utc>>()
            .unwrap();

        let author = payload
            .get("author")
            .unwrap()
            .to_string()
            .parse::<String>()
            .unwrap();

        Self {
            text,
            datetime,
            author,
        }
    }
}

pub(crate) struct DataBase {
    pub(crate) client: QdrantClient,
    pub(crate) name: String,
}

impl std::fmt::Debug for DataBase {
    fn fmt(
        &self,
        f: &mut Formatter<'_>,
    ) -> std::fmt::Result {
        f.debug_struct("DataBase")
            .field("client", &self.client.cfg.uri)
            .field("name", &self.name)
            .finish()
    }
}

impl DataBase {
    pub(crate) async fn new(
        client: QdrantClient,
        name: String,
        dimension: u64,
        reset: bool,
    ) -> Result<DataBase> {
        let has_collection = client
            .has_collection(name.clone())
            .await
            .map_err(|error| {
                tracing::error!(
                    "Failed to check collection: {:?}",
                    error
                );
                error
            })?;

        if reset & has_collection {
            client
                .delete_collection(name.clone())
                .await
                .map_err(|error| {
                    tracing::error!(
                        "Failed to delete collection: {:?}",
                        error
                    );
                    error
                })?;
        }

        if reset || !has_collection {
            client
                .create_collection(&CreateCollection {
                    collection_name: name.clone(),
                    vectors_config: Some(VectorsConfig {
                        config: Some(Config::Params(VectorParams {
                            size: dimension,
                            distance: Distance::Cosine.into(),
                            ..Default::default()
                        })),
                    }),
                    ..Default::default()
                })
                .await
                .map_err(|error| {
                    tracing::error!(
                        "Failed to create collection: {:?}",
                        error
                    );
                    error
                })?;
        }

        Ok(DataBase {
            client,
            name,
        })
    }

    #[tracing::instrument(
        name = "vector_db.database.upsert",
        err,
        skip(self, record)
    )]
    pub(crate) async fn upsert(
        &mut self,
        record: Record,
    ) -> Result<()> {
        let embedding = embeddings::embed(record.text.clone())
            .await
            .map_err(|error| {
                tracing::error!("Failed to embed text: {:?}", error);
                error
            })?;
        let payload = record.to_payload();
        let mut points = Vec::new();
        for vector in embedding {
            let point = PointStruct::new(
                uuid::Uuid::new_v4().to_string(),
                vector,
                payload.clone(),
            );
            points.push(point);
        }

        self.client
            .upsert_points(self.name.clone(), points, None)
            .await
            .map_err(|error| {
                tracing::error!("Failed to upsert points: {:?}", error);
                error
            })?;

        tracing::info!(
            "Upserted {} to {} successfully",
            record.text,
            self.name
        );
        Ok(())
    }

    #[tracing::instrument(
        name = "vector_db.database.search",
        err,
        skip(self, query, count_limit, filter)
    )]
    pub(crate) async fn search(
        &self,
        query: String,
        count_limit: u64,
        filter: Option<Filter>,
    ) -> Result<Vec<ScoredPoint>> {
        let embedding = embeddings::embed(query.clone())
            .await
            .map_err(|error| {
                tracing::error!("Failed to embed query: {:?}", error);
                error
            })?;
        let vector = embedding[0].clone();
        let result = self
            .client
            .search_points(&SearchPoints {
                collection_name: self.name.clone(),
                vector,
                limit: count_limit,
                filter,
                with_payload: Some(true.into()),
                with_vectors: Some(true.into()),
                ..Default::default()
            })
            .await
            .map_err(|error| {
                tracing::error!("Failed to search points: {:?}", error);
                error
            })?;

        tracing::info!(
            "Searched {}'s results by query: {} from {} successfully",
            result.result.len(),
            query,
            self.name
        );
        Ok(result.result)
    }
}
