// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.MarketDataEvents.MarketDataEventNotificationProto
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
  public sealed class MarketDataEventNotificationProto : 
    IMessage<MarketDataEventNotificationProto>,
    IMessage,
    IEquatable<MarketDataEventNotificationProto>,
    IDeepCloneable<MarketDataEventNotificationProto>
  {
    private static readonly MessageParser<MarketDataEventNotificationProto> _parser = new MessageParser<MarketDataEventNotificationProto>((Func<MarketDataEventNotificationProto>) (() => new MarketDataEventNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int MarketDataEventFieldNumber = 1;
    private MarketDataEventProto marketDataEvent_;
    public const int SettingsFieldNumber = 2;
    private static readonly MapField<string, MarketDataEventSettingsProto>.Codec _map_settings_codec = new MapField<string, MarketDataEventSettingsProto>.Codec(FieldCodec.ForString(10U), FieldCodec.ForMessage<MarketDataEventSettingsProto>(18U, MarketDataEventSettingsProto.Parser), 18U);
    private readonly MapField<string, MarketDataEventSettingsProto> settings_ = new MapField<string, MarketDataEventSettingsProto>();
    public const int TranslationsFieldNumber = 3;
    private static readonly MapField<string, MarketDataEventTranslationProto>.Codec _map_translations_codec = new MapField<string, MarketDataEventTranslationProto>.Codec(FieldCodec.ForString(10U), FieldCodec.ForMessage<MarketDataEventTranslationProto>(18U, MarketDataEventTranslationProto.Parser), 26U);
    private readonly MapField<string, MarketDataEventTranslationProto> translations_ = new MapField<string, MarketDataEventTranslationProto>();
    public const int TagsFieldNumber = 4;
    private static readonly FieldCodec<MarketDataEventTagProto> _repeated_tags_codec = FieldCodec.ForMessage<MarketDataEventTagProto>(34U, MarketDataEventTagProto.Parser);
    private readonly RepeatedField<MarketDataEventTagProto> tags_ = new RepeatedField<MarketDataEventTagProto>();
    public const int SnapshotDataFieldNumber = 5;
    private static readonly MapField<string, string>.Codec _map_snapshotData_codec = new MapField<string, string>.Codec(FieldCodec.ForString(10U), FieldCodec.ForString(18U), 42U);
    private readonly MapField<string, string> snapshotData_ = new MapField<string, string>();

    [DebuggerNonUserCode]
    public static MessageParser<MarketDataEventNotificationProto> Parser => MarketDataEventNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMarketDataEventsReflection.Descriptor.MessageTypes[6];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => MarketDataEventNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public MarketDataEventNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public MarketDataEventNotificationProto(MarketDataEventNotificationProto other)
      : this()
    {
      this.marketDataEvent_ = other.marketDataEvent_ != null ? other.marketDataEvent_.Clone() : (MarketDataEventProto) null;
      this.settings_ = other.settings_.Clone();
      this.translations_ = other.translations_.Clone();
      this.tags_ = other.tags_.Clone();
      this.snapshotData_ = other.snapshotData_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public MarketDataEventNotificationProto Clone() => new MarketDataEventNotificationProto(this);

    [DebuggerNonUserCode]
    public MarketDataEventProto MarketDataEvent
    {
      get => this.marketDataEvent_;
      set => this.marketDataEvent_ = value;
    }

    [DebuggerNonUserCode]
    public MapField<string, MarketDataEventSettingsProto> Settings => this.settings_;

    [DebuggerNonUserCode]
    public MapField<string, MarketDataEventTranslationProto> Translations => this.translations_;

    [DebuggerNonUserCode]
    public RepeatedField<MarketDataEventTagProto> Tags => this.tags_;

    [DebuggerNonUserCode]
    public MapField<string, string> SnapshotData => this.snapshotData_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as MarketDataEventNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(MarketDataEventNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return object.Equals((object) this.MarketDataEvent, (object) other.MarketDataEvent) && this.Settings.Equals(other.Settings) && (this.Translations.Equals(other.Translations) && this.tags_.Equals(other.tags_)) && this.SnapshotData.Equals(other.SnapshotData) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      if (this.marketDataEvent_ != null)
        num1 ^= this.MarketDataEvent.GetHashCode();
      int num2 = num1 ^ this.Settings.GetHashCode() ^ this.Translations.GetHashCode() ^ this.tags_.GetHashCode() ^ this.SnapshotData.GetHashCode();
      if (this._unknownFields != null)
        num2 ^= this._unknownFields.GetHashCode();
      return num2;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.marketDataEvent_ != null)
      {
        output.WriteRawTag((byte) 10);
        output.WriteMessage((IMessage) this.MarketDataEvent);
      }
      this.settings_.WriteTo(output, MarketDataEventNotificationProto._map_settings_codec);
      this.translations_.WriteTo(output, MarketDataEventNotificationProto._map_translations_codec);
      this.tags_.WriteTo(output, MarketDataEventNotificationProto._repeated_tags_codec);
      this.snapshotData_.WriteTo(output, MarketDataEventNotificationProto._map_snapshotData_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num1 = 0;
      if (this.marketDataEvent_ != null)
        num1 += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.MarketDataEvent);
      int num2 = num1 + this.settings_.CalculateSize(MarketDataEventNotificationProto._map_settings_codec) + this.translations_.CalculateSize(MarketDataEventNotificationProto._map_translations_codec) + this.tags_.CalculateSize(MarketDataEventNotificationProto._repeated_tags_codec) + this.snapshotData_.CalculateSize(MarketDataEventNotificationProto._map_snapshotData_codec);
      if (this._unknownFields != null)
        num2 += this._unknownFields.CalculateSize();
      return num2;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(MarketDataEventNotificationProto other)
    {
      if (other == null)
        return;
      if (other.marketDataEvent_ != null)
      {
        if (this.marketDataEvent_ == null)
          this.MarketDataEvent = new MarketDataEventProto();
        this.MarketDataEvent.MergeFrom(other.MarketDataEvent);
      }
      this.settings_.Add((IDictionary<string, MarketDataEventSettingsProto>) other.settings_);
      this.translations_.Add((IDictionary<string, MarketDataEventTranslationProto>) other.translations_);
      this.tags_.Add((IEnumerable<MarketDataEventTagProto>) other.tags_);
      this.snapshotData_.Add((IDictionary<string, string>) other.snapshotData_);
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
            if (this.marketDataEvent_ == null)
              this.MarketDataEvent = new MarketDataEventProto();
            input.ReadMessage((IMessage) this.MarketDataEvent);
            continue;
          case 18:
            this.settings_.AddEntriesFrom(input, MarketDataEventNotificationProto._map_settings_codec);
            continue;
          case 26:
            this.translations_.AddEntriesFrom(input, MarketDataEventNotificationProto._map_translations_codec);
            continue;
          case 34:
            this.tags_.AddEntriesFrom(input, MarketDataEventNotificationProto._repeated_tags_codec);
            continue;
          case 42:
            this.snapshotData_.AddEntriesFrom(input, MarketDataEventNotificationProto._map_snapshotData_codec);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
