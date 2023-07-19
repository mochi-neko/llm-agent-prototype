#nullable enable
using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using Grpc.Core;
using GRPC.NET;
using Grpc.Net.Client;
using UniRx;
using Unity.Logging;
using UnityEngine;
using Console = System.Console;

namespace Mochineko.LLMAgent.Creature
{
    public sealed class CreatureClient : IDisposable
    {
        private readonly GrpcChannel channel;
        private readonly CancellationTokenSource cancellationTokenSource = new();
        private readonly AsyncDuplexStreamingCall<Generated.Talking, Generated.State> call;

        private readonly Subject<Generated.State> onStateReceived = new();
        public IObservable<Generated.State> OnStateReceived => onStateReceived;

        public CreatureClient(string address, GRPCBestHttpHandler httpHandler)
        {
            if (string.IsNullOrEmpty(address))
            {
                throw new ArgumentOutOfRangeException(nameof(address));
            }

            if (!address.StartsWith("https://"))
            {
                throw new ArgumentOutOfRangeException(nameof(address));
            }

            // Log.Debug("[LLMAgent.Creature] Begin to connect gRPC to {0}", address);
            Debug.LogFormat("[LLMAgent.Creature] Begin to connect gRPC to {0}", address);

            this.channel = GrpcChannel.ForAddress(address, new GrpcChannelOptions()
            {
                HttpHandler = httpHandler,
            });

            var client = new Generated.Creature.CreatureClient(channel);

            this.call = client.Talk(cancellationToken: cancellationTokenSource.Token);

            ReceiveLoopAsync(cancellationTokenSource.Token)
                .Forget();

            // Log.Debug("[LLMAgent.Creature] Succeeded to connect gRPC to {0}", address);
            Debug.LogFormat("[LLMAgent.Creature] Succeeded to connect gRPC to {0}", address);
        }

        public void Dispose()
        {
            onStateReceived.Dispose();
            call.Dispose();
            cancellationTokenSource.Dispose();
            channel.Dispose();
        }

        public async UniTask Send(Generated.Talking talking)
        {
            // Log.Debug("[LLMAgent.Creature] Begin to send talking: {0}", talking.Message);
            Debug.LogFormat("[LLMAgent.Creature] Begin to send talking: {0}", talking.Message);

            try
            {
                await call
                    .RequestStream
                    .WriteAsync(talking);
            }
            catch (RpcException exception)
            {
                // Log.Error("[LLMAgent.Creature] Failed to send talking: {0}", exception);
                Debug.LogErrorFormat("[LLMAgent.Creature] Failed to send talking: {0}", exception);
                // TODO: Validate status code
                return;
            }

            // Log.Debug("[LLMAgent.Creature] Finished to send talking: {0}", talking.Message);
            Debug.LogFormat("[LLMAgent.Creature] Finished to send talking: {0}", talking.Message);
        }

        private async UniTask ReceiveLoopAsync(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                try
                {
                    if (!await call.ResponseStream.MoveNext(cancellationToken))
                    {
                        return;
                    }
                }
                catch (RpcException exception)
                {
                    // Log.Error("[LLMAgent.Creature] Failed to receive state: {0}", exception);
                    Debug.LogErrorFormat("[LLMAgent.Creature] Failed to receive state: {0}", exception);
                    // TODO: Validate status code
                    continue;
                }
                catch (ObjectDisposedException)
                {
                    // NOTE: This exception is thrown when the client is disposed.
                    return;
                }

                var state = call.ResponseStream.Current;

                // Log.Debug("[LLMAgent.Creature] Received state: {0}, {1}, {2}", state.Emotion, state.Motion, state.Cry);
                Debug.LogFormat("[LLMAgent.Creature] Received state: {0}, {1}, {2}", state.Emotion, state.Motion, state.Cry);

                onStateReceived.OnNext(state);
            }
        }
    }
}
