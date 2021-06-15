// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetAccountsFilteredNotificationProto
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
  public sealed class GetAccountsFilteredNotificationProto : 
    IMessage<GetAccountsFilteredNotificationProto>,
    IMessage,
    IEquatable<GetAccountsFilteredNotificationProto>,
    IDeepCloneable<GetAccountsFilteredNotificationProto>
  {
    private static readonly MessageParser<GetAccountsFilteredNotificationProto> _parser = new MessageParser<GetAccountsFilteredNotificationProto>((Func<GetAccountsFilteredNotificationProto>) (() => new GetAccountsFilteredNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int AccountsFieldNumber = 1;
    private static readonly FieldCodec<AccountProto> _repeated_accounts_codec = FieldCodec.ForMessage<AccountProto>(10U, AccountProto.Parser);
    private readonly RepeatedField<AccountProto> accounts_ = new RepeatedField<AccountProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetAccountsFilteredNotificationProto> Parser => GetAccountsFilteredNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[52];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetAccountsFilteredNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetAccountsFilteredNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetAccountsFilteredNotificationProto(GetAccountsFilteredNotificationProto other)
      : this()
    {
      this.accounts_ = other.accounts_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetAccountsFilteredNotificationProto Clone() => new GetAccountsFilteredNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<AccountProto> Accounts => this.accounts_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetAccountsFilteredNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetAccountsFilteredNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.accounts_.Equals(other.accounts_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.accounts_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.accounts_.WriteTo(output, GetAccountsFilteredNotificationProto._repeated_accounts_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.accounts_.CalculateSize(GetAccountsFilteredNotificationProto._repeated_accounts_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetAccountsFilteredNotificationProto other)
    {
      if (other == null)
        return;
      this.accounts_.Add((IEnumerable<AccountProto>) other.accounts_);
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
          this.accounts_.AddEntriesFrom(input, GetAccountsFilteredNotificationProto._repeated_accounts_codec);
      }
    }
  }
}
