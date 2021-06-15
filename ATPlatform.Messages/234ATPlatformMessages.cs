// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.ClientMessageForAccountProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class ClientMessageForAccountProto : 
    IMessage<ClientMessageForAccountProto>,
    IMessage,
    IEquatable<ClientMessageForAccountProto>,
    IDeepCloneable<ClientMessageForAccountProto>
  {
    private static readonly MessageParser<ClientMessageForAccountProto> _parser = new MessageParser<ClientMessageForAccountProto>((Func<ClientMessageForAccountProto>) (() => new ClientMessageForAccountProto()));
    private UnknownFieldSet _unknownFields;
    public const int ClientMessageFieldNumber = 1;
    private ClientMessageProto clientMessage_;
    public const int AccountFieldNumber = 2;
    private ClientMessageAccountProto account_;

    [DebuggerNonUserCode]
    public static MessageParser<ClientMessageForAccountProto> Parser => ClientMessageForAccountProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[236];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => ClientMessageForAccountProto.Descriptor;

    [DebuggerNonUserCode]
    public ClientMessageForAccountProto()
    {
    }

    [DebuggerNonUserCode]
    public ClientMessageForAccountProto(ClientMessageForAccountProto other)
      : this()
    {
      this.clientMessage_ = other.clientMessage_ != null ? other.clientMessage_.Clone() : (ClientMessageProto) null;
      this.account_ = other.account_ != null ? other.account_.Clone() : (ClientMessageAccountProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public ClientMessageForAccountProto Clone() => new ClientMessageForAccountProto(this);

    [DebuggerNonUserCode]
    public ClientMessageProto ClientMessage
    {
      get => this.clientMessage_;
      set => this.clientMessage_ = value;
    }

    [DebuggerNonUserCode]
    public ClientMessageAccountProto Account
    {
      get => this.account_;
      set => this.account_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as ClientMessageForAccountProto);

    [DebuggerNonUserCode]
    public bool Equals(ClientMessageForAccountProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return object.Equals((object) this.ClientMessage, (object) other.ClientMessage) && object.Equals((object) this.Account, (object) other.Account) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.clientMessage_ != null)
        num ^= this.ClientMessage.GetHashCode();
      if (this.account_ != null)
        num ^= this.Account.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.clientMessage_ != null)
      {
        output.WriteRawTag((byte) 10);
        output.WriteMessage((IMessage) this.ClientMessage);
      }
      if (this.account_ != null)
      {
        output.WriteRawTag((byte) 18);
        output.WriteMessage((IMessage) this.Account);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.clientMessage_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.ClientMessage);
      if (this.account_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.Account);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(ClientMessageForAccountProto other)
    {
      if (other == null)
        return;
      if (other.clientMessage_ != null)
      {
        if (this.clientMessage_ == null)
          this.ClientMessage = new ClientMessageProto();
        this.ClientMessage.MergeFrom(other.ClientMessage);
      }
      if (other.account_ != null)
      {
        if (this.account_ == null)
          this.Account = new ClientMessageAccountProto();
        this.Account.MergeFrom(other.Account);
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
          case 10:
            if (this.clientMessage_ == null)
              this.ClientMessage = new ClientMessageProto();
            input.ReadMessage((IMessage) this.ClientMessage);
            continue;
          case 18:
            if (this.account_ == null)
              this.Account = new ClientMessageAccountProto();
            input.ReadMessage((IMessage) this.Account);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
