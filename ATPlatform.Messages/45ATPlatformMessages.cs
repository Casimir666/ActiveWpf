// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.HistoryQuotesForSymbolProto
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
  public sealed class HistoryQuotesForSymbolProto : 
    IMessage<HistoryQuotesForSymbolProto>,
    IMessage,
    IEquatable<HistoryQuotesForSymbolProto>,
    IDeepCloneable<HistoryQuotesForSymbolProto>
  {
    private static readonly MessageParser<HistoryQuotesForSymbolProto> _parser = new MessageParser<HistoryQuotesForSymbolProto>((Func<HistoryQuotesForSymbolProto>) (() => new HistoryQuotesForSymbolProto()));
    private UnknownFieldSet _unknownFields;
    public const int SymbolFieldNumber = 1;
    private string symbol_ = "";
    public const int QuotesFieldNumber = 2;
    private static readonly FieldCodec<HistoryQuoteProto> _repeated_quotes_codec = FieldCodec.ForMessage<HistoryQuoteProto>(18U, HistoryQuoteProto.Parser);
    private readonly RepeatedField<HistoryQuoteProto> quotes_ = new RepeatedField<HistoryQuoteProto>();

    [DebuggerNonUserCode]
    public static MessageParser<HistoryQuotesForSymbolProto> Parser => HistoryQuotesForSymbolProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[27];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => HistoryQuotesForSymbolProto.Descriptor;

    [DebuggerNonUserCode]
    public HistoryQuotesForSymbolProto()
    {
    }

    [DebuggerNonUserCode]
    public HistoryQuotesForSymbolProto(HistoryQuotesForSymbolProto other)
      : this()
    {
      this.symbol_ = other.symbol_;
      this.quotes_ = other.quotes_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public HistoryQuotesForSymbolProto Clone() => new HistoryQuotesForSymbolProto(this);

    [DebuggerNonUserCode]
    public string Symbol
    {
      get => this.symbol_;
      set => this.symbol_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public RepeatedField<HistoryQuoteProto> Quotes => this.quotes_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as HistoryQuotesForSymbolProto);

    [DebuggerNonUserCode]
    public bool Equals(HistoryQuotesForSymbolProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return !(this.Symbol != other.Symbol) && this.quotes_.Equals(other.quotes_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      if (this.Symbol.Length != 0)
        num1 ^= this.Symbol.GetHashCode();
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
      if (this.Symbol.Length != 0)
      {
        output.WriteRawTag((byte) 10);
        output.WriteString(this.Symbol);
      }
      this.quotes_.WriteTo(output, HistoryQuotesForSymbolProto._repeated_quotes_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num1 = 0;
      if (this.Symbol.Length != 0)
        num1 += 1 + CodedOutputStream.ComputeStringSize(this.Symbol);
      int num2 = num1 + this.quotes_.CalculateSize(HistoryQuotesForSymbolProto._repeated_quotes_codec);
      if (this._unknownFields != null)
        num2 += this._unknownFields.CalculateSize();
      return num2;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(HistoryQuotesForSymbolProto other)
    {
      if (other == null)
        return;
      if (other.Symbol.Length != 0)
        this.Symbol = other.Symbol;
      this.quotes_.Add((IEnumerable<HistoryQuoteProto>) other.quotes_);
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
          case 18:
            this.quotes_.AddEntriesFrom(input, HistoryQuotesForSymbolProto._repeated_quotes_codec);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
