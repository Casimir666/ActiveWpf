// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.OrderRequestProto
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
  public sealed class OrderRequestProto : 
    IMessage<OrderRequestProto>,
    IMessage,
    IEquatable<OrderRequestProto>,
    IDeepCloneable<OrderRequestProto>
  {
    private static readonly MessageParser<OrderRequestProto> _parser = new MessageParser<OrderRequestProto>((Func<OrderRequestProto>) (() => new OrderRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int AccountIdFieldNumber = 1;
    private int accountId_;
    public const int OrderIdFieldNumber = 2;
    private long orderId_;
    public const int SymbolFieldNumber = 3;
    private string symbol_ = "";
    public const int TypeFieldNumber = 4;
    private OrderTypeProto type_;
    public const int LotsFieldNumber = 5;
    private double lots_;
    public const int PriceFieldNumber = 6;
    private double price_;
    public const int StopLossFieldNumber = 7;
    private double stopLoss_;
    public const int TakeProfitFieldNumber = 8;
    private double takeProfit_;
    public const int ExpirationFieldNumber = 9;
    private long expiration_;
    public const int CommentFieldNumber = 10;
    private string comment_ = "";
    public const int OrderbyIdFieldNumber = 11;
    private long orderbyId_;
    public const int TrailingStopTier1ThresholdFieldNumber = 12;
    private double trailingStopTier1Threshold_;
    public const int TrailingStopTier1FieldNumber = 13;
    private double trailingStopTier1_;
    public const int TrailingStopTier2ThresholdFieldNumber = 14;
    private double trailingStopTier2Threshold_;
    public const int TrailingStopTier2FieldNumber = 15;
    private double trailingStopTier2_;
    public const int TrailingStopTier3ThresholdFieldNumber = 16;
    private double trailingStopTier3Threshold_;
    public const int TrailingStopTier3FieldNumber = 17;
    private double trailingStopTier3_;
    public const int PullbackTrailingStopTier1FieldNumber = 18;
    private double pullbackTrailingStopTier1_;
    public const int PullbackTrailingStopTier1ThresholdFieldNumber = 19;
    private double pullbackTrailingStopTier1Threshold_;
    public const int PullbackTrailingStopTier2FieldNumber = 20;
    private double pullbackTrailingStopTier2_;
    public const int PullbackTrailingStopTier2ThresholdFieldNumber = 21;
    private double pullbackTrailingStopTier2Threshold_;
    public const int PullbackTrailingStopTier3FieldNumber = 22;
    private double pullbackTrailingStopTier3_;
    public const int PullbackTrailingStopTier3ThresholdFieldNumber = 23;
    private double pullbackTrailingStopTier3Threshold_;

    [DebuggerNonUserCode]
    public static MessageParser<OrderRequestProto> Parser => OrderRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[5];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => OrderRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public OrderRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public OrderRequestProto(OrderRequestProto other)
      : this()
    {
      this.accountId_ = other.accountId_;
      this.orderId_ = other.orderId_;
      this.symbol_ = other.symbol_;
      this.type_ = other.type_;
      this.lots_ = other.lots_;
      this.price_ = other.price_;
      this.stopLoss_ = other.stopLoss_;
      this.takeProfit_ = other.takeProfit_;
      this.expiration_ = other.expiration_;
      this.comment_ = other.comment_;
      this.orderbyId_ = other.orderbyId_;
      this.trailingStopTier1Threshold_ = other.trailingStopTier1Threshold_;
      this.trailingStopTier1_ = other.trailingStopTier1_;
      this.trailingStopTier2Threshold_ = other.trailingStopTier2Threshold_;
      this.trailingStopTier2_ = other.trailingStopTier2_;
      this.trailingStopTier3Threshold_ = other.trailingStopTier3Threshold_;
      this.trailingStopTier3_ = other.trailingStopTier3_;
      this.pullbackTrailingStopTier1_ = other.pullbackTrailingStopTier1_;
      this.pullbackTrailingStopTier1Threshold_ = other.pullbackTrailingStopTier1Threshold_;
      this.pullbackTrailingStopTier2_ = other.pullbackTrailingStopTier2_;
      this.pullbackTrailingStopTier2Threshold_ = other.pullbackTrailingStopTier2Threshold_;
      this.pullbackTrailingStopTier3_ = other.pullbackTrailingStopTier3_;
      this.pullbackTrailingStopTier3Threshold_ = other.pullbackTrailingStopTier3Threshold_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public OrderRequestProto Clone() => new OrderRequestProto(this);

    [DebuggerNonUserCode]
    public int AccountId
    {
      get => this.accountId_;
      set => this.accountId_ = value;
    }

    [DebuggerNonUserCode]
    public long OrderId
    {
      get => this.orderId_;
      set => this.orderId_ = value;
    }

    [DebuggerNonUserCode]
    public string Symbol
    {
      get => this.symbol_;
      set => this.symbol_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public OrderTypeProto Type
    {
      get => this.type_;
      set => this.type_ = value;
    }

    [DebuggerNonUserCode]
    public double Lots
    {
      get => this.lots_;
      set => this.lots_ = value;
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
    public long Expiration
    {
      get => this.expiration_;
      set => this.expiration_ = value;
    }

    [DebuggerNonUserCode]
    public string Comment
    {
      get => this.comment_;
      set => this.comment_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public long OrderbyId
    {
      get => this.orderbyId_;
      set => this.orderbyId_ = value;
    }

    [DebuggerNonUserCode]
    public double TrailingStopTier1Threshold
    {
      get => this.trailingStopTier1Threshold_;
      set => this.trailingStopTier1Threshold_ = value;
    }

    [DebuggerNonUserCode]
    public double TrailingStopTier1
    {
      get => this.trailingStopTier1_;
      set => this.trailingStopTier1_ = value;
    }

    [DebuggerNonUserCode]
    public double TrailingStopTier2Threshold
    {
      get => this.trailingStopTier2Threshold_;
      set => this.trailingStopTier2Threshold_ = value;
    }

    [DebuggerNonUserCode]
    public double TrailingStopTier2
    {
      get => this.trailingStopTier2_;
      set => this.trailingStopTier2_ = value;
    }

    [DebuggerNonUserCode]
    public double TrailingStopTier3Threshold
    {
      get => this.trailingStopTier3Threshold_;
      set => this.trailingStopTier3Threshold_ = value;
    }

    [DebuggerNonUserCode]
    public double TrailingStopTier3
    {
      get => this.trailingStopTier3_;
      set => this.trailingStopTier3_ = value;
    }

    [DebuggerNonUserCode]
    public double PullbackTrailingStopTier1
    {
      get => this.pullbackTrailingStopTier1_;
      set => this.pullbackTrailingStopTier1_ = value;
    }

    [DebuggerNonUserCode]
    public double PullbackTrailingStopTier1Threshold
    {
      get => this.pullbackTrailingStopTier1Threshold_;
      set => this.pullbackTrailingStopTier1Threshold_ = value;
    }

    [DebuggerNonUserCode]
    public double PullbackTrailingStopTier2
    {
      get => this.pullbackTrailingStopTier2_;
      set => this.pullbackTrailingStopTier2_ = value;
    }

    [DebuggerNonUserCode]
    public double PullbackTrailingStopTier2Threshold
    {
      get => this.pullbackTrailingStopTier2Threshold_;
      set => this.pullbackTrailingStopTier2Threshold_ = value;
    }

    [DebuggerNonUserCode]
    public double PullbackTrailingStopTier3
    {
      get => this.pullbackTrailingStopTier3_;
      set => this.pullbackTrailingStopTier3_ = value;
    }

    [DebuggerNonUserCode]
    public double PullbackTrailingStopTier3Threshold
    {
      get => this.pullbackTrailingStopTier3Threshold_;
      set => this.pullbackTrailingStopTier3Threshold_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as OrderRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(OrderRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.AccountId == other.AccountId && this.OrderId == other.OrderId && (!(this.Symbol != other.Symbol) && this.Type == other.Type) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Lots, other.Lots) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Price, other.Price) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.StopLoss, other.StopLoss) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TakeProfit, other.TakeProfit))) && (this.Expiration == other.Expiration && !(this.Comment != other.Comment) && (this.OrderbyId == other.OrderbyId && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TrailingStopTier1Threshold, other.TrailingStopTier1Threshold)) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TrailingStopTier1, other.TrailingStopTier1) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TrailingStopTier2Threshold, other.TrailingStopTier2Threshold) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TrailingStopTier2, other.TrailingStopTier2) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TrailingStopTier3Threshold, other.TrailingStopTier3Threshold)))) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TrailingStopTier3, other.TrailingStopTier3) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.PullbackTrailingStopTier1, other.PullbackTrailingStopTier1) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.PullbackTrailingStopTier1Threshold, other.PullbackTrailingStopTier1Threshold) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.PullbackTrailingStopTier2, other.PullbackTrailingStopTier2)) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.PullbackTrailingStopTier2Threshold, other.PullbackTrailingStopTier2Threshold) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.PullbackTrailingStopTier3, other.PullbackTrailingStopTier3) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.PullbackTrailingStopTier3Threshold, other.PullbackTrailingStopTier3Threshold))) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      if (this.AccountId != 0)
        num1 ^= this.AccountId.GetHashCode();
      long num2;
      if (this.OrderId != 0L)
      {
        int num3 = num1;
        num2 = this.OrderId;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.Symbol.Length != 0)
        num1 ^= this.Symbol.GetHashCode();
      if (this.Type != OrderTypeProto.Unknown)
        num1 ^= this.Type.GetHashCode();
      if (this.Lots != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Lots);
      if (this.Price != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Price);
      if (this.StopLoss != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.StopLoss);
      if (this.TakeProfit != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.TakeProfit);
      if (this.Expiration != 0L)
      {
        int num3 = num1;
        num2 = this.Expiration;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.Comment.Length != 0)
        num1 ^= this.Comment.GetHashCode();
      if (this.OrderbyId != 0L)
      {
        int num3 = num1;
        num2 = this.OrderbyId;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.TrailingStopTier1Threshold != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.TrailingStopTier1Threshold);
      if (this.TrailingStopTier1 != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.TrailingStopTier1);
      if (this.TrailingStopTier2Threshold != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.TrailingStopTier2Threshold);
      if (this.TrailingStopTier2 != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.TrailingStopTier2);
      if (this.TrailingStopTier3Threshold != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.TrailingStopTier3Threshold);
      if (this.TrailingStopTier3 != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.TrailingStopTier3);
      if (this.PullbackTrailingStopTier1 != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.PullbackTrailingStopTier1);
      if (this.PullbackTrailingStopTier1Threshold != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.PullbackTrailingStopTier1Threshold);
      if (this.PullbackTrailingStopTier2 != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.PullbackTrailingStopTier2);
      if (this.PullbackTrailingStopTier2Threshold != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.PullbackTrailingStopTier2Threshold);
      if (this.PullbackTrailingStopTier3 != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.PullbackTrailingStopTier3);
      if (this.PullbackTrailingStopTier3Threshold != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.PullbackTrailingStopTier3Threshold);
      if (this._unknownFields != null)
        num1 ^= this._unknownFields.GetHashCode();
      return num1;
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
      if (this.OrderId != 0L)
      {
        output.WriteRawTag((byte) 16);
        output.WriteInt64(this.OrderId);
      }
      if (this.Symbol.Length != 0)
      {
        output.WriteRawTag((byte) 26);
        output.WriteString(this.Symbol);
      }
      if (this.Type != OrderTypeProto.Unknown)
      {
        output.WriteRawTag((byte) 32);
        output.WriteEnum((int) this.Type);
      }
      if (this.Lots != 0.0)
      {
        output.WriteRawTag((byte) 41);
        output.WriteDouble(this.Lots);
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
      if (this.Expiration != 0L)
      {
        output.WriteRawTag((byte) 72);
        output.WriteInt64(this.Expiration);
      }
      if (this.Comment.Length != 0)
      {
        output.WriteRawTag((byte) 82);
        output.WriteString(this.Comment);
      }
      if (this.OrderbyId != 0L)
      {
        output.WriteRawTag((byte) 88);
        output.WriteInt64(this.OrderbyId);
      }
      if (this.TrailingStopTier1Threshold != 0.0)
      {
        output.WriteRawTag((byte) 97);
        output.WriteDouble(this.TrailingStopTier1Threshold);
      }
      if (this.TrailingStopTier1 != 0.0)
      {
        output.WriteRawTag((byte) 105);
        output.WriteDouble(this.TrailingStopTier1);
      }
      if (this.TrailingStopTier2Threshold != 0.0)
      {
        output.WriteRawTag((byte) 113);
        output.WriteDouble(this.TrailingStopTier2Threshold);
      }
      if (this.TrailingStopTier2 != 0.0)
      {
        output.WriteRawTag((byte) 121);
        output.WriteDouble(this.TrailingStopTier2);
      }
      if (this.TrailingStopTier3Threshold != 0.0)
      {
        output.WriteRawTag((byte) 129, (byte) 1);
        output.WriteDouble(this.TrailingStopTier3Threshold);
      }
      if (this.TrailingStopTier3 != 0.0)
      {
        output.WriteRawTag((byte) 137, (byte) 1);
        output.WriteDouble(this.TrailingStopTier3);
      }
      if (this.PullbackTrailingStopTier1 != 0.0)
      {
        output.WriteRawTag((byte) 145, (byte) 1);
        output.WriteDouble(this.PullbackTrailingStopTier1);
      }
      if (this.PullbackTrailingStopTier1Threshold != 0.0)
      {
        output.WriteRawTag((byte) 153, (byte) 1);
        output.WriteDouble(this.PullbackTrailingStopTier1Threshold);
      }
      if (this.PullbackTrailingStopTier2 != 0.0)
      {
        output.WriteRawTag((byte) 161, (byte) 1);
        output.WriteDouble(this.PullbackTrailingStopTier2);
      }
      if (this.PullbackTrailingStopTier2Threshold != 0.0)
      {
        output.WriteRawTag((byte) 169, (byte) 1);
        output.WriteDouble(this.PullbackTrailingStopTier2Threshold);
      }
      if (this.PullbackTrailingStopTier3 != 0.0)
      {
        output.WriteRawTag((byte) 177, (byte) 1);
        output.WriteDouble(this.PullbackTrailingStopTier3);
      }
      if (this.PullbackTrailingStopTier3Threshold != 0.0)
      {
        output.WriteRawTag((byte) 185, (byte) 1);
        output.WriteDouble(this.PullbackTrailingStopTier3Threshold);
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
      if (this.OrderId != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.OrderId);
      if (this.Symbol.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Symbol);
      if (this.Type != OrderTypeProto.Unknown)
        num += 1 + CodedOutputStream.ComputeEnumSize((int) this.Type);
      if (this.Lots != 0.0)
        num += 9;
      if (this.Price != 0.0)
        num += 9;
      if (this.StopLoss != 0.0)
        num += 9;
      if (this.TakeProfit != 0.0)
        num += 9;
      if (this.Expiration != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.Expiration);
      if (this.Comment.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Comment);
      if (this.OrderbyId != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.OrderbyId);
      if (this.TrailingStopTier1Threshold != 0.0)
        num += 9;
      if (this.TrailingStopTier1 != 0.0)
        num += 9;
      if (this.TrailingStopTier2Threshold != 0.0)
        num += 9;
      if (this.TrailingStopTier2 != 0.0)
        num += 9;
      if (this.TrailingStopTier3Threshold != 0.0)
        num += 10;
      if (this.TrailingStopTier3 != 0.0)
        num += 10;
      if (this.PullbackTrailingStopTier1 != 0.0)
        num += 10;
      if (this.PullbackTrailingStopTier1Threshold != 0.0)
        num += 10;
      if (this.PullbackTrailingStopTier2 != 0.0)
        num += 10;
      if (this.PullbackTrailingStopTier2Threshold != 0.0)
        num += 10;
      if (this.PullbackTrailingStopTier3 != 0.0)
        num += 10;
      if (this.PullbackTrailingStopTier3Threshold != 0.0)
        num += 10;
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(OrderRequestProto other)
    {
      if (other == null)
        return;
      if (other.AccountId != 0)
        this.AccountId = other.AccountId;
      if (other.OrderId != 0L)
        this.OrderId = other.OrderId;
      if (other.Symbol.Length != 0)
        this.Symbol = other.Symbol;
      if (other.Type != OrderTypeProto.Unknown)
        this.Type = other.Type;
      if (other.Lots != 0.0)
        this.Lots = other.Lots;
      if (other.Price != 0.0)
        this.Price = other.Price;
      if (other.StopLoss != 0.0)
        this.StopLoss = other.StopLoss;
      if (other.TakeProfit != 0.0)
        this.TakeProfit = other.TakeProfit;
      if (other.Expiration != 0L)
        this.Expiration = other.Expiration;
      if (other.Comment.Length != 0)
        this.Comment = other.Comment;
      if (other.OrderbyId != 0L)
        this.OrderbyId = other.OrderbyId;
      if (other.TrailingStopTier1Threshold != 0.0)
        this.TrailingStopTier1Threshold = other.TrailingStopTier1Threshold;
      if (other.TrailingStopTier1 != 0.0)
        this.TrailingStopTier1 = other.TrailingStopTier1;
      if (other.TrailingStopTier2Threshold != 0.0)
        this.TrailingStopTier2Threshold = other.TrailingStopTier2Threshold;
      if (other.TrailingStopTier2 != 0.0)
        this.TrailingStopTier2 = other.TrailingStopTier2;
      if (other.TrailingStopTier3Threshold != 0.0)
        this.TrailingStopTier3Threshold = other.TrailingStopTier3Threshold;
      if (other.TrailingStopTier3 != 0.0)
        this.TrailingStopTier3 = other.TrailingStopTier3;
      if (other.PullbackTrailingStopTier1 != 0.0)
        this.PullbackTrailingStopTier1 = other.PullbackTrailingStopTier1;
      if (other.PullbackTrailingStopTier1Threshold != 0.0)
        this.PullbackTrailingStopTier1Threshold = other.PullbackTrailingStopTier1Threshold;
      if (other.PullbackTrailingStopTier2 != 0.0)
        this.PullbackTrailingStopTier2 = other.PullbackTrailingStopTier2;
      if (other.PullbackTrailingStopTier2Threshold != 0.0)
        this.PullbackTrailingStopTier2Threshold = other.PullbackTrailingStopTier2Threshold;
      if (other.PullbackTrailingStopTier3 != 0.0)
        this.PullbackTrailingStopTier3 = other.PullbackTrailingStopTier3;
      if (other.PullbackTrailingStopTier3Threshold != 0.0)
        this.PullbackTrailingStopTier3Threshold = other.PullbackTrailingStopTier3Threshold;
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
          case 16:
            this.OrderId = input.ReadInt64();
            continue;
          case 26:
            this.Symbol = input.ReadString();
            continue;
          case 32:
            this.Type = (OrderTypeProto) input.ReadEnum();
            continue;
          case 41:
            this.Lots = input.ReadDouble();
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
            this.Expiration = input.ReadInt64();
            continue;
          case 82:
            this.Comment = input.ReadString();
            continue;
          case 88:
            this.OrderbyId = input.ReadInt64();
            continue;
          case 97:
            this.TrailingStopTier1Threshold = input.ReadDouble();
            continue;
          case 105:
            this.TrailingStopTier1 = input.ReadDouble();
            continue;
          case 113:
            this.TrailingStopTier2Threshold = input.ReadDouble();
            continue;
          case 121:
            this.TrailingStopTier2 = input.ReadDouble();
            continue;
          case 129:
            this.TrailingStopTier3Threshold = input.ReadDouble();
            continue;
          case 137:
            this.TrailingStopTier3 = input.ReadDouble();
            continue;
          case 145:
            this.PullbackTrailingStopTier1 = input.ReadDouble();
            continue;
          case 153:
            this.PullbackTrailingStopTier1Threshold = input.ReadDouble();
            continue;
          case 161:
            this.PullbackTrailingStopTier2 = input.ReadDouble();
            continue;
          case 169:
            this.PullbackTrailingStopTier2Threshold = input.ReadDouble();
            continue;
          case 177:
            this.PullbackTrailingStopTier3 = input.ReadDouble();
            continue;
          case 185:
            this.PullbackTrailingStopTier3Threshold = input.ReadDouble();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
