// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.TrailingStopsNotificationProto
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
  public sealed class TrailingStopsNotificationProto : 
    IMessage<TrailingStopsNotificationProto>,
    IMessage,
    IEquatable<TrailingStopsNotificationProto>,
    IDeepCloneable<TrailingStopsNotificationProto>
  {
    private static readonly MessageParser<TrailingStopsNotificationProto> _parser = new MessageParser<TrailingStopsNotificationProto>((Func<TrailingStopsNotificationProto>) (() => new TrailingStopsNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int StopsFieldNumber = 1;
    private static readonly FieldCodec<TrailingStopProto> _repeated_stops_codec = FieldCodec.ForMessage<TrailingStopProto>(10U, TrailingStopProto.Parser);
    private readonly RepeatedField<TrailingStopProto> stops_ = new RepeatedField<TrailingStopProto>();

    [DebuggerNonUserCode]
    public static MessageParser<TrailingStopsNotificationProto> Parser => TrailingStopsNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[18];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => TrailingStopsNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public TrailingStopsNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public TrailingStopsNotificationProto(TrailingStopsNotificationProto other)
      : this()
    {
      this.stops_ = other.stops_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public TrailingStopsNotificationProto Clone() => new TrailingStopsNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<TrailingStopProto> Stops => this.stops_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as TrailingStopsNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(TrailingStopsNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.stops_.Equals(other.stops_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.stops_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.stops_.WriteTo(output, TrailingStopsNotificationProto._repeated_stops_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.stops_.CalculateSize(TrailingStopsNotificationProto._repeated_stops_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(TrailingStopsNotificationProto other)
    {
      if (other == null)
        return;
      this.stops_.Add((IEnumerable<TrailingStopProto>) other.stops_);
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
          this.stops_.AddEntriesFrom(input, TrailingStopsNotificationProto._repeated_stops_codec);
      }
    }
  }
}
