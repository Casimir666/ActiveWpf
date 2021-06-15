// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.MessageHeaderProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class MessageHeaderProto : 
    IMessage<MessageHeaderProto>,
    IMessage,
    IEquatable<MessageHeaderProto>,
    IDeepCloneable<MessageHeaderProto>
  {
    private static readonly MessageParser<MessageHeaderProto> _parser = new MessageParser<MessageHeaderProto>((Func<MessageHeaderProto>) (() => new MessageHeaderProto()));
    private UnknownFieldSet _unknownFields;
    public const int MessageTypeFieldNumber = 1;
    private MessageTypeProto messageType_;
    public const int RequestIdFieldNumber = 2;
    private int requestId_;
    public const int InitiatorUserIdFieldNumber = 3;
    private int initiatorUserId_;
    public const int SessionIdHashFieldNumber = 4;
    private int sessionIdHash_;
    public const int SequenceNumberFieldNumber = 5;
    private int sequenceNumber_;

    [DebuggerNonUserCode]
    public static MessageParser<MessageHeaderProto> Parser => MessageHeaderProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformCommonReflection.Descriptor.MessageTypes[4];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => MessageHeaderProto.Descriptor;

    [DebuggerNonUserCode]
    public MessageHeaderProto()
    {
    }

    [DebuggerNonUserCode]
    public MessageHeaderProto(MessageHeaderProto other)
      : this()
    {
      this.messageType_ = other.messageType_;
      this.requestId_ = other.requestId_;
      this.initiatorUserId_ = other.initiatorUserId_;
      this.sessionIdHash_ = other.sessionIdHash_;
      this.sequenceNumber_ = other.sequenceNumber_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public MessageHeaderProto Clone() => new MessageHeaderProto(this);

    [DebuggerNonUserCode]
    public MessageTypeProto MessageType
    {
      get => this.messageType_;
      set => this.messageType_ = value;
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
    public int SessionIdHash
    {
      get => this.sessionIdHash_;
      set => this.sessionIdHash_ = value;
    }

    [DebuggerNonUserCode]
    public int SequenceNumber
    {
      get => this.sequenceNumber_;
      set => this.sequenceNumber_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as MessageHeaderProto);

    [DebuggerNonUserCode]
    public bool Equals(MessageHeaderProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.MessageType == other.MessageType && this.RequestId == other.RequestId && (this.InitiatorUserId == other.InitiatorUserId && this.SessionIdHash == other.SessionIdHash) && this.SequenceNumber == other.SequenceNumber && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      if (this.MessageType != MessageTypeProto.UndefinedMessageType)
        num1 ^= this.MessageType.GetHashCode();
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
      if (this.SessionIdHash != 0)
      {
        int num3 = num1;
        num2 = this.SessionIdHash;
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
      if (this._unknownFields != null)
        num1 ^= this._unknownFields.GetHashCode();
      return num1;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.MessageType != MessageTypeProto.UndefinedMessageType)
      {
        output.WriteRawTag((byte) 8);
        output.WriteEnum((int) this.MessageType);
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
      if (this.SessionIdHash != 0)
      {
        output.WriteRawTag((byte) 32);
        output.WriteInt32(this.SessionIdHash);
      }
      if (this.SequenceNumber != 0)
      {
        output.WriteRawTag((byte) 40);
        output.WriteInt32(this.SequenceNumber);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.MessageType != MessageTypeProto.UndefinedMessageType)
        num += 1 + CodedOutputStream.ComputeEnumSize((int) this.MessageType);
      if (this.RequestId != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.RequestId);
      if (this.InitiatorUserId != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.InitiatorUserId);
      if (this.SessionIdHash != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.SessionIdHash);
      if (this.SequenceNumber != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.SequenceNumber);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(MessageHeaderProto other)
    {
      if (other == null)
        return;
      if (other.MessageType != MessageTypeProto.UndefinedMessageType)
        this.MessageType = other.MessageType;
      if (other.RequestId != 0)
        this.RequestId = other.RequestId;
      if (other.InitiatorUserId != 0)
        this.InitiatorUserId = other.InitiatorUserId;
      if (other.SessionIdHash != 0)
        this.SessionIdHash = other.SessionIdHash;
      if (other.SequenceNumber != 0)
        this.SequenceNumber = other.SequenceNumber;
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
            this.MessageType = (MessageTypeProto) input.ReadEnum();
            continue;
          case 16:
            this.RequestId = input.ReadInt32();
            continue;
          case 24:
            this.InitiatorUserId = input.ReadInt32();
            continue;
          case 32:
            this.SessionIdHash = input.ReadInt32();
            continue;
          case 40:
            this.SequenceNumber = input.ReadInt32();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
