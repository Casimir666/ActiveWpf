// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetClosedOrdersForAccountNotificationProto
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
  public sealed class GetClosedOrdersForAccountNotificationProto : 
    IMessage<GetClosedOrdersForAccountNotificationProto>,
    IMessage,
    IEquatable<GetClosedOrdersForAccountNotificationProto>,
    IDeepCloneable<GetClosedOrdersForAccountNotificationProto>
  {
    private static readonly MessageParser<GetClosedOrdersForAccountNotificationProto> _parser = new MessageParser<GetClosedOrdersForAccountNotificationProto>((Func<GetClosedOrdersForAccountNotificationProto>) (() => new GetClosedOrdersForAccountNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int AccountIdFieldNumber = 1;
    private int accountId_;
    public const int OrdersFieldNumber = 2;
    private static readonly FieldCodec<OrderProto> _repeated_orders_codec = FieldCodec.ForMessage<OrderProto>(18U, OrderProto.Parser);
    private readonly RepeatedField<OrderProto> orders_ = new RepeatedField<OrderProto>();
    public const int AccountBalanceOperationsFieldNumber = 3;
    private static readonly FieldCodec<AccountBalanceOperationProto> _repeated_accountBalanceOperations_codec = FieldCodec.ForMessage<AccountBalanceOperationProto>(26U, AccountBalanceOperationProto.Parser);
    private readonly RepeatedField<AccountBalanceOperationProto> accountBalanceOperations_ = new RepeatedField<AccountBalanceOperationProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetClosedOrdersForAccountNotificationProto> Parser => GetClosedOrdersForAccountNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[88];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetClosedOrdersForAccountNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetClosedOrdersForAccountNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetClosedOrdersForAccountNotificationProto(
      GetClosedOrdersForAccountNotificationProto other)
      : this()
    {
      this.accountId_ = other.accountId_;
      this.orders_ = other.orders_.Clone();
      this.accountBalanceOperations_ = other.accountBalanceOperations_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetClosedOrdersForAccountNotificationProto Clone() => new GetClosedOrdersForAccountNotificationProto(this);

    [DebuggerNonUserCode]
    public int AccountId
    {
      get => this.accountId_;
      set => this.accountId_ = value;
    }

    [DebuggerNonUserCode]
    public RepeatedField<OrderProto> Orders => this.orders_;

    [DebuggerNonUserCode]
    public RepeatedField<AccountBalanceOperationProto> AccountBalanceOperations => this.accountBalanceOperations_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetClosedOrdersForAccountNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetClosedOrdersForAccountNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.AccountId == other.AccountId && this.orders_.Equals(other.orders_) && this.accountBalanceOperations_.Equals(other.accountBalanceOperations_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      if (this.AccountId != 0)
        num1 ^= this.AccountId.GetHashCode();
      int num2 = num1 ^ this.orders_.GetHashCode() ^ this.accountBalanceOperations_.GetHashCode();
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
      this.orders_.WriteTo(output, GetClosedOrdersForAccountNotificationProto._repeated_orders_codec);
      this.accountBalanceOperations_.WriteTo(output, GetClosedOrdersForAccountNotificationProto._repeated_accountBalanceOperations_codec);
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
      int num2 = num1 + this.orders_.CalculateSize(GetClosedOrdersForAccountNotificationProto._repeated_orders_codec) + this.accountBalanceOperations_.CalculateSize(GetClosedOrdersForAccountNotificationProto._repeated_accountBalanceOperations_codec);
      if (this._unknownFields != null)
        num2 += this._unknownFields.CalculateSize();
      return num2;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetClosedOrdersForAccountNotificationProto other)
    {
      if (other == null)
        return;
      if (other.AccountId != 0)
        this.AccountId = other.AccountId;
      this.orders_.Add((IEnumerable<OrderProto>) other.orders_);
      this.accountBalanceOperations_.Add((IEnumerable<AccountBalanceOperationProto>) other.accountBalanceOperations_);
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
            this.orders_.AddEntriesFrom(input, GetClosedOrdersForAccountNotificationProto._repeated_orders_codec);
            continue;
          case 26:
            this.accountBalanceOperations_.AddEntriesFrom(input, GetClosedOrdersForAccountNotificationProto._repeated_accountBalanceOperations_codec);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
