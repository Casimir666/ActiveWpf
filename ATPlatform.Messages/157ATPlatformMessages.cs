// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.TicksNotificationProto
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
  public sealed class TicksNotificationProto : 
    IMessage<TicksNotificationProto>,
    IMessage,
    IEquatable<TicksNotificationProto>,
    IDeepCloneable<TicksNotificationProto>
  {
    private static readonly MessageParser<TicksNotificationProto> _parser = new MessageParser<TicksNotificationProto>((Func<TicksNotificationProto>) (() => new TicksNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int TicksFieldNumber = 1;
    private static readonly FieldCodec<SmallTickProto> _repeated_ticks_codec = FieldCodec.ForMessage<SmallTickProto>(10U, SmallTickProto.Parser);
    private readonly RepeatedField<SmallTickProto> ticks_ = new RepeatedField<SmallTickProto>();

    [DebuggerNonUserCode]
    public static MessageParser<TicksNotificationProto> Parser => TicksNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[150];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => TicksNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public TicksNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public TicksNotificationProto(TicksNotificationProto other)
      : this()
    {
      this.ticks_ = other.ticks_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public TicksNotificationProto Clone() => new TicksNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<SmallTickProto> Ticks => this.ticks_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as TicksNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(TicksNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.ticks_.Equals(other.ticks_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.ticks_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.ticks_.WriteTo(output, TicksNotificationProto._repeated_ticks_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.ticks_.CalculateSize(TicksNotificationProto._repeated_ticks_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(TicksNotificationProto other)
    {
      if (other == null)
        return;
      this.ticks_.Add((IEnumerable<SmallTickProto>) other.ticks_);
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
          this.ticks_.AddEntriesFrom(input, TicksNotificationProto._repeated_ticks_codec);
      }
    }
  }
}
