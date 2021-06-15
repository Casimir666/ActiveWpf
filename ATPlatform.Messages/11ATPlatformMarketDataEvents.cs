// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.MarketDataEvents.GetMarketDataEventsNotificationProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ATPlatform.IDL.MarketDataEvents
{
  public sealed class GetMarketDataEventsNotificationProto : 
    IMessage<GetMarketDataEventsNotificationProto>,
    IMessage,
    IEquatable<GetMarketDataEventsNotificationProto>,
    IDeepCloneable<GetMarketDataEventsNotificationProto>
  {
    private static readonly MessageParser<GetMarketDataEventsNotificationProto> _parser = new MessageParser<GetMarketDataEventsNotificationProto>((Func<GetMarketDataEventsNotificationProto>) (() => new GetMarketDataEventsNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int MarketDataEventsFieldNumber = 1;
    private static readonly FieldCodec<MarketDataEventProto> _repeated_marketDataEvents_codec = FieldCodec.ForMessage<MarketDataEventProto>(10U, MarketDataEventProto.Parser);
    private readonly RepeatedField<MarketDataEventProto> marketDataEvents_ = new RepeatedField<MarketDataEventProto>();
    public const int TagsFieldNumber = 2;
    private static readonly FieldCodec<MarketDataEventTagProto> _repeated_tags_codec = FieldCodec.ForMessage<MarketDataEventTagProto>(18U, MarketDataEventTagProto.Parser);
    private readonly RepeatedField<MarketDataEventTagProto> tags_ = new RepeatedField<MarketDataEventTagProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetMarketDataEventsNotificationProto> Parser => GetMarketDataEventsNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMarketDataEventsReflection.Descriptor.MessageTypes[10];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetMarketDataEventsNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetMarketDataEventsNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetMarketDataEventsNotificationProto(GetMarketDataEventsNotificationProto other)
      : this()
    {
      this.marketDataEvents_ = other.marketDataEvents_.Clone();
      this.tags_ = other.tags_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetMarketDataEventsNotificationProto Clone() => new GetMarketDataEventsNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<MarketDataEventProto> MarketDataEvents => this.marketDataEvents_;

    [DebuggerNonUserCode]
    public RepeatedField<MarketDataEventTagProto> Tags => this.tags_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetMarketDataEventsNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetMarketDataEventsNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.marketDataEvents_.Equals(other.marketDataEvents_) && this.tags_.Equals(other.tags_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.marketDataEvents_.GetHashCode() ^ this.tags_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.marketDataEvents_.WriteTo(output, GetMarketDataEventsNotificationProto._repeated_marketDataEvents_codec);
      this.tags_.WriteTo(output, GetMarketDataEventsNotificationProto._repeated_tags_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.marketDataEvents_.CalculateSize(GetMarketDataEventsNotificationProto._repeated_marketDataEvents_codec) + this.tags_.CalculateSize(GetMarketDataEventsNotificationProto._repeated_tags_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetMarketDataEventsNotificationProto other)
    {
      if (other == null)
        return;
      this.marketDataEvents_.Add((IEnumerable<MarketDataEventProto>) other.marketDataEvents_);
      this.tags_.Add((IEnumerable<MarketDataEventTagProto>) other.tags_);
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
            this.marketDataEvents_.AddEntriesFrom(input, GetMarketDataEventsNotificationProto._repeated_marketDataEvents_codec);
            continue;
          case 18:
            this.tags_.AddEntriesFrom(input, GetMarketDataEventsNotificationProto._repeated_tags_codec);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
