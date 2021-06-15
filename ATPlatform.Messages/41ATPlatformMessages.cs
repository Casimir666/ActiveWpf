// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetHistoryQuotesNotificationProto
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
  public sealed class GetHistoryQuotesNotificationProto : 
    IMessage<GetHistoryQuotesNotificationProto>,
    IMessage,
    IEquatable<GetHistoryQuotesNotificationProto>,
    IDeepCloneable<GetHistoryQuotesNotificationProto>
  {
    private static readonly MessageParser<GetHistoryQuotesNotificationProto> _parser = new MessageParser<GetHistoryQuotesNotificationProto>((Func<GetHistoryQuotesNotificationProto>) (() => new GetHistoryQuotesNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int CountOfTheLastBarsFieldNumber = 1;
    private int countOfTheLastBars_;
    public const int PeriodFieldNumber = 2;
    private HistoryQuotesPeriodProto period_;
    public const int QuotesFieldNumber = 3;
    private static readonly FieldCodec<HistoryQuotesForSymbolProto> _repeated_quotes_codec = FieldCodec.ForMessage<HistoryQuotesForSymbolProto>(26U, HistoryQuotesForSymbolProto.Parser);
    private readonly RepeatedField<HistoryQuotesForSymbolProto> quotes_ = new RepeatedField<HistoryQuotesForSymbolProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetHistoryQuotesNotificationProto> Parser => GetHistoryQuotesNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[23];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetHistoryQuotesNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetHistoryQuotesNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetHistoryQuotesNotificationProto(GetHistoryQuotesNotificationProto other)
      : this()
    {
      this.countOfTheLastBars_ = other.countOfTheLastBars_;
      this.period_ = other.period_;
      this.quotes_ = other.quotes_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetHistoryQuotesNotificationProto Clone() => new GetHistoryQuotesNotificationProto(this);

    [DebuggerNonUserCode]
    public int CountOfTheLastBars
    {
      get => this.countOfTheLastBars_;
      set => this.countOfTheLastBars_ = value;
    }

    [DebuggerNonUserCode]
    public HistoryQuotesPeriodProto Period
    {
      get => this.period_;
      set => this.period_ = value;
    }

    [DebuggerNonUserCode]
    public RepeatedField<HistoryQuotesForSymbolProto> Quotes => this.quotes_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetHistoryQuotesNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetHistoryQuotesNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.CountOfTheLastBars == other.CountOfTheLastBars && this.Period == other.Period && this.quotes_.Equals(other.quotes_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      if (this.CountOfTheLastBars != 0)
        num1 ^= this.CountOfTheLastBars.GetHashCode();
      if (this.Period != HistoryQuotesPeriodProto.UnknownHistoryQuotesPeriod)
        num1 ^= this.Period.GetHashCode();
      int num2 = num1 ^ this.quotes_.GetHashCode();
      if (this._unknownFields != null)
        num2 ^= this._unknownFields.GetHashCode();
      return num2;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.CountOfTheLastBars != 0)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt32(this.CountOfTheLastBars);
      }
      if (this.Period != HistoryQuotesPeriodProto.UnknownHistoryQuotesPeriod)
      {
        output.WriteRawTag((byte) 16);
        output.WriteEnum((int) this.Period);
      }
      this.quotes_.WriteTo(output, GetHistoryQuotesNotificationProto._repeated_quotes_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num1 = 0;
      if (this.CountOfTheLastBars != 0)
        num1 += 1 + CodedOutputStream.ComputeInt32Size(this.CountOfTheLastBars);
      if (this.Period != HistoryQuotesPeriodProto.UnknownHistoryQuotesPeriod)
        num1 += 1 + CodedOutputStream.ComputeEnumSize((int) this.Period);
      int num2 = num1 + this.quotes_.CalculateSize(GetHistoryQuotesNotificationProto._repeated_quotes_codec);
      if (this._unknownFields != null)
        num2 += this._unknownFields.CalculateSize();
      return num2;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetHistoryQuotesNotificationProto other)
    {
      if (other == null)
        return;
      if (other.CountOfTheLastBars != 0)
        this.CountOfTheLastBars = other.CountOfTheLastBars;
      if (other.Period != HistoryQuotesPeriodProto.UnknownHistoryQuotesPeriod)
        this.Period = other.Period;
      this.quotes_.Add((IEnumerable<HistoryQuotesForSymbolProto>) other.quotes_);
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
            this.CountOfTheLastBars = input.ReadInt32();
            continue;
          case 16:
            this.Period = (HistoryQuotesPeriodProto) input.ReadEnum();
            continue;
          case 26:
            this.quotes_.AddEntriesFrom(input, GetHistoryQuotesNotificationProto._repeated_quotes_codec);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
