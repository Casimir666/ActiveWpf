// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.ClientMessageAccountProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class ClientMessageAccountProto : 
    IMessage<ClientMessageAccountProto>,
    IMessage,
    IEquatable<ClientMessageAccountProto>,
    IDeepCloneable<ClientMessageAccountProto>
  {
    private static readonly MessageParser<ClientMessageAccountProto> _parser = new MessageParser<ClientMessageAccountProto>((Func<ClientMessageAccountProto>) (() => new ClientMessageAccountProto()));
    private UnknownFieldSet _unknownFields;
    public const int IdFieldNumber = 1;
    private int id_;
    public const int AccountIdFieldNumber = 2;
    private int accountId_;
    public const int MessageIdFieldNumber = 3;
    private int messageId_;
    public const int TimestampFieldNumber = 4;
    private long timestamp_;
    public const int StateFieldNumber = 5;
    private ClientMessageAccountStateProto state_;

    [DebuggerNonUserCode]
    public static MessageParser<ClientMessageAccountProto> Parser => ClientMessageAccountProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[222];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => ClientMessageAccountProto.Descriptor;

    [DebuggerNonUserCode]
    public ClientMessageAccountProto()
    {
    }

    [DebuggerNonUserCode]
    public ClientMessageAccountProto(ClientMessageAccountProto other)
      : this()
    {
      this.id_ = other.id_;
      this.accountId_ = other.accountId_;
      this.messageId_ = other.messageId_;
      this.timestamp_ = other.timestamp_;
      this.state_ = other.state_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public ClientMessageAccountProto Clone() => new ClientMessageAccountProto(this);

    [DebuggerNonUserCode]
    public int Id
    {
      get => this.id_;
      set => this.id_ = value;
    }

    [DebuggerNonUserCode]
    public int AccountId
    {
      get => this.accountId_;
      set => this.accountId_ = value;
    }

    [DebuggerNonUserCode]
    public int MessageId
    {
      get => this.messageId_;
      set => this.messageId_ = value;
    }

    [DebuggerNonUserCode]
    public long Timestamp
    {
      get => this.timestamp_;
      set => this.timestamp_ = value;
    }

    [DebuggerNonUserCode]
    public ClientMessageAccountStateProto State
    {
      get => this.state_;
      set => this.state_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as ClientMessageAccountProto);

    [DebuggerNonUserCode]
    public bool Equals(ClientMessageAccountProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.Id == other.Id && this.AccountId == other.AccountId && (this.MessageId == other.MessageId && this.Timestamp == other.Timestamp) && this.State == other.State && object.Equals((object) this._unknownFields, (object) other._unknownFields);
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
      if (this.AccountId != 0)
      {
        int num3 = num1;
        num2 = this.AccountId;
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
      if (this.Timestamp != 0L)
        num1 ^= this.Timestamp.GetHashCode();
      if (this.State != ClientMessageAccountStateProto.UndefinedClientMessageAccountState)
        num1 ^= this.State.GetHashCode();
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
      if (this.AccountId != 0)
      {
        output.WriteRawTag((byte) 16);
        output.WriteInt32(this.AccountId);
      }
      if (this.MessageId != 0)
      {
        output.WriteRawTag((byte) 24);
        output.WriteInt32(this.MessageId);
      }
      if (this.Timestamp != 0L)
      {
        output.WriteRawTag((byte) 32);
        output.WriteInt64(this.Timestamp);
      }
      if (this.State != ClientMessageAccountStateProto.UndefinedClientMessageAccountState)
      {
        output.WriteRawTag((byte) 40);
        output.WriteEnum((int) this.State);
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
      if (this.AccountId != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.AccountId);
      if (this.MessageId != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.MessageId);
      if (this.Timestamp != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.Timestamp);
      if (this.State != ClientMessageAccountStateProto.UndefinedClientMessageAccountState)
        num += 1 + CodedOutputStream.ComputeEnumSize((int) this.State);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(ClientMessageAccountProto other)
    {
      if (other == null)
        return;
      if (other.Id != 0)
        this.Id = other.Id;
      if (other.AccountId != 0)
        this.AccountId = other.AccountId;
      if (other.MessageId != 0)
        this.MessageId = other.MessageId;
      if (other.Timestamp != 0L)
        this.Timestamp = other.Timestamp;
      if (other.State != ClientMessageAccountStateProto.UndefinedClientMessageAccountState)
        this.State = other.State;
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
            this.AccountId = input.ReadInt32();
            continue;
          case 24:
            this.MessageId = input.ReadInt32();
            continue;
          case 32:
            this.Timestamp = input.ReadInt64();
            continue;
          case 40:
            this.State = (ClientMessageAccountStateProto) input.ReadEnum();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
