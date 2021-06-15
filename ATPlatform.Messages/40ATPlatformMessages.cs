// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetHistoryQuotesRequestProto
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
  public sealed class GetHistoryQuotesRequestProto : 
    IMessage<GetHistoryQuotesRequestProto>,
    IMessage,
    IEquatable<GetHistoryQuotesRequestProto>,
    IDeepCloneable<GetHistoryQuotesRequestProto>
  {
    private static readonly MessageParser<GetHistoryQuotesRequestProto> _parser = new MessageParser<GetHistoryQuotesRequestProto>((Func<GetHistoryQuotesRequestProto>) (() => new GetHistoryQuotesRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int CountOfTheLastBarsFieldNumber = 1;
    private int countOfTheLastBars_;
    public const int SymbolsFieldNumber = 2;
    private static readonly FieldCodec<string> _repeated_symbols_codec = FieldCodec.ForString(18U);
    private readonly RepeatedField<string> symbols_ = new RepeatedField<string>();
    public const int PeriodFieldNumber = 3;
    private HistoryQuotesPeriodProto period_;

    [DebuggerNonUserCode]
    public static MessageParser<GetHistoryQuotesRequestProto> Parser => GetHistoryQuotesRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[22];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetHistoryQuotesRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public GetHistoryQuotesRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public GetHistoryQuotesRequestProto(GetHistoryQuotesRequestProto other)
      : this()
    {
      this.countOfTheLastBars_ = other.countOfTheLastBars_;
      this.symbols_ = other.symbols_.Clone();
      this.period_ = other.period_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetHistoryQuotesRequestProto Clone() => new GetHistoryQuotesRequestProto(this);

    [DebuggerNonUserCode]
    public int CountOfTheLastBars
    {
      get => this.countOfTheLastBars_;
      set => this.countOfTheLastBars_ = value;
    }

    [DebuggerNonUserCode]
    public RepeatedField<string> Symbols => this.symbols_;

    [DebuggerNonUserCode]
    public HistoryQuotesPeriodProto Period
    {
      get => this.period_;
      set => this.period_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetHistoryQuotesRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(GetHistoryQuotesRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.CountOfTheLastBars == other.CountOfTheLastBars && this.symbols_.Equals(other.symbols_) && this.Period == other.Period && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      if (this.CountOfTheLastBars != 0)
        num1 ^= this.CountOfTheLastBars.GetHashCode();
      int num2 = num1 ^ this.symbols_.GetHashCode();
      if (this.Period != HistoryQuotesPeriodProto.UnknownHistoryQuotesPeriod)
        num2 ^= this.Period.GetHashCode();
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
      this.symbols_.WriteTo(output, GetHistoryQuotesRequestProto._repeated_symbols_codec);
      if (this.Period != HistoryQuotesPeriodProto.UnknownHistoryQuotesPeriod)
      {
        output.WriteRawTag((byte) 24);
        output.WriteEnum((int) this.Period);
      }
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
      int num2 = num1 + this.symbols_.CalculateSize(GetHistoryQuotesRequestProto._repeated_symbols_codec);
      if (this.Period != HistoryQuotesPeriodProto.UnknownHistoryQuotesPeriod)
        num2 += 1 + CodedOutputStream.ComputeEnumSize((int) this.Period);
      if (this._unknownFields != null)
        num2 += this._unknownFields.CalculateSize();
      return num2;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetHistoryQuotesRequestProto other)
    {
      if (other == null)
        return;
      if (other.CountOfTheLastBars != 0)
        this.CountOfTheLastBars = other.CountOfTheLastBars;
      this.symbols_.Add((IEnumerable<string>) other.symbols_);
      if (other.Period != HistoryQuotesPeriodProto.UnknownHistoryQuotesPeriod)
        this.Period = other.Period;
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
          case 18:
            this.symbols_.AddEntriesFrom(input, GetHistoryQuotesRequestProto._repeated_symbols_codec);
            continue;
          case 24:
            this.Period = (HistoryQuotesPeriodProto) input.ReadEnum();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
