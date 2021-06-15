// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.AccountStatementNotificationProto
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
  public sealed class AccountStatementNotificationProto : 
    IMessage<AccountStatementNotificationProto>,
    IMessage,
    IEquatable<AccountStatementNotificationProto>,
    IDeepCloneable<AccountStatementNotificationProto>
  {
    private static readonly MessageParser<AccountStatementNotificationProto> _parser = new MessageParser<AccountStatementNotificationProto>((Func<AccountStatementNotificationProto>) (() => new AccountStatementNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int AccountIdFieldNumber = 1;
    private int accountId_;
    public const int AccountStatementFieldNumber = 2;
    private static readonly FieldCodec<AccountStatementProto> _repeated_accountStatement_codec = FieldCodec.ForMessage<AccountStatementProto>(18U, AccountStatementProto.Parser);
    private readonly RepeatedField<AccountStatementProto> accountStatement_ = new RepeatedField<AccountStatementProto>();

    [DebuggerNonUserCode]
    public static MessageParser<AccountStatementNotificationProto> Parser => AccountStatementNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[144];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => AccountStatementNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public AccountStatementNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public AccountStatementNotificationProto(AccountStatementNotificationProto other)
      : this()
    {
      this.accountId_ = other.accountId_;
      this.accountStatement_ = other.accountStatement_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public AccountStatementNotificationProto Clone() => new AccountStatementNotificationProto(this);

    [DebuggerNonUserCode]
    public int AccountId
    {
      get => this.accountId_;
      set => this.accountId_ = value;
    }

    [DebuggerNonUserCode]
    public RepeatedField<AccountStatementProto> AccountStatement => this.accountStatement_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as AccountStatementNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(AccountStatementNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.AccountId == other.AccountId && this.accountStatement_.Equals(other.accountStatement_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      if (this.AccountId != 0)
        num1 ^= this.AccountId.GetHashCode();
      int num2 = num1 ^ this.accountStatement_.GetHashCode();
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
      this.accountStatement_.WriteTo(output, AccountStatementNotificationProto._repeated_accountStatement_codec);
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
      int num2 = num1 + this.accountStatement_.CalculateSize(AccountStatementNotificationProto._repeated_accountStatement_codec);
      if (this._unknownFields != null)
        num2 += this._unknownFields.CalculateSize();
      return num2;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(AccountStatementNotificationProto other)
    {
      if (other == null)
        return;
      if (other.AccountId != 0)
        this.AccountId = other.AccountId;
      this.accountStatement_.Add((IEnumerable<AccountStatementProto>) other.accountStatement_);
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
            this.accountStatement_.AddEntriesFrom(input, AccountStatementNotificationProto._repeated_accountStatement_codec);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
