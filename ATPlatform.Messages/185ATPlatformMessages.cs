// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.ExposureNotificationProto
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
  public sealed class ExposureNotificationProto : 
    IMessage<ExposureNotificationProto>,
    IMessage,
    IEquatable<ExposureNotificationProto>,
    IDeepCloneable<ExposureNotificationProto>
  {
    private static readonly MessageParser<ExposureNotificationProto> _parser = new MessageParser<ExposureNotificationProto>((Func<ExposureNotificationProto>) (() => new ExposureNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int ExposurePerSymbolFieldNumber = 1;
    private static readonly FieldCodec<ExposureProto> _repeated_exposurePerSymbol_codec = FieldCodec.ForMessage<ExposureProto>(10U, ExposureProto.Parser);
    private readonly RepeatedField<ExposureProto> exposurePerSymbol_ = new RepeatedField<ExposureProto>();

    [DebuggerNonUserCode]
    public static MessageParser<ExposureNotificationProto> Parser => ExposureNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[183];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => ExposureNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public ExposureNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public ExposureNotificationProto(ExposureNotificationProto other)
      : this()
    {
      this.exposurePerSymbol_ = other.exposurePerSymbol_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public ExposureNotificationProto Clone() => new ExposureNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<ExposureProto> ExposurePerSymbol => this.exposurePerSymbol_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as ExposureNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(ExposureNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.exposurePerSymbol_.Equals(other.exposurePerSymbol_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.exposurePerSymbol_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.exposurePerSymbol_.WriteTo(output, ExposureNotificationProto._repeated_exposurePerSymbol_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.exposurePerSymbol_.CalculateSize(ExposureNotificationProto._repeated_exposurePerSymbol_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(ExposureNotificationProto other)
    {
      if (other == null)
        return;
      this.exposurePerSymbol_.Add((IEnumerable<ExposureProto>) other.exposurePerSymbol_);
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
          this.exposurePerSymbol_.AddEntriesFrom(input, ExposureNotificationProto._repeated_exposurePerSymbol_codec);
      }
    }
  }
}
