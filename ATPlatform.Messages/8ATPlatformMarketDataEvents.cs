// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.MarketDataEvents.GetMarketDataEventRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL.MarketDataEvents
{
  public sealed class GetMarketDataEventRequestProto : 
    IMessage<GetMarketDataEventRequestProto>,
    IMessage,
    IEquatable<GetMarketDataEventRequestProto>,
    IDeepCloneable<GetMarketDataEventRequestProto>
  {
    private static readonly MessageParser<GetMarketDataEventRequestProto> _parser = new MessageParser<GetMarketDataEventRequestProto>((Func<GetMarketDataEventRequestProto>) (() => new GetMarketDataEventRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int MarketDataEventIdFieldNumber = 1;
    private int marketDataEventId_;

    [DebuggerNonUserCode]
    public static MessageParser<GetMarketDataEventRequestProto> Parser => GetMarketDataEventRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMarketDataEventsReflection.Descriptor.MessageTypes[7];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetMarketDataEventRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public GetMarketDataEventRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public GetMarketDataEventRequestProto(GetMarketDataEventRequestProto other)
      : this()
    {
      this.marketDataEventId_ = other.marketDataEventId_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetMarketDataEventRequestProto Clone() => new GetMarketDataEventRequestProto(this);

    [DebuggerNonUserCode]
    public int MarketDataEventId
    {
      get => this.marketDataEventId_;
      set => this.marketDataEventId_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetMarketDataEventRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(GetMarketDataEventRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.MarketDataEventId == other.MarketDataEventId && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.MarketDataEventId != 0)
        num ^= this.MarketDataEventId.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.MarketDataEventId != 0)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt32(this.MarketDataEventId);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.MarketDataEventId != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.MarketDataEventId);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetMarketDataEventRequestProto other)
    {
      if (other == null)
        return;
      if (other.MarketDataEventId != 0)
        this.MarketDataEventId = other.MarketDataEventId;
      this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
    }

    [DebuggerNonUserCode]
    public void MergeFrom(CodedInputStream input)
    {
      uint num;
      while ((num = input.ReadTag()) != 0U)
      {
        if (num != 8U)
          this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
        else
          this.MarketDataEventId = input.ReadInt32();
      }
    }
  }
}
