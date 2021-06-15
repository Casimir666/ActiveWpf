// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.LastPricesProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class LastPricesProto : 
    IMessage<LastPricesProto>,
    IMessage,
    IEquatable<LastPricesProto>,
    IDeepCloneable<LastPricesProto>
  {
    private static readonly MessageParser<LastPricesProto> _parser = new MessageParser<LastPricesProto>((Func<LastPricesProto>) (() => new LastPricesProto()));
    private UnknownFieldSet _unknownFields;
    public const int SymbolFieldNumber = 1;
    private string symbol_ = "";
    public const int AskFieldNumber = 2;
    private int ask_;
    public const int BidFieldNumber = 3;
    private int bid_;
    public const int DirectionFieldNumber = 4;
    private int direction_;
    public const int TimestampFieldNumber = 5;
    private long timestamp_;

    [DebuggerNonUserCode]
    public static MessageParser<LastPricesProto> Parser => LastPricesProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[31];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => LastPricesProto.Descriptor;

    [DebuggerNonUserCode]
    public LastPricesProto()
    {
    }

    [DebuggerNonUserCode]
    public LastPricesProto(LastPricesProto other)
      : this()
    {
      this.symbol_ = other.symbol_;
      this.ask_ = other.ask_;
      this.bid_ = other.bid_;
      this.direction_ = other.direction_;
      this.timestamp_ = other.timestamp_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public LastPricesProto Clone() => new LastPricesProto(this);

    [DebuggerNonUserCode]
    public string Symbol
    {
      get => this.symbol_;
      set => this.symbol_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public int Ask
    {
      get => this.ask_;
      set => this.ask_ = value;
    }

    [DebuggerNonUserCode]
    public int Bid
    {
      get => this.bid_;
      set => this.bid_ = value;
    }

    [DebuggerNonUserCode]
    public int Direction
    {
      get => this.direction_;
      set => this.direction_ = value;
    }

    [DebuggerNonUserCode]
    public long Timestamp
    {
      get => this.timestamp_;
      set => this.timestamp_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as LastPricesProto);

    [DebuggerNonUserCode]
    public bool Equals(LastPricesProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return !(this.Symbol != other.Symbol) && this.Ask == other.Ask && (this.Bid == other.Bid && this.Direction == other.Direction) && this.Timestamp == other.Timestamp && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.Symbol.Length != 0)
        num ^= this.Symbol.GetHashCode();
      if (this.Ask != 0)
        num ^= this.Ask.GetHashCode();
      if (this.Bid != 0)
        num ^= this.Bid.GetHashCode();
      if (this.Direction != 0)
        num ^= this.Direction.GetHashCode();
      if (this.Timestamp != 0L)
        num ^= this.Timestamp.GetHashCode();
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
      if (this.Ask != 0)
      {
        output.WriteRawTag((byte) 16);
        output.WriteInt32(this.Ask);
      }
      if (this.Bid != 0)
      {
        output.WriteRawTag((byte) 24);
        output.WriteInt32(this.Bid);
      }
      if (this.Direction != 0)
      {
        output.WriteRawTag((byte) 32);
        output.WriteInt32(this.Direction);
      }
      if (this.Timestamp != 0L)
      {
        output.WriteRawTag((byte) 40);
        output.WriteInt64(this.Timestamp);
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
      if (this.Ask != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.Ask);
      if (this.Bid != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.Bid);
      if (this.Direction != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.Direction);
      if (this.Timestamp != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.Timestamp);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(LastPricesProto other)
    {
      if (other == null)
        return;
      if (other.Symbol.Length != 0)
        this.Symbol = other.Symbol;
      if (other.Ask != 0)
        this.Ask = other.Ask;
      if (other.Bid != 0)
        this.Bid = other.Bid;
      if (other.Direction != 0)
        this.Direction = other.Direction;
      if (other.Timestamp != 0L)
        this.Timestamp = other.Timestamp;
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
            this.Ask = input.ReadInt32();
            continue;
          case 24:
            this.Bid = input.ReadInt32();
            continue;
          case 32:
            this.Direction = input.ReadInt32();
            continue;
          case 40:
            this.Timestamp = input.ReadInt64();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
