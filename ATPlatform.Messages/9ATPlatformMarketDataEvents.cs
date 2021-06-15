// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.MarketDataEvents.GetMarketDataEventsFilterProto
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
  public sealed class GetMarketDataEventsFilterProto : 
    IMessage<GetMarketDataEventsFilterProto>,
    IMessage,
    IEquatable<GetMarketDataEventsFilterProto>,
    IDeepCloneable<GetMarketDataEventsFilterProto>
  {
    private static readonly MessageParser<GetMarketDataEventsFilterProto> _parser = new MessageParser<GetMarketDataEventsFilterProto>((Func<GetMarketDataEventsFilterProto>) (() => new GetMarketDataEventsFilterProto()));
    private UnknownFieldSet _unknownFields;
    public const int PreferredLanguageFieldNumber = 1;
    private string preferredLanguage_ = "";
    public const int FromDateFieldNumber = 2;
    private long fromDate_;
    public const int ToDateFieldNumber = 3;
    private long toDate_;
    public const int Types_FieldNumber = 4;
    private static readonly FieldCodec<MarketDataEventTypeProto> _repeated_types_codec = FieldCodec.ForEnum<MarketDataEventTypeProto>(34U, (Func<MarketDataEventTypeProto, int>) (x => (int) x), (Func<int, MarketDataEventTypeProto>) (x => (MarketDataEventTypeProto) x));
    private readonly RepeatedField<MarketDataEventTypeProto> types_ = new RepeatedField<MarketDataEventTypeProto>();
    public const int StatesFieldNumber = 5;
    private static readonly FieldCodec<MarketDataEventStateProto> _repeated_states_codec = FieldCodec.ForEnum<MarketDataEventStateProto>(42U, (Func<MarketDataEventStateProto, int>) (x => (int) x), (Func<int, MarketDataEventStateProto>) (x => (MarketDataEventStateProto) x));
    private readonly RepeatedField<MarketDataEventStateProto> states_ = new RepeatedField<MarketDataEventStateProto>();
    public const int TextFieldNumber = 6;
    private string text_ = "";
    public const int InitiatorsFieldNumber = 7;
    private static readonly FieldCodec<string> _repeated_initiators_codec = FieldCodec.ForString(58U);
    private readonly RepeatedField<string> initiators_ = new RepeatedField<string>();

    [DebuggerNonUserCode]
    public static MessageParser<GetMarketDataEventsFilterProto> Parser => GetMarketDataEventsFilterProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMarketDataEventsReflection.Descriptor.MessageTypes[8];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetMarketDataEventsFilterProto.Descriptor;

    [DebuggerNonUserCode]
    public GetMarketDataEventsFilterProto()
    {
    }

    [DebuggerNonUserCode]
    public GetMarketDataEventsFilterProto(GetMarketDataEventsFilterProto other)
      : this()
    {
      this.preferredLanguage_ = other.preferredLanguage_;
      this.fromDate_ = other.fromDate_;
      this.toDate_ = other.toDate_;
      this.types_ = other.types_.Clone();
      this.states_ = other.states_.Clone();
      this.text_ = other.text_;
      this.initiators_ = other.initiators_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetMarketDataEventsFilterProto Clone() => new GetMarketDataEventsFilterProto(this);

    [DebuggerNonUserCode]
    public string PreferredLanguage
    {
      get => this.preferredLanguage_;
      set => this.preferredLanguage_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public long FromDate
    {
      get => this.fromDate_;
      set => this.fromDate_ = value;
    }

    [DebuggerNonUserCode]
    public long ToDate
    {
      get => this.toDate_;
      set => this.toDate_ = value;
    }

    [DebuggerNonUserCode]
    public RepeatedField<MarketDataEventTypeProto> Types_ => this.types_;

    [DebuggerNonUserCode]
    public RepeatedField<MarketDataEventStateProto> States => this.states_;

    [DebuggerNonUserCode]
    public string Text
    {
      get => this.text_;
      set => this.text_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public RepeatedField<string> Initiators => this.initiators_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetMarketDataEventsFilterProto);

    [DebuggerNonUserCode]
    public bool Equals(GetMarketDataEventsFilterProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return !(this.PreferredLanguage != other.PreferredLanguage) && this.FromDate == other.FromDate && (this.ToDate == other.ToDate && this.types_.Equals(other.types_)) && (this.states_.Equals(other.states_) && !(this.Text != other.Text) && this.initiators_.Equals(other.initiators_)) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      if (this.PreferredLanguage.Length != 0)
        num1 ^= this.PreferredLanguage.GetHashCode();
      if (this.FromDate != 0L)
        num1 ^= this.FromDate.GetHashCode();
      if (this.ToDate != 0L)
        num1 ^= this.ToDate.GetHashCode();
      int num2 = num1 ^ this.types_.GetHashCode() ^ this.states_.GetHashCode();
      if (this.Text.Length != 0)
        num2 ^= this.Text.GetHashCode();
      int num3 = num2 ^ this.initiators_.GetHashCode();
      if (this._unknownFields != null)
        num3 ^= this._unknownFields.GetHashCode();
      return num3;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.PreferredLanguage.Length != 0)
      {
        output.WriteRawTag((byte) 10);
        output.WriteString(this.PreferredLanguage);
      }
      if (this.FromDate != 0L)
      {
        output.WriteRawTag((byte) 16);
        output.WriteInt64(this.FromDate);
      }
      if (this.ToDate != 0L)
      {
        output.WriteRawTag((byte) 24);
        output.WriteInt64(this.ToDate);
      }
      this.types_.WriteTo(output, GetMarketDataEventsFilterProto._repeated_types_codec);
      this.states_.WriteTo(output, GetMarketDataEventsFilterProto._repeated_states_codec);
      if (this.Text.Length != 0)
      {
        output.WriteRawTag((byte) 50);
        output.WriteString(this.Text);
      }
      this.initiators_.WriteTo(output, GetMarketDataEventsFilterProto._repeated_initiators_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num1 = 0;
      if (this.PreferredLanguage.Length != 0)
        num1 += 1 + CodedOutputStream.ComputeStringSize(this.PreferredLanguage);
      if (this.FromDate != 0L)
        num1 += 1 + CodedOutputStream.ComputeInt64Size(this.FromDate);
      if (this.ToDate != 0L)
        num1 += 1 + CodedOutputStream.ComputeInt64Size(this.ToDate);
      int num2 = num1 + this.types_.CalculateSize(GetMarketDataEventsFilterProto._repeated_types_codec) + this.states_.CalculateSize(GetMarketDataEventsFilterProto._repeated_states_codec);
      if (this.Text.Length != 0)
        num2 += 1 + CodedOutputStream.ComputeStringSize(this.Text);
      int num3 = num2 + this.initiators_.CalculateSize(GetMarketDataEventsFilterProto._repeated_initiators_codec);
      if (this._unknownFields != null)
        num3 += this._unknownFields.CalculateSize();
      return num3;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetMarketDataEventsFilterProto other)
    {
      if (other == null)
        return;
      if (other.PreferredLanguage.Length != 0)
        this.PreferredLanguage = other.PreferredLanguage;
      if (other.FromDate != 0L)
        this.FromDate = other.FromDate;
      if (other.ToDate != 0L)
        this.ToDate = other.ToDate;
      this.types_.Add((IEnumerable<MarketDataEventTypeProto>) other.types_);
      this.states_.Add((IEnumerable<MarketDataEventStateProto>) other.states_);
      if (other.Text.Length != 0)
        this.Text = other.Text;
      this.initiators_.Add((IEnumerable<string>) other.initiators_);
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
            this.PreferredLanguage = input.ReadString();
            continue;
          case 16:
            this.FromDate = input.ReadInt64();
            continue;
          case 24:
            this.ToDate = input.ReadInt64();
            continue;
          case 32:
          case 34:
            this.types_.AddEntriesFrom(input, GetMarketDataEventsFilterProto._repeated_types_codec);
            continue;
          case 40:
          case 42:
            this.states_.AddEntriesFrom(input, GetMarketDataEventsFilterProto._repeated_states_codec);
            continue;
          case 50:
            this.Text = input.ReadString();
            continue;
          case 58:
            this.initiators_.AddEntriesFrom(input, GetMarketDataEventsFilterProto._repeated_initiators_codec);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
