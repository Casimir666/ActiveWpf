// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.ClientMessageStateHistoryProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class ClientMessageStateHistoryProto : 
    IMessage<ClientMessageStateHistoryProto>,
    IMessage,
    IEquatable<ClientMessageStateHistoryProto>,
    IDeepCloneable<ClientMessageStateHistoryProto>
  {
    private static readonly MessageParser<ClientMessageStateHistoryProto> _parser = new MessageParser<ClientMessageStateHistoryProto>((Func<ClientMessageStateHistoryProto>) (() => new ClientMessageStateHistoryProto()));
    private UnknownFieldSet _unknownFields;
    public const int IdFieldNumber = 1;
    private int id_;
    public const int MessageIdFieldNumber = 2;
    private int messageId_;
    public const int StateFieldNumber = 3;
    private ClientMessageStateProto state_;
    public const int InitiatorIdFieldNumber = 4;
    private string initiatorId_ = "";
    public const int TimestampFieldNumber = 5;
    private long timestamp_;

    [DebuggerNonUserCode]
    public static MessageParser<ClientMessageStateHistoryProto> Parser => ClientMessageStateHistoryProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[224];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => ClientMessageStateHistoryProto.Descriptor;

    [DebuggerNonUserCode]
    public ClientMessageStateHistoryProto()
    {
    }

    [DebuggerNonUserCode]
    public ClientMessageStateHistoryProto(ClientMessageStateHistoryProto other)
      : this()
    {
      this.id_ = other.id_;
      this.messageId_ = other.messageId_;
      this.state_ = other.state_;
      this.initiatorId_ = other.initiatorId_;
      this.timestamp_ = other.timestamp_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public ClientMessageStateHistoryProto Clone() => new ClientMessageStateHistoryProto(this);

    [DebuggerNonUserCode]
    public int Id
    {
      get => this.id_;
      set => this.id_ = value;
    }

    [DebuggerNonUserCode]
    public int MessageId
    {
      get => this.messageId_;
      set => this.messageId_ = value;
    }

    [DebuggerNonUserCode]
    public ClientMessageStateProto State
    {
      get => this.state_;
      set => this.state_ = value;
    }

    [DebuggerNonUserCode]
    public string InitiatorId
    {
      get => this.initiatorId_;
      set => this.initiatorId_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public long Timestamp
    {
      get => this.timestamp_;
      set => this.timestamp_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as ClientMessageStateHistoryProto);

    [DebuggerNonUserCode]
    public bool Equals(ClientMessageStateHistoryProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.Id == other.Id && this.MessageId == other.MessageId && (this.State == other.State && !(this.InitiatorId != other.InitiatorId)) && this.Timestamp == other.Timestamp && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      int num2;
      if (this.Id != 0)
      {
        int num3 = num1;
        num2 = this.Id;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.MessageId != 0)
      {
        int num3 = num1;
        num2 = this.MessageId;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.State != ClientMessageStateProto.UndefinedClientMessageState)
        num1 ^= this.State.GetHashCode();
      if (this.InitiatorId.Length != 0)
        num1 ^= this.InitiatorId.GetHashCode();
      if (this.Timestamp != 0L)
        num1 ^= this.Timestamp.GetHashCode();
      if (this._unknownFields != null)
        num1 ^= this._unknownFields.GetHashCode();
      return num1;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.Id != 0)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt32(this.Id);
      }
      if (this.MessageId != 0)
      {
        output.WriteRawTag((byte) 16);
        output.WriteInt32(this.MessageId);
      }
      if (this.State != ClientMessageStateProto.UndefinedClientMessageState)
      {
        output.WriteRawTag((byte) 24);
        output.WriteEnum((int) this.State);
      }
      if (this.InitiatorId.Length != 0)
      {
        output.WriteRawTag((byte) 34);
        output.WriteString(this.InitiatorId);
      }
      if (this.Timestamp != 0L)
      {
        output.WriteRawTag((byte) 40);
        output.WriteInt64(this.Timestamp);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.Id != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
      if (this.MessageId != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.MessageId);
      if (this.State != ClientMessageStateProto.UndefinedClientMessageState)
        num += 1 + CodedOutputStream.ComputeEnumSize((int) this.State);
      if (this.InitiatorId.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.InitiatorId);
      if (this.Timestamp != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.Timestamp);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(ClientMessageStateHistoryProto other)
    {
      if (other == null)
        return;
      if (other.Id != 0)
        this.Id = other.Id;
      if (other.MessageId != 0)
        this.MessageId = other.MessageId;
      if (other.State != ClientMessageStateProto.UndefinedClientMessageState)
        this.State = other.State;
      if (other.InitiatorId.Length != 0)
        this.InitiatorId = other.InitiatorId;
      if (other.Timestamp != 0L)
        this.Timestamp = other.Timestamp;
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
            this.Id = input.ReadInt32();
            continue;
          case 16:
            this.MessageId = input.ReadInt32();
            continue;
          case 24:
            this.State = (ClientMessageStateProto) input.ReadEnum();
            continue;
          case 34:
            this.InitiatorId = input.ReadString();
            continue;
          case 40:
            this.Timestamp = input.ReadInt64();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
