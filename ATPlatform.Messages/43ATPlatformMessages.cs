// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.HistoryQuoteForSymbolProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class HistoryQuoteForSymbolProto : 
    IMessage<HistoryQuoteForSymbolProto>,
    IMessage,
    IEquatable<HistoryQuoteForSymbolProto>,
    IDeepCloneable<HistoryQuoteForSymbolProto>
  {
    private static readonly MessageParser<HistoryQuoteForSymbolProto> _parser = new MessageParser<HistoryQuoteForSymbolProto>((Func<HistoryQuoteForSymbolProto>) (() => new HistoryQuoteForSymbolProto()));
    private UnknownFieldSet _unknownFields;
    public const int SymbolFieldNumber = 1;
    private string symbol_ = "";
    public const int QuoteFieldNumber = 2;
    private HistoryQuoteProto quote_;
    public const int TicksFieldNumber = 3;
    private TicksForBarProto ticks_;

    [DebuggerNonUserCode]
    public static MessageParser<HistoryQuoteForSymbolProto> Parser => HistoryQuoteForSymbolProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[25];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => HistoryQuoteForSymbolProto.Descriptor;

    [DebuggerNonUserCode]
    public HistoryQuoteForSymbolProto()
    {
    }

    [DebuggerNonUserCode]
    public HistoryQuoteForSymbolProto(HistoryQuoteForSymbolProto other)
      : this()
    {
      this.symbol_ = other.symbol_;
      this.quote_ = other.quote_ != null ? other.quote_.Clone() : (HistoryQuoteProto) null;
      this.ticks_ = other.ticks_ != null ? other.ticks_.Clone() : (TicksForBarProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public HistoryQuoteForSymbolProto Clone() => new HistoryQuoteForSymbolProto(this);

    [DebuggerNonUserCode]
    public string Symbol
    {
      get => this.symbol_;
      set => this.symbol_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public HistoryQuoteProto Quote
    {
      get => this.quote_;
      set => this.quote_ = value;
    }

    [DebuggerNonUserCode]
    public TicksForBarProto Ticks
    {
      get => this.ticks_;
      set => this.ticks_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as HistoryQuoteForSymbolProto);

    [DebuggerNonUserCode]
    public bool Equals(HistoryQuoteForSymbolProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return !(this.Symbol != other.Symbol) && object.Equals((object) this.Quote, (object) other.Quote) && object.Equals((object) this.Ticks, (object) other.Ticks) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.Symbol.Length != 0)
        num ^= this.Symbol.GetHashCode();
      if (this.quote_ != null)
        num ^= this.Quote.GetHashCode();
      if (this.ticks_ != null)
        num ^= this.Ticks.GetHashCode();
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
      if (this.quote_ != null)
      {
        output.WriteRawTag((byte) 18);
        output.WriteMessage((IMessage) this.Quote);
      }
      if (this.ticks_ != null)
      {
        output.WriteRawTag((byte) 26);
        output.WriteMessage((IMessage) this.Ticks);
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
      if (this.quote_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.Quote);
      if (this.ticks_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.Ticks);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(HistoryQuoteForSymbolProto other)
    {
      if (other == null)
        return;
      if (other.Symbol.Length != 0)
        this.Symbol = other.Symbol;
      if (other.quote_ != null)
      {
        if (this.quote_ == null)
          this.Quote = new HistoryQuoteProto();
        this.Quote.MergeFrom(other.Quote);
      }
      if (other.ticks_ != null)
      {
        if (this.ticks_ == null)
          this.Ticks = new TicksForBarProto();
        this.Ticks.MergeFrom(other.Ticks);
      }
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
            if (this.quote_ == null)
              this.Quote = new HistoryQuoteProto();
            input.ReadMessage((IMessage) this.Quote);
            continue;
          case 26:
            if (this.ticks_ == null)
              this.Ticks = new TicksForBarProto();
            input.ReadMessage((IMessage) this.Ticks);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
