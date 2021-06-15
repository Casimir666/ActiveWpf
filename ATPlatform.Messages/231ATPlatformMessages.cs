// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.ClientMessageForAccountNotificationProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class ClientMessageForAccountNotificationProto : 
    IMessage<ClientMessageForAccountNotificationProto>,
    IMessage,
    IEquatable<ClientMessageForAccountNotificationProto>,
    IDeepCloneable<ClientMessageForAccountNotificationProto>
  {
    private static readonly MessageParser<ClientMessageForAccountNotificationProto> _parser = new MessageParser<ClientMessageForAccountNotificationProto>((Func<ClientMessageForAccountNotificationProto>) (() => new ClientMessageForAccountNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int AccountIdFieldNumber = 1;
    private int accountId_;
    public const int PlatformIdFieldNumber = 2;
    private string platformId_ = "";
    public const int ClientMessageFieldNumber = 3;
    private ClientMessageProto clientMessage_;

    [DebuggerNonUserCode]
    public static MessageParser<ClientMessageForAccountNotificationProto> Parser => ClientMessageForAccountNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[233];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => ClientMessageForAccountNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public ClientMessageForAccountNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public ClientMessageForAccountNotificationProto(ClientMessageForAccountNotificationProto other)
      : this()
    {
      this.accountId_ = other.accountId_;
      this.platformId_ = other.platformId_;
      this.clientMessage_ = other.clientMessage_ != null ? other.clientMessage_.Clone() : (ClientMessageProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public ClientMessageForAccountNotificationProto Clone() => new ClientMessageForAccountNotificationProto(this);

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
    public ClientMessageProto ClientMessage
    {
      get => this.clientMessage_;
      set => this.clientMessage_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as ClientMessageForAccountNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(ClientMessageForAccountNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.AccountId == other.AccountId && !(this.PlatformId != other.PlatformId) && object.Equals((object) this.ClientMessage, (object) other.ClientMessage) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.AccountId != 0)
        num ^= this.AccountId.GetHashCode();
      if (this.PlatformId.Length != 0)
        num ^= this.PlatformId.GetHashCode();
      if (this.clientMessage_ != null)
        num ^= this.ClientMessage.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
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
      if (this.clientMessage_ != null)
      {
        output.WriteRawTag((byte) 26);
        output.WriteMessage((IMessage) this.ClientMessage);
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
      if (this.clientMessage_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.ClientMessage);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(ClientMessageForAccountNotificationProto other)
    {
      if (other == null)
        return;
      if (other.AccountId != 0)
        this.AccountId = other.AccountId;
      if (other.PlatformId.Length != 0)
        this.PlatformId = other.PlatformId;
      if (other.clientMessage_ != null)
      {
        if (this.clientMessage_ == null)
          this.ClientMessage = new ClientMessageProto();
        this.ClientMessage.MergeFrom(other.ClientMessage);
      }
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
          case 26:
            if (this.clientMessage_ == null)
              this.ClientMessage = new ClientMessageProto();
            input.ReadMessage((IMessage) this.ClientMessage);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
