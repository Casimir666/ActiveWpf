// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.AccountsTradeSummaryPrevDayNotificationProto
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
  public sealed class AccountsTradeSummaryPrevDayNotificationProto : 
    IMessage<AccountsTradeSummaryPrevDayNotificationProto>,
    IMessage,
    IEquatable<AccountsTradeSummaryPrevDayNotificationProto>,
    IDeepCloneable<AccountsTradeSummaryPrevDayNotificationProto>
  {
    private static readonly MessageParser<AccountsTradeSummaryPrevDayNotificationProto> _parser = new MessageParser<AccountsTradeSummaryPrevDayNotificationProto>((Func<AccountsTradeSummaryPrevDayNotificationProto>) (() => new AccountsTradeSummaryPrevDayNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int AccountTradeSummaryFieldNumber = 1;
    private static readonly FieldCodec<AccountTradeSummaryWithAccountIDProto> _repeated_accountTradeSummary_codec = FieldCodec.ForMessage<AccountTradeSummaryWithAccountIDProto>(10U, AccountTradeSummaryWithAccountIDProto.Parser);
    private readonly RepeatedField<AccountTradeSummaryWithAccountIDProto> accountTradeSummary_ = new RepeatedField<AccountTradeSummaryWithAccountIDProto>();

    [DebuggerNonUserCode]
    public static MessageParser<AccountsTradeSummaryPrevDayNotificationProto> Parser => AccountsTradeSummaryPrevDayNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[221];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => AccountsTradeSummaryPrevDayNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public AccountsTradeSummaryPrevDayNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public AccountsTradeSummaryPrevDayNotificationProto(
      AccountsTradeSummaryPrevDayNotificationProto other)
      : this()
    {
      this.accountTradeSummary_ = other.accountTradeSummary_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public AccountsTradeSummaryPrevDayNotificationProto Clone() => new AccountsTradeSummaryPrevDayNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<AccountTradeSummaryWithAccountIDProto> AccountTradeSummary => this.accountTradeSummary_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as AccountsTradeSummaryPrevDayNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(AccountsTradeSummaryPrevDayNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.accountTradeSummary_.Equals(other.accountTradeSummary_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.accountTradeSummary_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.accountTradeSummary_.WriteTo(output, AccountsTradeSummaryPrevDayNotificationProto._repeated_accountTradeSummary_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.accountTradeSummary_.CalculateSize(AccountsTradeSummaryPrevDayNotificationProto._repeated_accountTradeSummary_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(AccountsTradeSummaryPrevDayNotificationProto other)
    {
      if (other == null)
        return;
      this.accountTradeSummary_.Add((IEnumerable<AccountTradeSummaryWithAccountIDProto>) other.accountTradeSummary_);
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
          this.accountTradeSummary_.AddEntriesFrom(input, AccountsTradeSummaryPrevDayNotificationProto._repeated_accountTradeSummary_codec);
      }
    }
  }
}
