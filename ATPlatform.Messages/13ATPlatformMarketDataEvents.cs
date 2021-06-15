// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.MarketDataEvents.GetMarketDataEventHistoryNotificationProto
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
  public sealed class GetMarketDataEventHistoryNotificationProto : 
    IMessage<GetMarketDataEventHistoryNotificationProto>,
    IMessage,
    IEquatable<GetMarketDataEventHistoryNotificationProto>,
    IDeepCloneable<GetMarketDataEventHistoryNotificationProto>
  {
    private static readonly MessageParser<GetMarketDataEventHistoryNotificationProto> _parser = new MessageParser<GetMarketDataEventHistoryNotificationProto>((Func<GetMarketDataEventHistoryNotificationProto>) (() => new GetMarketDataEventHistoryNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int HistoryFieldNumber = 1;
    private static readonly FieldCodec<MarketDataEventHistoryProto> _repeated_history_codec = FieldCodec.ForMessage<MarketDataEventHistoryProto>(10U, MarketDataEventHistoryProto.Parser);
    private readonly RepeatedField<MarketDataEventHistoryProto> history_ = new RepeatedField<MarketDataEventHistoryProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetMarketDataEventHistoryNotificationProto> Parser => GetMarketDataEventHistoryNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMarketDataEventsReflection.Descriptor.MessageTypes[12];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetMarketDataEventHistoryNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetMarketDataEventHistoryNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetMarketDataEventHistoryNotificationProto(
      GetMarketDataEventHistoryNotificationProto other)
      : this()
    {
      this.history_ = other.history_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetMarketDataEventHistoryNotificationProto Clone() => new GetMarketDataEventHistoryNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<MarketDataEventHistoryProto> History => this.history_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetMarketDataEventHistoryNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetMarketDataEventHistoryNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.history_.Equals(other.history_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.history_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.history_.WriteTo(output, GetMarketDataEventHistoryNotificationProto._repeated_history_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.history_.CalculateSize(GetMarketDataEventHistoryNotificationProto._repeated_history_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetMarketDataEventHistoryNotificationProto other)
    {
      if (other == null)
        return;
      this.history_.Add((IEnumerable<MarketDataEventHistoryProto>) other.history_);
      this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
    }

    [DebuggerNonUserCode]
    public void MergeFrom(CodedInputStream input)
    {
      uint num;
      while ((num = input.ReadTag()) != 0U)
      {
        if (num != 10U)
          this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
        else
          this.history_.AddEntriesFrom(input, GetMarketDataEventHistoryNotificationProto._repeated_history_codec);
      }
    }
  }
}
