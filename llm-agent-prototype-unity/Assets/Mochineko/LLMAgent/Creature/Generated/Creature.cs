// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GitRepositories/llm-agent-prototype/llm-agent-prototype-server/proto/creature.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Mochineko.LLMAgent.Creature.Generated {

  /// <summary>Holder for reflection information generated from GitRepositories/llm-agent-prototype/llm-agent-prototype-server/proto/creature.proto</summary>
  public static partial class CreatureReflection {

    #region Descriptor
    /// <summary>File descriptor for GitRepositories/llm-agent-prototype/llm-agent-prototype-server/proto/creature.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CreatureReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ClNHaXRSZXBvc2l0b3JpZXMvbGxtLWFnZW50LXByb3RvdHlwZS9sbG0tYWdl",
            "bnQtcHJvdG90eXBlLXNlcnZlci9wcm90by9jcmVhdHVyZS5wcm90bxIIY3Jl",
            "YXR1cmUiGgoHVGFsa2luZxIPCgdtZXNzYWdlGAEgASgJImkKBVN0YXRlEiIK",
            "B2Vtb3Rpb24YASABKA4yES5jcmVhdHVyZS5FbW90aW9uEiAKBm1vdGlvbhgC",
            "IAEoDjIQLmNyZWF0dXJlLk1vdGlvbhIaCgNjcnkYAyABKA4yDS5jcmVhdHVy",
            "ZS5DcnkqmAEKB0Vtb3Rpb24SEwoPRU1PVElPTl9ORVVUUkFMEAASEQoNRU1P",
            "VElPTl9IQVBQWRABEg8KC0VNT1RJT05fU0FEEAISEQoNRU1PVElPTl9BTkdS",
            "WRADEhMKD0VNT1RJT05fRkVBUkZVTBAEEhUKEUVNT1RJT05fRElTR1VTVEVE",
            "EAUSFQoRRU1PVElPTl9TVVJQUklTRUQQBiq4AQoGTW90aW9uEhIKDk1PVElP",
            "Tl9ORVVUUkFMEAASEAoMTU9USU9OX0hBUFBZEAESDQoJTU9USU9OX05PEAIS",
            "DwoLTU9USU9OX0pVTVAQAxIOCgpNT1RJT05fRElFEAQSDgoKTU9USU9OX1JV",
            "ThAFEg8KC01PVElPTl9XQUxLEAYSEQoNTU9USU9OX0ZMWUlORxAHEhEKDU1P",
            "VElPTl9BVFRBQ0sQCBIRCg1NT1RJT05fRUFUSU5HEAkqkwEKA0NyeRIMCghD",
            "UllfTk9ORRAAEg0KCUNSWV9IQVBQWRABEgsKB0NSWV9TQUQQAhINCglDUllf",
            "QU5HUlkQAxIPCgtDUllfRkVBUkZVTBAEEhEKDUNSWV9ESVNHVVNURUQQBRIR",
            "Cg1DUllfU1VSUFJJU0VEEAYSDwoLQ1JZX1NQT0lMRUQQBxILCgdDUllfQ1JZ",
            "EAgyOgoIQ3JlYXR1cmUSLgoEVGFsaxIRLmNyZWF0dXJlLlRhbGtpbmcaDy5j",
            "cmVhdHVyZS5TdGF0ZSgBMAFCKKoCJU1vY2hpbmVrby5MTE1BZ2VudC5DcmVh",
            "dHVyZS5HZW5lcmF0ZWRiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Mochineko.LLMAgent.Creature.Generated.Emotion), typeof(global::Mochineko.LLMAgent.Creature.Generated.Motion), typeof(global::Mochineko.LLMAgent.Creature.Generated.Cry), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Mochineko.LLMAgent.Creature.Generated.Talking), global::Mochineko.LLMAgent.Creature.Generated.Talking.Parser, new[]{ "Message" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Mochineko.LLMAgent.Creature.Generated.State), global::Mochineko.LLMAgent.Creature.Generated.State.Parser, new[]{ "Emotion", "Motion", "Cry" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum Emotion {
    [pbr::OriginalName("EMOTION_NEUTRAL")] Neutral = 0,
    [pbr::OriginalName("EMOTION_HAPPY")] Happy = 1,
    [pbr::OriginalName("EMOTION_SAD")] Sad = 2,
    [pbr::OriginalName("EMOTION_ANGRY")] Angry = 3,
    [pbr::OriginalName("EMOTION_FEARFUL")] Fearful = 4,
    [pbr::OriginalName("EMOTION_DISGUSTED")] Disgusted = 5,
    [pbr::OriginalName("EMOTION_SURPRISED")] Surprised = 6,
  }

  public enum Motion {
    [pbr::OriginalName("MOTION_NEUTRAL")] Neutral = 0,
    [pbr::OriginalName("MOTION_HAPPY")] Happy = 1,
    [pbr::OriginalName("MOTION_NO")] No = 2,
    [pbr::OriginalName("MOTION_JUMP")] Jump = 3,
    [pbr::OriginalName("MOTION_DIE")] Die = 4,
    [pbr::OriginalName("MOTION_RUN")] Run = 5,
    [pbr::OriginalName("MOTION_WALK")] Walk = 6,
    [pbr::OriginalName("MOTION_FLYING")] Flying = 7,
    [pbr::OriginalName("MOTION_ATTACK")] Attack = 8,
    [pbr::OriginalName("MOTION_EATING")] Eating = 9,
  }

  public enum Cry {
    [pbr::OriginalName("CRY_NONE")] None = 0,
    [pbr::OriginalName("CRY_HAPPY")] Happy = 1,
    [pbr::OriginalName("CRY_SAD")] Sad = 2,
    [pbr::OriginalName("CRY_ANGRY")] Angry = 3,
    [pbr::OriginalName("CRY_FEARFUL")] Fearful = 4,
    [pbr::OriginalName("CRY_DISGUSTED")] Disgusted = 5,
    [pbr::OriginalName("CRY_SURPRISED")] Surprised = 6,
    [pbr::OriginalName("CRY_SPOILED")] Spoiled = 7,
    [pbr::OriginalName("CRY_CRY")] Cry = 8,
  }

  #endregion

  #region Messages
  public sealed partial class Talking : pb::IMessage<Talking>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Talking> _parser = new pb::MessageParser<Talking>(() => new Talking());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Talking> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mochineko.LLMAgent.Creature.Generated.CreatureReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Talking() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Talking(Talking other) : this() {
      message_ = other.message_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Talking Clone() {
      return new Talking(this);
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 1;
    private string message_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Talking);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Talking other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Message != other.Message) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Message.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Message);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Message.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Message);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Talking other) {
      if (other == null) {
        return;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Message = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Message = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class State : pb::IMessage<State>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<State> _parser = new pb::MessageParser<State>(() => new State());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<State> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mochineko.LLMAgent.Creature.Generated.CreatureReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public State() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public State(State other) : this() {
      emotion_ = other.emotion_;
      motion_ = other.motion_;
      cry_ = other.cry_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public State Clone() {
      return new State(this);
    }

    /// <summary>Field number for the "emotion" field.</summary>
    public const int EmotionFieldNumber = 1;
    private global::Mochineko.LLMAgent.Creature.Generated.Emotion emotion_ = global::Mochineko.LLMAgent.Creature.Generated.Emotion.Neutral;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Mochineko.LLMAgent.Creature.Generated.Emotion Emotion {
      get { return emotion_; }
      set {
        emotion_ = value;
      }
    }

    /// <summary>Field number for the "motion" field.</summary>
    public const int MotionFieldNumber = 2;
    private global::Mochineko.LLMAgent.Creature.Generated.Motion motion_ = global::Mochineko.LLMAgent.Creature.Generated.Motion.Neutral;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Mochineko.LLMAgent.Creature.Generated.Motion Motion {
      get { return motion_; }
      set {
        motion_ = value;
      }
    }

    /// <summary>Field number for the "cry" field.</summary>
    public const int CryFieldNumber = 3;
    private global::Mochineko.LLMAgent.Creature.Generated.Cry cry_ = global::Mochineko.LLMAgent.Creature.Generated.Cry.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Mochineko.LLMAgent.Creature.Generated.Cry Cry {
      get { return cry_; }
      set {
        cry_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as State);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(State other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Emotion != other.Emotion) return false;
      if (Motion != other.Motion) return false;
      if (Cry != other.Cry) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Emotion != global::Mochineko.LLMAgent.Creature.Generated.Emotion.Neutral) hash ^= Emotion.GetHashCode();
      if (Motion != global::Mochineko.LLMAgent.Creature.Generated.Motion.Neutral) hash ^= Motion.GetHashCode();
      if (Cry != global::Mochineko.LLMAgent.Creature.Generated.Cry.None) hash ^= Cry.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Emotion != global::Mochineko.LLMAgent.Creature.Generated.Emotion.Neutral) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Emotion);
      }
      if (Motion != global::Mochineko.LLMAgent.Creature.Generated.Motion.Neutral) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Motion);
      }
      if (Cry != global::Mochineko.LLMAgent.Creature.Generated.Cry.None) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Cry);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Emotion != global::Mochineko.LLMAgent.Creature.Generated.Emotion.Neutral) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Emotion);
      }
      if (Motion != global::Mochineko.LLMAgent.Creature.Generated.Motion.Neutral) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Motion);
      }
      if (Cry != global::Mochineko.LLMAgent.Creature.Generated.Cry.None) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Cry);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Emotion != global::Mochineko.LLMAgent.Creature.Generated.Emotion.Neutral) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Emotion);
      }
      if (Motion != global::Mochineko.LLMAgent.Creature.Generated.Motion.Neutral) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Motion);
      }
      if (Cry != global::Mochineko.LLMAgent.Creature.Generated.Cry.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Cry);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(State other) {
      if (other == null) {
        return;
      }
      if (other.Emotion != global::Mochineko.LLMAgent.Creature.Generated.Emotion.Neutral) {
        Emotion = other.Emotion;
      }
      if (other.Motion != global::Mochineko.LLMAgent.Creature.Generated.Motion.Neutral) {
        Motion = other.Motion;
      }
      if (other.Cry != global::Mochineko.LLMAgent.Creature.Generated.Cry.None) {
        Cry = other.Cry;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Emotion = (global::Mochineko.LLMAgent.Creature.Generated.Emotion) input.ReadEnum();
            break;
          }
          case 16: {
            Motion = (global::Mochineko.LLMAgent.Creature.Generated.Motion) input.ReadEnum();
            break;
          }
          case 24: {
            Cry = (global::Mochineko.LLMAgent.Creature.Generated.Cry) input.ReadEnum();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Emotion = (global::Mochineko.LLMAgent.Creature.Generated.Emotion) input.ReadEnum();
            break;
          }
          case 16: {
            Motion = (global::Mochineko.LLMAgent.Creature.Generated.Motion) input.ReadEnum();
            break;
          }
          case 24: {
            Cry = (global::Mochineko.LLMAgent.Creature.Generated.Cry) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
