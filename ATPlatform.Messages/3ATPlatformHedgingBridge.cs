// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.HedgingBridge.BridgeMarginCheckRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL.HedgingBridge
{
  public sealed class BridgeMarginCheckRequestProto : 
    IMessage<BridgeMarginCheckRequestProto>,
    IMessage,
    IEquatable<BridgeMarginCheckRequestProto>,
    IDeepCloneable<BridgeMarginCheckRequestProto>
  {
    private static readonly MessageParser<BridgeMarginCheckRequestProto> _parser = new MessageParser<BridgeMarginCheckRequestProto>((Func<BridgeMarginCheckRequestProto>) (() => new BridgeMarginCheckRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int SymbolFieldNumber = 1;
    private string symbol_ = "";
    public const int VolumeFieldNumber = 2;
    private int volume_;
    public const int AskFieldNumber = 3;
    private double ask_;
    public const int BidFieldNumber = 4;
    private double bid_;
    public const int AccountIdFieldNumber = 5;
    private int accountId_;
    public const int HedgeSettingsSetFieldNumber = 6;
    private string hedgeSettingsSet_ = "";
    public const int HedgeLiquidityProviderFieldNumber = 7;
    private string hedgeLiquidityProvider_ = "";
    public const int SymbolDigitsFieldNumber = 8;
    private int symbolDigits_;

    [DebuggerNonUserCode]
    public static MessageParser<BridgeMarginCheckRequestProto> Parser => BridgeMarginCheckRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformHedgingBridgeReflection.Descriptor.MessageTypes[2];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => BridgeMarginCheckRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public BridgeMarginCheckRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public BridgeMarginCheckRequestProto(BridgeMarginCheckRequestProto other)
      : this()
    {
      this.symbol_ = other.symbol_;
      this.volume_ = other.volume_;
      this.ask_ = other.ask_;
      this.bid_ = other.bid_;
      this.accountId_ = other.accountId_;
      this.hedgeSettingsSet_ = other.hedgeSettingsSet_;
      this.hedgeLiquidityProvider_ = other.hedgeLiquidityProvider_;
      this.symbolDigits_ = other.symbolDigits_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public BridgeMarginCheckRequestProto Clone() => new BridgeMarginCheckRequestProto(this);

    [DebuggerNonUserCode]
    public string Symbol
    {
      get => this.symbol_;
      set => this.symbol_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public int Volume
    {
      get => this.volume_;
      set => this.volume_ = value;
    }

    [DebuggerNonUserCode]
    public double Ask
    {
      get => this.ask_;
      set => this.ask_ = value;
    }

    [DebuggerNonUserCode]
    public double Bid
    {
      get => this.bid_;
      set => this.bid_ = value;
    }

    [DebuggerNonUserCode]
    public int AccountId
    {
      get => this.accountId_;
      set => this.accountId_ = value;
    }

    [DebuggerNonUserCode]
    public string HedgeSettingsSet
    {
      get => this.hedgeSettingsSet_;
      set => this.hedgeSettingsSet_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public string HedgeLiquidityProvider
    {
      get => this.hedgeLiquidityProvider_;
      set => this.hedgeLiquidityProvider_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public int SymbolDigits
    {
      get => this.symbolDigits_;
      set => this.symbolDigits_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as BridgeMarginCheckRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(BridgeMarginCheckRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return !(this.Symbol != other.Symbol) && this.Volume == other.Volume && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Ask, other.Ask) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Bid, other.Bid)) && (this.AccountId == other.AccountId && !(this.HedgeSettingsSet != other.HedgeSettingsSet) && (!(this.HedgeLiquidityProvider != other.HedgeLiquidityProvider) && this.SymbolDigits == other.SymbolDigits)) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.Symbol.Length != 0)
        num ^= this.Symbol.GetHashCode();
      if (this.Volume != 0)
        num ^= this.Volume.GetHashCode();
      if (this.Ask != 0.0)
        num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Ask);
      if (this.Bid != 0.0)
        num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Bid);
      if (this.AccountId != 0)
        num ^= this.AccountId.GetHashCode();
      if (this.HedgeSettingsSet.Length != 0)
        num ^= this.HedgeSettingsSet.GetHashCode();
      if (this.HedgeLiquidityProvider.Length != 0)
        num ^= this.HedgeLiquidityProvider.GetHashCode();
      if (this.SymbolDigits != 0)
        num ^= this.SymbolDigits.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.Symbol.Length != 0)
      {
        output.WriteRawTag((byte) 10);
        output.WriteString(this.Symbol);
      }
      if (this.Volume != 0)
      {
        output.WriteRawTag((byte) 16);
        output.WriteInt32(this.Volume);
      }
      if (this.Ask != 0.0)
      {
        output.WriteRawTag((byte) 25);
        output.WriteDouble(this.Ask);
      }
      if (this.Bid != 0.0)
      {
        output.WriteRawTag((byte) 33);
        output.WriteDouble(this.Bid);
      }
      if (this.AccountId != 0)
      {
        output.WriteRawTag((byte) 40);
        output.WriteInt32(this.AccountId);
      }
      if (this.HedgeSettingsSet.Length != 0)
      {
        output.WriteRawTag((byte) 50);
        output.WriteString(this.HedgeSettingsSet);
      }
      if (this.HedgeLiquidityProvider.Length != 0)
      {
        output.WriteRawTag((byte) 58);
        output.WriteString(this.HedgeLiquidityProvider);
      }
      if (this.SymbolDigits != 0)
      {
        output.WriteRawTag((byte) 64);
        output.WriteInt32(this.SymbolDigits);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.Symbol.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Symbol);
      if (this.Volume != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.Volume);
      if (this.Ask != 0.0)
        num += 9;
      if (this.Bid != 0.0)
        num += 9;
      if (this.AccountId != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.AccountId);
      if (this.HedgeSettingsSet.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.HedgeSettingsSet);
      if (this.HedgeLiquidityProvider.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.HedgeLiquidityProvider);
      if (this.SymbolDigits != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.SymbolDigits);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(BridgeMarginCheckRequestProto other)
    {
      if (other == null)
        return;
      if (other.Symbol.Length != 0)
        this.Symbol = other.Symbol;
      if (other.Volume != 0)
        this.Volume = other.Volume;
      if (other.Ask != 0.0)
        this.Ask = other.Ask;
      if (other.Bid != 0.0)
        this.Bid = other.Bid;
      if (other.AccountId != 0)
        this.AccountId = other.AccountId;
      if (other.HedgeSettingsSet.Length != 0)
        this.HedgeSettingsSet = other.HedgeSettingsSet;
      if (other.HedgeLiquidityProvider.Length != 0)
        this.HedgeLiquidityProvider = other.HedgeLiquidityProvider;
      if (other.SymbolDigits != 0)
        this.SymbolDigits = other.SymbolDigits;
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
          case 10:
            this.Symbol = input.ReadString();
            continue;
          case 16:
            this.Volume = input.ReadInt32();
            continue;
          case 25:
            this.Ask = input.ReadDouble();
            continue;
          case 33:
            this.Bid = input.ReadDouble();
            continue;
          case 40:
            this.AccountId = input.ReadInt32();
            continue;
          case 50:
            this.HedgeSettingsSet = input.ReadString();
            continue;
          case 58:
            this.HedgeLiquidityProvider = input.ReadString();
            continue;
          case 64:
            this.SymbolDigits = input.ReadInt32();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
