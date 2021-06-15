// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.ClientMessageReadForAccountNotificationProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class ClientMessageReadForAccountNotificationProto : 
    IMessage<ClientMessageReadForAccountNotificationProto>,
    IMessage,
    IEquatable<ClientMessageReadForAccountNotificationProto>,
    IDeepCloneable<ClientMessageReadForAccountNotificationProto>
  {
    private static readonly MessageParser<ClientMessageReadForAccountNotificationProto> _parser = new MessageParser<ClientMessageReadForAccountNotificationProto>((Func<ClientMessageReadForAccountNotificationProto>) (() => new ClientMessageReadForAccountNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int AccountIdFieldNumber = 1;
    private int accountId_;
    public const int PlatformIdFieldNumber = 2;
    private string platformId_ = "";
    public const int ClientMessageAccountFieldNumber = 3;
    private ClientMessageAccountProto clientMessageAccount_;

    [DebuggerNonUserCode]
    public static MessageParser<ClientMessageReadForAccountNotificationProto> Parser => ClientMessageReadForAccountNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[239];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => ClientMessageReadForAccountNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public ClientMessageReadForAccountNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public ClientMessageReadForAccountNotificationProto(
      ClientMessageReadForAccountNotificationProto other)
      : this()
    {
      this.accountId_ = other.accountId_;
      this.platformId_ = other.platformId_;
      this.clientMessageAccount_ = other.clientMessageAccount_ != null ? other.clientMessageAccount_.Clone() : (ClientMessageAccountProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public ClientMessageReadForAccountNotificationProto Clone() => new ClientMessageReadForAccountNotificationProto(this);

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
    public ClientMessageAccountProto ClientMessageAccount
    {
      get => this.clientMessageAccount_;
      set => this.clientMessageAccount_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as ClientMessageReadForAccountNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(ClientMessageReadForAccountNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.AccountId == other.AccountId && !(this.PlatformId != other.PlatformId) && object.Equals((object) this.ClientMessageAccount, (object) other.ClientMessageAccount) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.AccountId != 0)
        num ^= this.AccountId.GetHashCode();
      if (this.PlatformId.Length != 0)
        num ^= this.PlatformId.GetHashCode();
      if (this.clientMessageAccount_ != null)
        num ^= this.ClientMessageAccount.GetHashCode();
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
      if (this.clientMessageAccount_ != null)
      {
        output.WriteRawTag((byte) 26);
        output.WriteMessage((IMessage) this.ClientMessageAccount);
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
      if (this.clientMessageAccount_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.ClientMessageAccount);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(ClientMessageReadForAccountNotificationProto other)
    {
      if (other == null)
        return;
      if (other.AccountId != 0)
        this.AccountId = other.AccountId;
      if (other.PlatformId.Length != 0)
        this.PlatformId = other.PlatformId;
      if (other.clientMessageAccount_ != null)
      {
        if (this.clientMessageAccount_ == null)
          this.ClientMessageAccount = new ClientMessageAccountProto();
        this.ClientMessageAccount.MergeFrom(other.ClientMessageAccount);
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
            if (this.clientMessageAccount_ == null)
              this.ClientMessageAccount = new ClientMessageAccountProto();
            input.ReadMessage((IMessage) this.ClientMessageAccount);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
