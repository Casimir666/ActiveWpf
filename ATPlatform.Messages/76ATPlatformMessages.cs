// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetAccountBalanceOperationsFilteredNotificationProto
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
  public sealed class GetAccountBalanceOperationsFilteredNotificationProto : 
    IMessage<GetAccountBalanceOperationsFilteredNotificationProto>,
    IMessage,
    IEquatable<GetAccountBalanceOperationsFilteredNotificationProto>,
    IDeepCloneable<GetAccountBalanceOperationsFilteredNotificationProto>
  {
    private static readonly MessageParser<GetAccountBalanceOperationsFilteredNotificationProto> _parser = new MessageParser<GetAccountBalanceOperationsFilteredNotificationProto>((Func<GetAccountBalanceOperationsFilteredNotificationProto>) (() => new GetAccountBalanceOperationsFilteredNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int AccountBalanceOperationsFieldNumber = 1;
    private static readonly FieldCodec<AccountBalanceOperationProto> _repeated_accountBalanceOperations_codec = FieldCodec.ForMessage<AccountBalanceOperationProto>(10U, AccountBalanceOperationProto.Parser);
    private readonly RepeatedField<AccountBalanceOperationProto> accountBalanceOperations_ = new RepeatedField<AccountBalanceOperationProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetAccountBalanceOperationsFilteredNotificationProto> Parser => GetAccountBalanceOperationsFilteredNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[63];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetAccountBalanceOperationsFilteredNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetAccountBalanceOperationsFilteredNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetAccountBalanceOperationsFilteredNotificationProto(
      GetAccountBalanceOperationsFilteredNotificationProto other)
      : this()
    {
      this.accountBalanceOperations_ = other.accountBalanceOperations_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetAccountBalanceOperationsFilteredNotificationProto Clone() => new GetAccountBalanceOperationsFilteredNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<AccountBalanceOperationProto> AccountBalanceOperations => this.accountBalanceOperations_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetAccountBalanceOperationsFilteredNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(
      GetAccountBalanceOperationsFilteredNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.accountBalanceOperations_.Equals(other.accountBalanceOperations_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.accountBalanceOperations_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.accountBalanceOperations_.WriteTo(output, GetAccountBalanceOperationsFilteredNotificationProto._repeated_accountBalanceOperations_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.accountBalanceOperations_.CalculateSize(GetAccountBalanceOperationsFilteredNotificationProto._repeated_accountBalanceOperations_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(
      GetAccountBalanceOperationsFilteredNotificationProto other)
    {
      if (other == null)
        return;
      this.accountBalanceOperations_.Add((IEnumerable<AccountBalanceOperationProto>) other.accountBalanceOperations_);
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
          this.accountBalanceOperations_.AddEntriesFrom(input, GetAccountBalanceOperationsFilteredNotificationProto._repeated_accountBalanceOperations_codec);
      }
    }
  }
}
