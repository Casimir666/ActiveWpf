﻿// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.AccountNotificationProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class AccountNotificationProto : 
    IMessage<AccountNotificationProto>,
    IMessage,
    IEquatable<AccountNotificationProto>,
    IDeepCloneable<AccountNotificationProto>
  {
    private static readonly MessageParser<AccountNotificationProto> _parser = new MessageParser<AccountNotificationProto>((Func<AccountNotificationProto>) (() => new AccountNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int AccountIdFieldNumber = 1;
    private int accountId_;
    public const int AccountFieldNumber = 2;
    private AccountProto account_;

    [DebuggerNonUserCode]
    public static MessageParser<AccountNotificationProto> Parser => AccountNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[54];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => AccountNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public AccountNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public AccountNotificationProto(AccountNotificationProto other)
      : this()
    {
      this.accountId_ = other.accountId_;
      this.account_ = other.account_ != null ? other.account_.Clone() : (AccountProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public AccountNotificationProto Clone() => new AccountNotificationProto(this);

    [DebuggerNonUserCode]
    public int AccountId
    {
      get => this.accountId_;
      set => this.accountId_ = value;
    }

    [DebuggerNonUserCode]
    public AccountProto Account
    {
      get => this.account_;
      set => this.account_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as AccountNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(AccountNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.AccountId == other.AccountId && object.Equals((object) this.Account, (object) other.Account) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.AccountId != 0)
        num ^= this.AccountId.GetHashCode();
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
      if (this.AccountId != 0)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt32(this.AccountId);
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
      if (this.AccountId != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.AccountId);
      if (this.account_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.Account);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(AccountNotificationProto other)
    {
      if (other == null)
        return;
      if (other.AccountId != 0)
        this.AccountId = other.AccountId;
      if (other.account_ != null)
      {
        if (this.account_ == null)
          this.Account = new AccountProto();
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
          case 8:
            this.AccountId = input.ReadInt32();
            continue;
          case 18:
            if (this.account_ == null)
              this.Account = new AccountProto();
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
