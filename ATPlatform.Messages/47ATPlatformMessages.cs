// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetLastPricesRequestProto
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
  public sealed class GetLastPricesRequestProto : 
    IMessage<GetLastPricesRequestProto>,
    IMessage,
    IEquatable<GetLastPricesRequestProto>,
    IDeepCloneable<GetLastPricesRequestProto>
  {
    private static readonly MessageParser<GetLastPricesRequestProto> _parser = new MessageParser<GetLastPricesRequestProto>((Func<GetLastPricesRequestProto>) (() => new GetLastPricesRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int SymbolsFieldNumber = 1;
    private static readonly FieldCodec<string> _repeated_symbols_codec = FieldCodec.ForString(10U);
    private readonly RepeatedField<string> symbols_ = new RepeatedField<string>();

    [DebuggerNonUserCode]
    public static MessageParser<GetLastPricesRequestProto> Parser => GetLastPricesRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[29];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetLastPricesRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public GetLastPricesRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public GetLastPricesRequestProto(GetLastPricesRequestProto other)
      : this()
    {
      this.symbols_ = other.symbols_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetLastPricesRequestProto Clone() => new GetLastPricesRequestProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<string> Symbols => this.symbols_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetLastPricesRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(GetLastPricesRequestProto other)
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
      this.symbols_.WriteTo(output, GetLastPricesRequestProto._repeated_symbols_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.symbols_.CalculateSize(GetLastPricesRequestProto._repeated_symbols_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetLastPricesRequestProto other)
    {
      if (other == null)
        return;
      this.symbols_.Add((IEnumerable<string>) other.symbols_);
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
          this.symbols_.AddEntriesFrom(input, GetLastPricesRequestProto._repeated_symbols_codec);
      }
    }
  }
}
