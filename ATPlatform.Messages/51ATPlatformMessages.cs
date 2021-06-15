// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetLastTicksNotificationProto
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
  public sealed class GetLastTicksNotificationProto : 
    IMessage<GetLastTicksNotificationProto>,
    IMessage,
    IEquatable<GetLastTicksNotificationProto>,
    IDeepCloneable<GetLastTicksNotificationProto>
  {
    private static readonly MessageParser<GetLastTicksNotificationProto> _parser = new MessageParser<GetLastTicksNotificationProto>((Func<GetLastTicksNotificationProto>) (() => new GetLastTicksNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int TicksFieldNumber = 1;
    private static readonly FieldCodec<TickProto> _repeated_ticks_codec = FieldCodec.ForMessage<TickProto>(10U, TickProto.Parser);
    private readonly RepeatedField<TickProto> ticks_ = new RepeatedField<TickProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetLastTicksNotificationProto> Parser => GetLastTicksNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[33];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetLastTicksNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetLastTicksNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetLastTicksNotificationProto(GetLastTicksNotificationProto other)
      : this()
    {
      this.ticks_ = other.ticks_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetLastTicksNotificationProto Clone() => new GetLastTicksNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<TickProto> Ticks => this.ticks_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetLastTicksNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetLastTicksNotificationProto other)
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
      this.ticks_.WriteTo(output, GetLastTicksNotificationProto._repeated_ticks_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.ticks_.CalculateSize(GetLastTicksNotificationProto._repeated_ticks_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetLastTicksNotificationProto other)
    {
      if (other == null)
        return;
      this.ticks_.Add((IEnumerable<TickProto>) other.ticks_);
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
          this.ticks_.AddEntriesFrom(input, GetLastTicksNotificationProto._repeated_ticks_codec);
      }
    }
  }
}
