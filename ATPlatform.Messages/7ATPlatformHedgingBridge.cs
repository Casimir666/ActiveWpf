// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.HedgingBridge.Level2MarginCheckRequest
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
  public sealed class Level2MarginCheckRequest : 
    IMessage<Level2MarginCheckRequest>,
    IMessage,
    IEquatable<Level2MarginCheckRequest>,
    IDeepCloneable<Level2MarginCheckRequest>
  {
    private static readonly MessageParser<Level2MarginCheckRequest> _parser = new MessageParser<Level2MarginCheckRequest>((Func<Level2MarginCheckRequest>) (() => new Level2MarginCheckRequest()));
    private UnknownFieldSet _unknownFields;
    public const int SymbolFieldNumber = 1;
    private string symbol_ = "";
    public const int VolumeFieldNumber = 2;
    private int volume_;
    public const int AskFieldNumber = 3;
    private double ask_;
    public const int BidFieldNumber = 4;
    private double bid_;
    public const int RequestIdFieldNumber = 5;
    private long requestId_;

    [DebuggerNonUserCode]
    public static MessageParser<Level2MarginCheckRequest> Parser => Level2MarginCheckRequest._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformHedgingBridgeReflection.Descriptor.MessageTypes[6];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => Level2MarginCheckRequest.Descriptor;

    [DebuggerNonUserCode]
    public Level2MarginCheckRequest()
    {
    }

    [DebuggerNonUserCode]
    public Level2MarginCheckRequest(Level2MarginCheckRequest other)
      : this()
    {
      this.symbol_ = other.symbol_;
      this.volume_ = other.volume_;
      this.ask_ = other.ask_;
      this.bid_ = other.bid_;
      this.requestId_ = other.requestId_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public Level2MarginCheckRequest Clone() => new Level2MarginCheckRequest(this);

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
    public long RequestId
    {
      get => this.requestId_;
      set => this.requestId_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as Level2MarginCheckRequest);

    [DebuggerNonUserCode]
    public bool Equals(Level2MarginCheckRequest other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return !(this.Symbol != other.Symbol) && this.Volume == other.Volume && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Ask, other.Ask) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Bid, other.Bid)) && this.RequestId == other.RequestId && object.Equals((object) this._unknownFields, (object) other._unknownFields);
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
      if (this.RequestId != 0L)
        num ^= this.RequestId.GetHashCode();
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
      if (this.RequestId != 0L)
      {
        output.WriteRawTag((byte) 40);
        output.WriteInt64(this.RequestId);
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
      if (this.RequestId != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.RequestId);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(Level2MarginCheckRequest other)
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
      if (other.RequestId != 0L)
        this.RequestId = other.RequestId;
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
            this.RequestId = input.ReadInt64();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
