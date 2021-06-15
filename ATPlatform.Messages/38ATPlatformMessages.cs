// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.AccountEquitiesNotificationProto
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
  public sealed class AccountEquitiesNotificationProto : 
    IMessage<AccountEquitiesNotificationProto>,
    IMessage,
    IEquatable<AccountEquitiesNotificationProto>,
    IDeepCloneable<AccountEquitiesNotificationProto>
  {
    private static readonly MessageParser<AccountEquitiesNotificationProto> _parser = new MessageParser<AccountEquitiesNotificationProto>((Func<AccountEquitiesNotificationProto>) (() => new AccountEquitiesNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int AccountEquitiesFieldNumber = 1;
    private static readonly FieldCodec<AccountEquityProto> _repeated_accountEquities_codec = FieldCodec.ForMessage<AccountEquityProto>(10U, AccountEquityProto.Parser);
    private readonly RepeatedField<AccountEquityProto> accountEquities_ = new RepeatedField<AccountEquityProto>();

    [DebuggerNonUserCode]
    public static MessageParser<AccountEquitiesNotificationProto> Parser => AccountEquitiesNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[20];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => AccountEquitiesNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public AccountEquitiesNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public AccountEquitiesNotificationProto(AccountEquitiesNotificationProto other)
      : this()
    {
      this.accountEquities_ = other.accountEquities_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public AccountEquitiesNotificationProto Clone() => new AccountEquitiesNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<AccountEquityProto> AccountEquities => this.accountEquities_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as AccountEquitiesNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(AccountEquitiesNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.accountEquities_.Equals(other.accountEquities_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.accountEquities_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.accountEquities_.WriteTo(output, AccountEquitiesNotificationProto._repeated_accountEquities_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.accountEquities_.CalculateSize(AccountEquitiesNotificationProto._repeated_accountEquities_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(AccountEquitiesNotificationProto other)
    {
      if (other == null)
        return;
      this.accountEquities_.Add((IEnumerable<AccountEquityProto>) other.accountEquities_);
      this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
    }

    [DebuggerNonUserCode]
    public void MergeFrom(CodedInputStream input)
    {
      uint num;
      while ((num = input.ReadTag()) != 0U)
      {
        if (num != 10U)
          this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
        else
          this.accountEquities_.AddEntriesFrom(input, AccountEquitiesNotificationProto._repeated_accountEquities_codec);
      }
    }
  }
}
