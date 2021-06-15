// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.OrderNotificationProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class OrderNotificationProto : 
    IMessage<OrderNotificationProto>,
    IMessage,
    IEquatable<OrderNotificationProto>,
    IDeepCloneable<OrderNotificationProto>
  {
    private static readonly MessageParser<OrderNotificationProto> _parser = new MessageParser<OrderNotificationProto>((Func<OrderNotificationProto>) (() => new OrderNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int AccountIdFieldNumber = 1;
    private int accountId_;
    public const int AccountTradeSummaryFieldNumber = 2;
    private AccountTradeSummaryProto accountTradeSummary_;
    public const int OrderFieldNumber = 3;
    private OrderProto order_;

    [DebuggerNonUserCode]
    public static MessageParser<OrderNotificationProto> Parser => OrderNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[6];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => OrderNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public OrderNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public OrderNotificationProto(OrderNotificationProto other)
      : this()
    {
      this.accountId_ = other.accountId_;
      this.accountTradeSummary_ = other.accountTradeSummary_ != null ? other.accountTradeSummary_.Clone() : (AccountTradeSummaryProto) null;
      this.order_ = other.order_ != null ? other.order_.Clone() : (OrderProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public OrderNotificationProto Clone() => new OrderNotificationProto(this);

    [DebuggerNonUserCode]
    public int AccountId
    {
      get => this.accountId_;
      set => this.accountId_ = value;
    }

    [DebuggerNonUserCode]
    public AccountTradeSummaryProto AccountTradeSummary
    {
      get => this.accountTradeSummary_;
      set => this.accountTradeSummary_ = value;
    }

    [DebuggerNonUserCode]
    public OrderProto Order
    {
      get => this.order_;
      set => this.order_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as OrderNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(OrderNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.AccountId == other.AccountId && object.Equals((object) this.AccountTradeSummary, (object) other.AccountTradeSummary) && object.Equals((object) this.Order, (object) other.Order) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.AccountId != 0)
        num ^= this.AccountId.GetHashCode();
      if (this.accountTradeSummary_ != null)
        num ^= this.AccountTradeSummary.GetHashCode();
      if (this.order_ != null)
        num ^= this.Order.GetHashCode();
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
      if (this.accountTradeSummary_ != null)
      {
        output.WriteRawTag((byte) 18);
        output.WriteMessage((IMessage) this.AccountTradeSummary);
      }
      if (this.order_ != null)
      {
        output.WriteRawTag((byte) 26);
        output.WriteMessage((IMessage) this.Order);
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
      if (this.accountTradeSummary_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.AccountTradeSummary);
      if (this.order_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.Order);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(OrderNotificationProto other)
    {
      if (other == null)
        return;
      if (other.AccountId != 0)
        this.AccountId = other.AccountId;
      if (other.accountTradeSummary_ != null)
      {
        if (this.accountTradeSummary_ == null)
          this.AccountTradeSummary = new AccountTradeSummaryProto();
        this.AccountTradeSummary.MergeFrom(other.AccountTradeSummary);
      }
      if (other.order_ != null)
      {
        if (this.order_ == null)
          this.Order = new OrderProto();
        this.Order.MergeFrom(other.Order);
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
            if (this.accountTradeSummary_ == null)
              this.AccountTradeSummary = new AccountTradeSummaryProto();
            input.ReadMessage((IMessage) this.AccountTradeSummary);
            continue;
          case 26:
            if (this.order_ == null)
              this.Order = new OrderProto();
            input.ReadMessage((IMessage) this.Order);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
