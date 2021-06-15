// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.AccountStatementTransactionProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class AccountStatementTransactionProto : 
    IMessage<AccountStatementTransactionProto>,
    IMessage,
    IEquatable<AccountStatementTransactionProto>,
    IDeepCloneable<AccountStatementTransactionProto>
  {
    private static readonly MessageParser<AccountStatementTransactionProto> _parser = new MessageParser<AccountStatementTransactionProto>((Func<AccountStatementTransactionProto>) (() => new AccountStatementTransactionProto()));
    private UnknownFieldSet _unknownFields;
    public const int TicketFieldNumber = 1;
    private long ticket_;
    public const int OpenTimeFieldNumber = 2;
    private long openTime_;
    public const int TypeFieldNumber = 3;
    private string type_ = "";
    public const int LotsFieldNumber = 4;
    private double lots_;
    public const int ItemFieldNumber = 5;
    private string item_ = "";
    public const int PriceFieldNumber = 6;
    private double price_;
    public const int StopLossFieldNumber = 7;
    private double stopLoss_;
    public const int TakeProfitFieldNumber = 8;
    private double takeProfit_;
    public const int CloseTimeFieldNumber = 9;
    private long closeTime_;
    public const int ClosePriceFieldNumber = 10;
    private double closePrice_;
    public const int CommissionFieldNumber = 11;
    private double commission_;
    public const int RoSwapFieldNumber = 12;
    private double roSwap_;
    public const int TradeProfitLossFieldNumber = 13;
    private double tradeProfitLoss_;
    public const int BalanceFieldNumber = 14;
    private double balance_;
    public const int MarketPriceFieldNumber = 15;
    private double marketPrice_;
    public const int CommentFieldNumber = 16;
    private string comment_ = "";
    public const int DigitsFieldNumber = 17;
    private int digits_;
    public const int StateFieldNumber = 18;
    private int state_;

    [DebuggerNonUserCode]
    public static MessageParser<AccountStatementTransactionProto> Parser => AccountStatementTransactionProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[139];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => AccountStatementTransactionProto.Descriptor;

    [DebuggerNonUserCode]
    public AccountStatementTransactionProto()
    {
    }

    [DebuggerNonUserCode]
    public AccountStatementTransactionProto(AccountStatementTransactionProto other)
      : this()
    {
      this.ticket_ = other.ticket_;
      this.openTime_ = other.openTime_;
      this.type_ = other.type_;
      this.lots_ = other.lots_;
      this.item_ = other.item_;
      this.price_ = other.price_;
      this.stopLoss_ = other.stopLoss_;
      this.takeProfit_ = other.takeProfit_;
      this.closeTime_ = other.closeTime_;
      this.closePrice_ = other.closePrice_;
      this.commission_ = other.commission_;
      this.roSwap_ = other.roSwap_;
      this.tradeProfitLoss_ = other.tradeProfitLoss_;
      this.balance_ = other.balance_;
      this.marketPrice_ = other.marketPrice_;
      this.comment_ = other.comment_;
      this.digits_ = other.digits_;
      this.state_ = other.state_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public AccountStatementTransactionProto Clone() => new AccountStatementTransactionProto(this);

    [DebuggerNonUserCode]
    public long Ticket
    {
      get => this.ticket_;
      set => this.ticket_ = value;
    }

    [DebuggerNonUserCode]
    public long OpenTime
    {
      get => this.openTime_;
      set => this.openTime_ = value;
    }

    [DebuggerNonUserCode]
    public string Type
    {
      get => this.type_;
      set => this.type_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public double Lots
    {
      get => this.lots_;
      set => this.lots_ = value;
    }

    [DebuggerNonUserCode]
    public string Item
    {
      get => this.item_;
      set => this.item_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public double Price
    {
      get => this.price_;
      set => this.price_ = value;
    }

    [DebuggerNonUserCode]
    public double StopLoss
    {
      get => this.stopLoss_;
      set => this.stopLoss_ = value;
    }

    [DebuggerNonUserCode]
    public double TakeProfit
    {
      get => this.takeProfit_;
      set => this.takeProfit_ = value;
    }

    [DebuggerNonUserCode]
    public long CloseTime
    {
      get => this.closeTime_;
      set => this.closeTime_ = value;
    }

    [DebuggerNonUserCode]
    public double ClosePrice
    {
      get => this.closePrice_;
      set => this.closePrice_ = value;
    }

    [DebuggerNonUserCode]
    public double Commission
    {
      get => this.commission_;
      set => this.commission_ = value;
    }

    [DebuggerNonUserCode]
    public double RoSwap
    {
      get => this.roSwap_;
      set => this.roSwap_ = value;
    }

    [DebuggerNonUserCode]
    public double TradeProfitLoss
    {
      get => this.tradeProfitLoss_;
      set => this.tradeProfitLoss_ = value;
    }

    [DebuggerNonUserCode]
    public double Balance
    {
      get => this.balance_;
      set => this.balance_ = value;
    }

    [DebuggerNonUserCode]
    public double MarketPrice
    {
      get => this.marketPrice_;
      set => this.marketPrice_ = value;
    }

    [DebuggerNonUserCode]
    public string Comment
    {
      get => this.comment_;
      set => this.comment_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public int Digits
    {
      get => this.digits_;
      set => this.digits_ = value;
    }

    [DebuggerNonUserCode]
    public int State
    {
      get => this.state_;
      set => this.state_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as AccountStatementTransactionProto);

    [DebuggerNonUserCode]
    public bool Equals(AccountStatementTransactionProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.Ticket == other.Ticket && this.OpenTime == other.OpenTime && (!(this.Type != other.Type) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Lots, other.Lots)) && (!(this.Item != other.Item) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Price, other.Price) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.StopLoss, other.StopLoss) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TakeProfit, other.TakeProfit))) && (this.CloseTime == other.CloseTime && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.ClosePrice, other.ClosePrice) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Commission, other.Commission) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.RoSwap, other.RoSwap)) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TradeProfitLoss, other.TradeProfitLoss) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Balance, other.Balance) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.MarketPrice, other.MarketPrice) && !(this.Comment != other.Comment)))) && (this.Digits == other.Digits && this.State == other.State) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      long num2;
      if (this.Ticket != 0L)
      {
        int num3 = num1;
        num2 = this.Ticket;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.OpenTime != 0L)
      {
        int num3 = num1;
        num2 = this.OpenTime;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.Type.Length != 0)
        num1 ^= this.Type.GetHashCode();
      if (this.Lots != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Lots);
      if (this.Item.Length != 0)
        num1 ^= this.Item.GetHashCode();
      if (this.Price != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Price);
      if (this.StopLoss != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.StopLoss);
      if (this.TakeProfit != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.TakeProfit);
      if (this.CloseTime != 0L)
      {
        int num3 = num1;
        num2 = this.CloseTime;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.ClosePrice != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.ClosePrice);
      if (this.Commission != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Commission);
      if (this.RoSwap != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.RoSwap);
      if (this.TradeProfitLoss != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.TradeProfitLoss);
      if (this.Balance != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Balance);
      if (this.MarketPrice != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.MarketPrice);
      if (this.Comment.Length != 0)
        num1 ^= this.Comment.GetHashCode();
      int num4;
      if (this.Digits != 0)
      {
        int num3 = num1;
        num4 = this.Digits;
        int hashCode = num4.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.State != 0)
      {
        int num3 = num1;
        num4 = this.State;
        int hashCode = num4.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this._unknownFields != null)
        num1 ^= this._unknownFields.GetHashCode();
      return num1;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.Ticket != 0L)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt64(this.Ticket);
      }
      if (this.OpenTime != 0L)
      {
        output.WriteRawTag((byte) 16);
        output.WriteInt64(this.OpenTime);
      }
      if (this.Type.Length != 0)
      {
        output.WriteRawTag((byte) 26);
        output.WriteString(this.Type);
      }
      if (this.Lots != 0.0)
      {
        output.WriteRawTag((byte) 33);
        output.WriteDouble(this.Lots);
      }
      if (this.Item.Length != 0)
      {
        output.WriteRawTag((byte) 42);
        output.WriteString(this.Item);
      }
      if (this.Price != 0.0)
      {
        output.WriteRawTag((byte) 49);
        output.WriteDouble(this.Price);
      }
      if (this.StopLoss != 0.0)
      {
        output.WriteRawTag((byte) 57);
        output.WriteDouble(this.StopLoss);
      }
      if (this.TakeProfit != 0.0)
      {
        output.WriteRawTag((byte) 65);
        output.WriteDouble(this.TakeProfit);
      }
      if (this.CloseTime != 0L)
      {
        output.WriteRawTag((byte) 72);
        output.WriteInt64(this.CloseTime);
      }
      if (this.ClosePrice != 0.0)
      {
        output.WriteRawTag((byte) 81);
        output.WriteDouble(this.ClosePrice);
      }
      if (this.Commission != 0.0)
      {
        output.WriteRawTag((byte) 89);
        output.WriteDouble(this.Commission);
      }
      if (this.RoSwap != 0.0)
      {
        output.WriteRawTag((byte) 97);
        output.WriteDouble(this.RoSwap);
      }
      if (this.TradeProfitLoss != 0.0)
      {
        output.WriteRawTag((byte) 105);
        output.WriteDouble(this.TradeProfitLoss);
      }
      if (this.Balance != 0.0)
      {
        output.WriteRawTag((byte) 113);
        output.WriteDouble(this.Balance);
      }
      if (this.MarketPrice != 0.0)
      {
        output.WriteRawTag((byte) 121);
        output.WriteDouble(this.MarketPrice);
      }
      if (this.Comment.Length != 0)
      {
        output.WriteRawTag((byte) 130, (byte) 1);
        output.WriteString(this.Comment);
      }
      if (this.Digits != 0)
      {
        output.WriteRawTag((byte) 136, (byte) 1);
        output.WriteInt32(this.Digits);
      }
      if (this.State != 0)
      {
        output.WriteRawTag((byte) 144, (byte) 1);
        output.WriteInt32(this.State);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.Ticket != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.Ticket);
      if (this.OpenTime != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.OpenTime);
      if (this.Type.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Type);
      if (this.Lots != 0.0)
        num += 9;
      if (this.Item.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Item);
      if (this.Price != 0.0)
        num += 9;
      if (this.StopLoss != 0.0)
        num += 9;
      if (this.TakeProfit != 0.0)
        num += 9;
      if (this.CloseTime != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.CloseTime);
      if (this.ClosePrice != 0.0)
        num += 9;
      if (this.Commission != 0.0)
        num += 9;
      if (this.RoSwap != 0.0)
        num += 9;
      if (this.TradeProfitLoss != 0.0)
        num += 9;
      if (this.Balance != 0.0)
        num += 9;
      if (this.MarketPrice != 0.0)
        num += 9;
      if (this.Comment.Length != 0)
        num += 2 + CodedOutputStream.ComputeStringSize(this.Comment);
      if (this.Digits != 0)
        num += 2 + CodedOutputStream.ComputeInt32Size(this.Digits);
      if (this.State != 0)
        num += 2 + CodedOutputStream.ComputeInt32Size(this.State);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(AccountStatementTransactionProto other)
    {
      if (other == null)
        return;
      if (other.Ticket != 0L)
        this.Ticket = other.Ticket;
      if (other.OpenTime != 0L)
        this.OpenTime = other.OpenTime;
      if (other.Type.Length != 0)
        this.Type = other.Type;
      if (other.Lots != 0.0)
        this.Lots = other.Lots;
      if (other.Item.Length != 0)
        this.Item = other.Item;
      if (other.Price != 0.0)
        this.Price = other.Price;
      if (other.StopLoss != 0.0)
        this.StopLoss = other.StopLoss;
      if (other.TakeProfit != 0.0)
        this.TakeProfit = other.TakeProfit;
      if (other.CloseTime != 0L)
        this.CloseTime = other.CloseTime;
      if (other.ClosePrice != 0.0)
        this.ClosePrice = other.ClosePrice;
      if (other.Commission != 0.0)
        this.Commission = other.Commission;
      if (other.RoSwap != 0.0)
        this.RoSwap = other.RoSwap;
      if (other.TradeProfitLoss != 0.0)
        this.TradeProfitLoss = other.TradeProfitLoss;
      if (other.Balance != 0.0)
        this.Balance = other.Balance;
      if (other.MarketPrice != 0.0)
        this.MarketPrice = other.MarketPrice;
      if (other.Comment.Length != 0)
        this.Comment = other.Comment;
      if (other.Digits != 0)
        this.Digits = other.Digits;
      if (other.State != 0)
        this.State = other.State;
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
            this.Ticket = input.ReadInt64();
            continue;
          case 16:
            this.OpenTime = input.ReadInt64();
            continue;
          case 26:
            this.Type = input.ReadString();
            continue;
          case 33:
            this.Lots = input.ReadDouble();
            continue;
          case 42:
            this.Item = input.ReadString();
            continue;
          case 49:
            this.Price = input.ReadDouble();
            continue;
          case 57:
            this.StopLoss = input.ReadDouble();
            continue;
          case 65:
            this.TakeProfit = input.ReadDouble();
            continue;
          case 72:
            this.CloseTime = input.ReadInt64();
            continue;
          case 81:
            this.ClosePrice = input.ReadDouble();
            continue;
          case 89:
            this.Commission = input.ReadDouble();
            continue;
          case 97:
            this.RoSwap = input.ReadDouble();
            continue;
          case 105:
            this.TradeProfitLoss = input.ReadDouble();
            continue;
          case 113:
            this.Balance = input.ReadDouble();
            continue;
          case 121:
            this.MarketPrice = input.ReadDouble();
            continue;
          case 130:
            this.Comment = input.ReadString();
            continue;
          case 136:
            this.Digits = input.ReadInt32();
            continue;
          case 144:
            this.State = input.ReadInt32();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
