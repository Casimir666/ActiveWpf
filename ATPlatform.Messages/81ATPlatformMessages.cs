// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetTradeSettingsSetsNotificationProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class GetTradeSettingsSetsNotificationProto : 
    IMessage<GetTradeSettingsSetsNotificationProto>,
    IMessage,
    IEquatable<GetTradeSettingsSetsNotificationProto>,
    IDeepCloneable<GetTradeSettingsSetsNotificationProto>
  {
    private static readonly MessageParser<GetTradeSettingsSetsNotificationProto> _parser = new MessageParser<GetTradeSettingsSetsNotificationProto>((Func<GetTradeSettingsSetsNotificationProto>) (() => new GetTradeSettingsSetsNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int TradeSettingsSetsFieldNumber = 1;
    private static readonly FieldCodec<TradeSettingsSetProto> _repeated_tradeSettingsSets_codec = FieldCodec.ForMessage<TradeSettingsSetProto>(10U, TradeSettingsSetProto.Parser);
    private readonly RepeatedField<TradeSettingsSetProto> tradeSettingsSets_ = new RepeatedField<TradeSettingsSetProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetTradeSettingsSetsNotificationProto> Parser => GetTradeSettingsSetsNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[69];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetTradeSettingsSetsNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetTradeSettingsSetsNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetTradeSettingsSetsNotificationProto(GetTradeSettingsSetsNotificationProto other)
      : this()
    {
      this.tradeSettingsSets_ = other.tradeSettingsSets_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetTradeSettingsSetsNotificationProto Clone() => new GetTradeSettingsSetsNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<TradeSettingsSetProto> TradeSettingsSets => this.tradeSettingsSets_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetTradeSettingsSetsNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetTradeSettingsSetsNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.tradeSettingsSets_.Equals(other.tradeSettingsSets_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.tradeSettingsSets_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.tradeSettingsSets_.WriteTo(output, GetTradeSettingsSetsNotificationProto._repeated_tradeSettingsSets_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.tradeSettingsSets_.CalculateSize(GetTradeSettingsSetsNotificationProto._repeated_tradeSettingsSets_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetTradeSettingsSetsNotificationProto other)
    {
      if (other == null)
        return;
      this.tradeSettingsSets_.Add((IEnumerable<TradeSettingsSetProto>) other.tradeSettingsSets_);
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
          this.tradeSettingsSets_.AddEntriesFrom(input, GetTradeSettingsSetsNotificationProto._repeated_tradeSettingsSets_codec);
      }
    }
  }
}
