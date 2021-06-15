// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.BarsNotificationProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class BarsNotificationProto : 
    IMessage<BarsNotificationProto>,
    IMessage,
    IEquatable<BarsNotificationProto>,
    IDeepCloneable<BarsNotificationProto>
  {
    private static readonly MessageParser<BarsNotificationProto> _parser = new MessageParser<BarsNotificationProto>((Func<BarsNotificationProto>) (() => new BarsNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int BarsFieldNumber = 1;
    private HistoryQuotesForSymbolProto bars_;
    public const int DateFromFieldNumber = 2;
    private long dateFrom_;
    public const int DateToFieldNumber = 3;
    private long dateTo_;
    public const int PeriodFieldNumber = 4;
    private HistoryQuotesPeriodProto period_;

    [DebuggerNonUserCode]
    public static MessageParser<BarsNotificationProto> Parser => BarsNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[148];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => BarsNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public BarsNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public BarsNotificationProto(BarsNotificationProto other)
      : this()
    {
      this.bars_ = other.bars_ != null ? other.bars_.Clone() : (HistoryQuotesForSymbolProto) null;
      this.dateFrom_ = other.dateFrom_;
      this.dateTo_ = other.dateTo_;
      this.period_ = other.period_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public BarsNotificationProto Clone() => new BarsNotificationProto(this);

    [DebuggerNonUserCode]
    public HistoryQuotesForSymbolProto Bars
    {
      get => this.bars_;
      set => this.bars_ = value;
    }

    [DebuggerNonUserCode]
    public long DateFrom
    {
      get => this.dateFrom_;
      set => this.dateFrom_ = value;
    }

    [DebuggerNonUserCode]
    public long DateTo
    {
      get => this.dateTo_;
      set => this.dateTo_ = value;
    }

    [DebuggerNonUserCode]
    public HistoryQuotesPeriodProto Period
    {
      get => this.period_;
      set => this.period_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as BarsNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(BarsNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return object.Equals((object) this.Bars, (object) other.Bars) && this.DateFrom == other.DateFrom && (this.DateTo == other.DateTo && this.Period == other.Period) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      if (this.bars_ != null)
        num1 ^= this.Bars.GetHashCode();
      long num2;
      if (this.DateFrom != 0L)
      {
        int num3 = num1;
        num2 = this.DateFrom;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.DateTo != 0L)
      {
        int num3 = num1;
        num2 = this.DateTo;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.Period != HistoryQuotesPeriodProto.UnknownHistoryQuotesPeriod)
        num1 ^= this.Period.GetHashCode();
      if (this._unknownFields != null)
        num1 ^= this._unknownFields.GetHashCode();
      return num1;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.bars_ != null)
      {
        output.WriteRawTag((byte) 10);
        output.WriteMessage((IMessage) this.Bars);
      }
      if (this.DateFrom != 0L)
      {
        output.WriteRawTag((byte) 16);
        output.WriteInt64(this.DateFrom);
      }
      if (this.DateTo != 0L)
      {
        output.WriteRawTag((byte) 24);
        output.WriteInt64(this.DateTo);
      }
      if (this.Period != HistoryQuotesPeriodProto.UnknownHistoryQuotesPeriod)
      {
        output.WriteRawTag((byte) 32);
        output.WriteEnum((int) this.Period);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.bars_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.Bars);
      if (this.DateFrom != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.DateFrom);
      if (this.DateTo != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.DateTo);
      if (this.Period != HistoryQuotesPeriodProto.UnknownHistoryQuotesPeriod)
        num += 1 + CodedOutputStream.ComputeEnumSize((int) this.Period);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(BarsNotificationProto other)
    {
      if (other == null)
        return;
      if (other.bars_ != null)
      {
        if (this.bars_ == null)
          this.Bars = new HistoryQuotesForSymbolProto();
        this.Bars.MergeFrom(other.Bars);
      }
      if (other.DateFrom != 0L)
        this.DateFrom = other.DateFrom;
      if (other.DateTo != 0L)
        this.DateTo = other.DateTo;
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
          case 10:
            if (this.bars_ == null)
              this.Bars = new HistoryQuotesForSymbolProto();
            input.ReadMessage((IMessage) this.Bars);
            continue;
          case 16:
            this.DateFrom = input.ReadInt64();
            continue;
          case 24:
            this.DateTo = input.ReadInt64();
            continue;
          case 32:
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
