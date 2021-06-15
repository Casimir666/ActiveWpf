// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.ClientMessageReadForAccountRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class ClientMessageReadForAccountRequestProto : 
    IMessage<ClientMessageReadForAccountRequestProto>,
    IMessage,
    IEquatable<ClientMessageReadForAccountRequestProto>,
    IDeepCloneable<ClientMessageReadForAccountRequestProto>
  {
    private static readonly MessageParser<ClientMessageReadForAccountRequestProto> _parser = new MessageParser<ClientMessageReadForAccountRequestProto>((Func<ClientMessageReadForAccountRequestProto>) (() => new ClientMessageReadForAccountRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int AccountIdFieldNumber = 1;
    private int accountId_;
    public const int PlatformIdFieldNumber = 2;
    private string platformId_ = "";
    public const int ClientMessageIdFieldNumber = 3;
    private int clientMessageId_;
    public const int StateFieldNumber = 4;
    private ClientMessageAccountStateProto state_;

    [DebuggerNonUserCode]
    public static MessageParser<ClientMessageReadForAccountRequestProto> Parser => ClientMessageReadForAccountRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[238];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => ClientMessageReadForAccountRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public ClientMessageReadForAccountRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public ClientMessageReadForAccountRequestProto(ClientMessageReadForAccountRequestProto other)
      : this()
    {
      this.accountId_ = other.accountId_;
      this.platformId_ = other.platformId_;
      this.clientMessageId_ = other.clientMessageId_;
      this.state_ = other.state_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public ClientMessageReadForAccountRequestProto Clone() => new ClientMessageReadForAccountRequestProto(this);

    [DebuggerNonUserCode]
    public int AccountId
    {
      get => this.accountId_;
      set => this.accountId_ = value;
    }

    [DebuggerNonUserCode]
    public string PlatformId
    {
      get => this.platformId_;
      set => this.platformId_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public int ClientMessageId
    {
      get => this.clientMessageId_;
      set => this.clientMessageId_ = value;
    }

    [DebuggerNonUserCode]
    public ClientMessageAccountStateProto State
    {
      get => this.state_;
      set => this.state_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as ClientMessageReadForAccountRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(ClientMessageReadForAccountRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.AccountId == other.AccountId && !(this.PlatformId != other.PlatformId) && (this.ClientMessageId == other.ClientMessageId && this.State == other.State) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      int num2;
      if (this.AccountId != 0)
      {
        int num3 = num1;
        num2 = this.AccountId;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.PlatformId.Length != 0)
        num1 ^= this.PlatformId.GetHashCode();
      if (this.ClientMessageId != 0)
      {
        int num3 = num1;
        num2 = this.ClientMessageId;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
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
      if (this.AccountId != 0)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt32(this.AccountId);
      }
      if (this.PlatformId.Length != 0)
      {
        output.WriteRawTag((byte) 18);
        output.WriteString(this.PlatformId);
      }
      if (this.ClientMessageId != 0)
      {
        output.WriteRawTag((byte) 24);
        output.WriteInt32(this.ClientMessageId);
      }
      if (this.State != ClientMessageAccountStateProto.UndefinedClientMessageAccountState)
      {
        output.WriteRawTag((byte) 32);
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
      if (this.AccountId != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.AccountId);
      if (this.PlatformId.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.PlatformId);
      if (this.ClientMessageId != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.ClientMessageId);
      if (this.State != ClientMessageAccountStateProto.UndefinedClientMessageAccountState)
        num += 1 + CodedOutputStream.ComputeEnumSize((int) this.State);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(ClientMessageReadForAccountRequestProto other)
    {
      if (other == null)
        return;
      if (other.AccountId != 0)
        this.AccountId = other.AccountId;
      if (other.PlatformId.Length != 0)
        this.PlatformId = other.PlatformId;
      if (other.ClientMessageId != 0)
        this.ClientMessageId = other.ClientMessageId;
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
            this.AccountId = input.ReadInt32();
            continue;
          case 18:
            this.PlatformId = input.ReadString();
            continue;
          case 24:
            this.ClientMessageId = input.ReadInt32();
            continue;
          case 32:
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
