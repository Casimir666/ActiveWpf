// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetSymbolsNotificationProto
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
  public sealed class GetSymbolsNotificationProto : 
    IMessage<GetSymbolsNotificationProto>,
    IMessage,
    IEquatable<GetSymbolsNotificationProto>,
    IDeepCloneable<GetSymbolsNotificationProto>
  {
    private static readonly MessageParser<GetSymbolsNotificationProto> _parser = new MessageParser<GetSymbolsNotificationProto>((Func<GetSymbolsNotificationProto>) (() => new GetSymbolsNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int SymbolsFieldNumber = 1;
    private static readonly FieldCodec<SymbolProto> _repeated_symbols_codec = FieldCodec.ForMessage<SymbolProto>(10U, SymbolProto.Parser);
    private readonly RepeatedField<SymbolProto> symbols_ = new RepeatedField<SymbolProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetSymbolsNotificationProto> Parser => GetSymbolsNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[40];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetSymbolsNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetSymbolsNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetSymbolsNotificationProto(GetSymbolsNotificationProto other)
      : this()
    {
      this.symbols_ = other.symbols_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetSymbolsNotificationProto Clone() => new GetSymbolsNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<SymbolProto> Symbols => this.symbols_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetSymbolsNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetSymbolsNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.symbols_.Equals(other.symbols_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.symbols_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.symbols_.WriteTo(output, GetSymbolsNotificationProto._repeated_symbols_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.symbols_.CalculateSize(GetSymbolsNotificationProto._repeated_symbols_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetSymbolsNotificationProto other)
    {
      if (other == null)
        return;
      this.symbols_.Add((IEnumerable<SymbolProto>) other.symbols_);
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
          this.symbols_.AddEntriesFrom(input, GetSymbolsNotificationProto._repeated_symbols_codec);
      }
    }
  }
}
