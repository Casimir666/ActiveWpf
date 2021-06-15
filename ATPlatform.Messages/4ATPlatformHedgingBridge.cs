// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.HedgingBridge.BridgeMarginCheckNotificationProto
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
  public sealed class BridgeMarginCheckNotificationProto : 
    IMessage<BridgeMarginCheckNotificationProto>,
    IMessage,
    IEquatable<BridgeMarginCheckNotificationProto>,
    IDeepCloneable<BridgeMarginCheckNotificationProto>
  {
    private static readonly MessageParser<BridgeMarginCheckNotificationProto> _parser = new MessageParser<BridgeMarginCheckNotificationProto>((Func<BridgeMarginCheckNotificationProto>) (() => new BridgeMarginCheckNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int IdFieldNumber = 1;
    private long id_;
    public const int AskFieldNumber = 2;
    private double ask_;
    public const int BidFieldNumber = 3;
    private double bid_;
    public const int SymbolFieldNumber = 4;
    private string symbol_ = "";

    [DebuggerNonUserCode]
    public static MessageParser<BridgeMarginCheckNotificationProto> Parser => BridgeMarginCheckNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformHedgingBridgeReflection.Descriptor.MessageTypes[3];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => BridgeMarginCheckNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public BridgeMarginCheckNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public BridgeMarginCheckNotificationProto(BridgeMarginCheckNotificationProto other)
      : this()
    {
      this.id_ = other.id_;
      this.ask_ = other.ask_;
      this.bid_ = other.bid_;
      this.symbol_ = other.symbol_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public BridgeMarginCheckNotificationProto Clone() => new BridgeMarginCheckNotificationProto(this);

    [DebuggerNonUserCode]
    public long Id
    {
      get => this.id_;
      set => this.id_ = value;
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
    public string Symbol
    {
      get => this.symbol_;
      set => this.symbol_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as BridgeMarginCheckNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(BridgeMarginCheckNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.Id == other.Id && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Ask, other.Ask) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Bid, other.Bid) && !(this.Symbol != other.Symbol)) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.Id != 0L)
        num ^= this.Id.GetHashCode();
      if (this.Ask != 0.0)
        num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Ask);
      if (this.Bid != 0.0)
        num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Bid);
      if (this.Symbol.Length != 0)
        num ^= this.Symbol.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.Id != 0L)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt64(this.Id);
      }
      if (this.Ask != 0.0)
      {
        output.WriteRawTag((byte) 17);
        output.WriteDouble(this.Ask);
      }
      if (this.Bid != 0.0)
      {
        output.WriteRawTag((byte) 25);
        output.WriteDouble(this.Bid);
      }
      if (this.Symbol.Length != 0)
      {
        output.WriteRawTag((byte) 34);
        output.WriteString(this.Symbol);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.Id != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
      if (this.Ask != 0.0)
        num += 9;
      if (this.Bid != 0.0)
        num += 9;
      if (this.Symbol.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Symbol);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(BridgeMarginCheckNotificationProto other)
    {
      if (other == null)
        return;
      if (other.Id != 0L)
        this.Id = other.Id;
      if (other.Ask != 0.0)
        this.Ask = other.Ask;
      if (other.Bid != 0.0)
        this.Bid = other.Bid;
      if (other.Symbol.Length != 0)
        this.Symbol = other.Symbol;
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
            this.Id = input.ReadInt64();
            continue;
          case 17:
            this.Ask = input.ReadDouble();
            continue;
          case 25:
            this.Bid = input.ReadDouble();
            continue;
          case 34:
            this.Symbol = input.ReadString();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
