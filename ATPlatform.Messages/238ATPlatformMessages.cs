// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.ClientMessagesReadForAccountRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class ClientMessagesReadForAccountRequestProto : 
    IMessage<ClientMessagesReadForAccountRequestProto>,
    IMessage,
    IEquatable<ClientMessagesReadForAccountRequestProto>,
    IDeepCloneable<ClientMessagesReadForAccountRequestProto>
  {
    private static readonly MessageParser<ClientMessagesReadForAccountRequestProto> _parser = new MessageParser<ClientMessagesReadForAccountRequestProto>((Func<ClientMessagesReadForAccountRequestProto>) (() => new ClientMessagesReadForAccountRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int AccountIdFieldNumber = 1;
    private int accountId_;
    public const int PlatformIdFieldNumber = 2;
    private string platformId_ = "";
    public const int StateFieldNumber = 3;
    private ClientMessageAccountStateProto state_;
    public const int ClientMessagesIdsFieldNumber = 4;
    private static readonly FieldCodec<int> _repeated_clientMessagesIds_codec = FieldCodec.ForInt32(34U);
    private readonly RepeatedField<int> clientMessagesIds_ = new RepeatedField<int>();

    [DebuggerNonUserCode]
    public static MessageParser<ClientMessagesReadForAccountRequestProto> Parser => ClientMessagesReadForAccountRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[240];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => ClientMessagesReadForAccountRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public ClientMessagesReadForAccountRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public ClientMessagesReadForAccountRequestProto(ClientMessagesReadForAccountRequestProto other)
      : this()
    {
      this.accountId_ = other.accountId_;
      this.platformId_ = other.platformId_;
      this.state_ = other.state_;
      this.clientMessagesIds_ = other.clientMessagesIds_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public ClientMessagesReadForAccountRequestProto Clone() => new ClientMessagesReadForAccountRequestProto(this);

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
    public ClientMessageAccountStateProto State
    {
      get => this.state_;
      set => this.state_ = value;
    }

    [DebuggerNonUserCode]
    public RepeatedField<int> ClientMessagesIds => this.clientMessagesIds_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as ClientMessagesReadForAccountRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(ClientMessagesReadForAccountRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.AccountId == other.AccountId && !(this.PlatformId != other.PlatformId) && (this.State == other.State && this.clientMessagesIds_.Equals(other.clientMessagesIds_)) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      if (this.AccountId != 0)
        num1 ^= this.AccountId.GetHashCode();
      if (this.PlatformId.Length != 0)
        num1 ^= this.PlatformId.GetHashCode();
      if (this.State != ClientMessageAccountStateProto.UndefinedClientMessageAccountState)
        num1 ^= this.State.GetHashCode();
      int num2 = num1 ^ this.clientMessagesIds_.GetHashCode();
      if (this._unknownFields != null)
        num2 ^= this._unknownFields.GetHashCode();
      return num2;
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
      if (this.State != ClientMessageAccountStateProto.UndefinedClientMessageAccountState)
      {
        output.WriteRawTag((byte) 24);
        output.WriteEnum((int) this.State);
      }
      this.clientMessagesIds_.WriteTo(output, ClientMessagesReadForAccountRequestProto._repeated_clientMessagesIds_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num1 = 0;
      if (this.AccountId != 0)
        num1 += 1 + CodedOutputStream.ComputeInt32Size(this.AccountId);
      if (this.PlatformId.Length != 0)
        num1 += 1 + CodedOutputStream.ComputeStringSize(this.PlatformId);
      if (this.State != ClientMessageAccountStateProto.UndefinedClientMessageAccountState)
        num1 += 1 + CodedOutputStream.ComputeEnumSize((int) this.State);
      int num2 = num1 + this.clientMessagesIds_.CalculateSize(ClientMessagesReadForAccountRequestProto._repeated_clientMessagesIds_codec);
      if (this._unknownFields != null)
        num2 += this._unknownFields.CalculateSize();
      return num2;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(ClientMessagesReadForAccountRequestProto other)
    {
      if (other == null)
        return;
      if (other.AccountId != 0)
        this.AccountId = other.AccountId;
      if (other.PlatformId.Length != 0)
        this.PlatformId = other.PlatformId;
      if (other.State != ClientMessageAccountStateProto.UndefinedClientMessageAccountState)
        this.State = other.State;
      this.clientMessagesIds_.Add((IEnumerable<int>) other.clientMessagesIds_);
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
            this.State = (ClientMessageAccountStateProto) input.ReadEnum();
            continue;
          case 32:
          case 34:
            this.clientMessagesIds_.AddEntriesFrom(input, ClientMessagesReadForAccountRequestProto._repeated_clientMessagesIds_codec);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
