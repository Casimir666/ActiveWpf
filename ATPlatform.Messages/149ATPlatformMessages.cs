// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.JournalEntryProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class JournalEntryProto : 
    IMessage<JournalEntryProto>,
    IMessage,
    IEquatable<JournalEntryProto>,
    IDeepCloneable<JournalEntryProto>
  {
    private static readonly MessageParser<JournalEntryProto> _parser = new MessageParser<JournalEntryProto>((Func<JournalEntryProto>) (() => new JournalEntryProto()));
    private UnknownFieldSet _unknownFields;
    public const int TypeFieldNumber = 1;
    private MessageTypeProto type_;
    public const int RequestIdFieldNumber = 2;
    private int requestId_;
    public const int InitiatorUserIdFieldNumber = 3;
    private int initiatorUserId_;
    public const int SessionIdFieldNumber = 4;
    private int sessionId_;
    public const int SequenceNumberFieldNumber = 5;
    private int sequenceNumber_;
    public const int TimestampFieldNumber = 6;
    private long timestamp_;
    public const int BodyFieldNumber = 7;
    private string body_ = "";

    [DebuggerNonUserCode]
    public static MessageParser<JournalEntryProto> Parser => JournalEntryProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[142];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => JournalEntryProto.Descriptor;

    [DebuggerNonUserCode]
    public JournalEntryProto()
    {
    }

    [DebuggerNonUserCode]
    public JournalEntryProto(JournalEntryProto other)
      : this()
    {
      this.type_ = other.type_;
      this.requestId_ = other.requestId_;
      this.initiatorUserId_ = other.initiatorUserId_;
      this.sessionId_ = other.sessionId_;
      this.sequenceNumber_ = other.sequenceNumber_;
      this.timestamp_ = other.timestamp_;
      this.body_ = other.body_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public JournalEntryProto Clone() => new JournalEntryProto(this);

    [DebuggerNonUserCode]
    public MessageTypeProto Type
    {
      get => this.type_;
      set => this.type_ = value;
    }

    [DebuggerNonUserCode]
    public int RequestId
    {
      get => this.requestId_;
      set => this.requestId_ = value;
    }

    [DebuggerNonUserCode]
    public int InitiatorUserId
    {
      get => this.initiatorUserId_;
      set => this.initiatorUserId_ = value;
    }

    [DebuggerNonUserCode]
    public int SessionId
    {
      get => this.sessionId_;
      set => this.sessionId_ = value;
    }

    [DebuggerNonUserCode]
    public int SequenceNumber
    {
      get => this.sequenceNumber_;
      set => this.sequenceNumber_ = value;
    }

    [DebuggerNonUserCode]
    public long Timestamp
    {
      get => this.timestamp_;
      set => this.timestamp_ = value;
    }

    [DebuggerNonUserCode]
    public string Body
    {
      get => this.body_;
      set => this.body_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as JournalEntryProto);

    [DebuggerNonUserCode]
    public bool Equals(JournalEntryProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.Type == other.Type && this.RequestId == other.RequestId && (this.InitiatorUserId == other.InitiatorUserId && this.SessionId == other.SessionId) && (this.SequenceNumber == other.SequenceNumber && this.Timestamp == other.Timestamp && !(this.Body != other.Body)) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      if (this.Type != MessageTypeProto.UndefinedMessageType)
        num1 ^= this.Type.GetHashCode();
      int num2;
      if (this.RequestId != 0)
      {
        int num3 = num1;
        num2 = this.RequestId;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.InitiatorUserId != 0)
      {
        int num3 = num1;
        num2 = this.InitiatorUserId;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.SessionId != 0)
      {
        int num3 = num1;
        num2 = this.SessionId;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.SequenceNumber != 0)
      {
        int num3 = num1;
        num2 = this.SequenceNumber;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.Timestamp != 0L)
        num1 ^= this.Timestamp.GetHashCode();
      if (this.Body.Length != 0)
        num1 ^= this.Body.GetHashCode();
      if (this._unknownFields != null)
        num1 ^= this._unknownFields.GetHashCode();
      return num1;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.Type != MessageTypeProto.UndefinedMessageType)
      {
        output.WriteRawTag((byte) 8);
        output.WriteEnum((int) this.Type);
      }
      if (this.RequestId != 0)
      {
        output.WriteRawTag((byte) 16);
        output.WriteInt32(this.RequestId);
      }
      if (this.InitiatorUserId != 0)
      {
        output.WriteRawTag((byte) 24);
        output.WriteInt32(this.InitiatorUserId);
      }
      if (this.SessionId != 0)
      {
        output.WriteRawTag((byte) 32);
        output.WriteInt32(this.SessionId);
      }
      if (this.SequenceNumber != 0)
      {
        output.WriteRawTag((byte) 40);
        output.WriteInt32(this.SequenceNumber);
      }
      if (this.Timestamp != 0L)
      {
        output.WriteRawTag((byte) 48);
        output.WriteInt64(this.Timestamp);
      }
      if (this.Body.Length != 0)
      {
        output.WriteRawTag((byte) 58);
        output.WriteString(this.Body);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.Type != MessageTypeProto.UndefinedMessageType)
        num += 1 + CodedOutputStream.ComputeEnumSize((int) this.Type);
      if (this.RequestId != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.RequestId);
      if (this.InitiatorUserId != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.InitiatorUserId);
      if (this.SessionId != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.SessionId);
      if (this.SequenceNumber != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.SequenceNumber);
      if (this.Timestamp != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.Timestamp);
      if (this.Body.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Body);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(JournalEntryProto other)
    {
      if (other == null)
        return;
      if (other.Type != MessageTypeProto.UndefinedMessageType)
        this.Type = other.Type;
      if (other.RequestId != 0)
        this.RequestId = other.RequestId;
      if (other.InitiatorUserId != 0)
        this.InitiatorUserId = other.InitiatorUserId;
      if (other.SessionId != 0)
        this.SessionId = other.SessionId;
      if (other.SequenceNumber != 0)
        this.SequenceNumber = other.SequenceNumber;
      if (other.Timestamp != 0L)
        this.Timestamp = other.Timestamp;
      if (other.Body.Length != 0)
        this.Body = other.Body;
      this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
    }

    [DebuggerNonUserCode]
    public void MergeFrom(CodedInputStream input)
    {
      uint num;
      while ((num = input.ReadTag()) != 0U)
      {
        switch (num)
        {
          case 8:
            this.Type = (MessageTypeProto) input.ReadEnum();
            continue;
          case 16:
            this.RequestId = input.ReadInt32();
            continue;
          case 24:
            this.InitiatorUserId = input.ReadInt32();
            continue;
          case 32:
            this.SessionId = input.ReadInt32();
            continue;
          case 40:
            this.SequenceNumber = input.ReadInt32();
            continue;
          case 48:
            this.Timestamp = input.ReadInt64();
            continue;
          case 58:
            this.Body = input.ReadString();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
