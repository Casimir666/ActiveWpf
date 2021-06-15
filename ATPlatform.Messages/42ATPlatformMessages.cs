// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.CurrentQuotesNotificationProto
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
  public sealed class CurrentQuotesNotificationProto : 
    IMessage<CurrentQuotesNotificationProto>,
    IMessage,
    IEquatable<CurrentQuotesNotificationProto>,
    IDeepCloneable<CurrentQuotesNotificationProto>
  {
    private static readonly MessageParser<CurrentQuotesNotificationProto> _parser = new MessageParser<CurrentQuotesNotificationProto>((Func<CurrentQuotesNotificationProto>) (() => new CurrentQuotesNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int QuotesFieldNumber = 1;
    private static readonly FieldCodec<HistoryQuoteForSymbolProto> _repeated_quotes_codec = FieldCodec.ForMessage<HistoryQuoteForSymbolProto>(10U, HistoryQuoteForSymbolProto.Parser);
    private readonly RepeatedField<HistoryQuoteForSymbolProto> quotes_ = new RepeatedField<HistoryQuoteForSymbolProto>();

    [DebuggerNonUserCode]
    public static MessageParser<CurrentQuotesNotificationProto> Parser => CurrentQuotesNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[24];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => CurrentQuotesNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public CurrentQuotesNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public CurrentQuotesNotificationProto(CurrentQuotesNotificationProto other)
      : this()
    {
      this.quotes_ = other.quotes_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public CurrentQuotesNotificationProto Clone() => new CurrentQuotesNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<HistoryQuoteForSymbolProto> Quotes => this.quotes_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as CurrentQuotesNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(CurrentQuotesNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.quotes_.Equals(other.quotes_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.quotes_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.quotes_.WriteTo(output, CurrentQuotesNotificationProto._repeated_quotes_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.quotes_.CalculateSize(CurrentQuotesNotificationProto._repeated_quotes_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(CurrentQuotesNotificationProto other)
    {
      if (other == null)
        return;
      this.quotes_.Add((IEnumerable<HistoryQuoteForSymbolProto>) other.quotes_);
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
          this.quotes_.AddEntriesFrom(input, CurrentQuotesNotificationProto._repeated_quotes_codec);
      }
    }
  }
}
