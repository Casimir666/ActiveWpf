// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.UpdateAverageSymbolSpreadRequestProto
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
  public sealed class UpdateAverageSymbolSpreadRequestProto : 
    IMessage<UpdateAverageSymbolSpreadRequestProto>,
    IMessage,
    IEquatable<UpdateAverageSymbolSpreadRequestProto>,
    IDeepCloneable<UpdateAverageSymbolSpreadRequestProto>
  {
    private static readonly MessageParser<UpdateAverageSymbolSpreadRequestProto> _parser = new MessageParser<UpdateAverageSymbolSpreadRequestProto>((Func<UpdateAverageSymbolSpreadRequestProto>) (() => new UpdateAverageSymbolSpreadRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int SymbolSpreadsFieldNumber = 1;
    private static readonly FieldCodec<SymbolSpreadProto> _repeated_symbolSpreads_codec = FieldCodec.ForMessage<SymbolSpreadProto>(10U, SymbolSpreadProto.Parser);
    private readonly RepeatedField<SymbolSpreadProto> symbolSpreads_ = new RepeatedField<SymbolSpreadProto>();

    [DebuggerNonUserCode]
    public static MessageParser<UpdateAverageSymbolSpreadRequestProto> Parser => UpdateAverageSymbolSpreadRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[187];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => UpdateAverageSymbolSpreadRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public UpdateAverageSymbolSpreadRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public UpdateAverageSymbolSpreadRequestProto(UpdateAverageSymbolSpreadRequestProto other)
      : this()
    {
      this.symbolSpreads_ = other.symbolSpreads_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public UpdateAverageSymbolSpreadRequestProto Clone() => new UpdateAverageSymbolSpreadRequestProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<SymbolSpreadProto> SymbolSpreads => this.symbolSpreads_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as UpdateAverageSymbolSpreadRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(UpdateAverageSymbolSpreadRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.symbolSpreads_.Equals(other.symbolSpreads_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.symbolSpreads_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.symbolSpreads_.WriteTo(output, UpdateAverageSymbolSpreadRequestProto._repeated_symbolSpreads_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.symbolSpreads_.CalculateSize(UpdateAverageSymbolSpreadRequestProto._repeated_symbolSpreads_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(UpdateAverageSymbolSpreadRequestProto other)
    {
      if (other == null)
        return;
      this.symbolSpreads_.Add((IEnumerable<SymbolSpreadProto>) other.symbolSpreads_);
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
          this.symbolSpreads_.AddEntriesFrom(input, UpdateAverageSymbolSpreadRequestProto._repeated_symbolSpreads_codec);
      }
    }
  }
}
