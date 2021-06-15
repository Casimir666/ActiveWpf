// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetSymbolsTagsNotificationProto
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
  public sealed class GetSymbolsTagsNotificationProto : 
    IMessage<GetSymbolsTagsNotificationProto>,
    IMessage,
    IEquatable<GetSymbolsTagsNotificationProto>,
    IDeepCloneable<GetSymbolsTagsNotificationProto>
  {
    private static readonly MessageParser<GetSymbolsTagsNotificationProto> _parser = new MessageParser<GetSymbolsTagsNotificationProto>((Func<GetSymbolsTagsNotificationProto>) (() => new GetSymbolsTagsNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int SymbolTagsFieldNumber = 1;
    private static readonly FieldCodec<SymbolTagsProto> _repeated_symbolTags_codec = FieldCodec.ForMessage<SymbolTagsProto>(10U, SymbolTagsProto.Parser);
    private readonly RepeatedField<SymbolTagsProto> symbolTags_ = new RepeatedField<SymbolTagsProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetSymbolsTagsNotificationProto> Parser => GetSymbolsTagsNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[109];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetSymbolsTagsNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetSymbolsTagsNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetSymbolsTagsNotificationProto(GetSymbolsTagsNotificationProto other)
      : this()
    {
      this.symbolTags_ = other.symbolTags_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetSymbolsTagsNotificationProto Clone() => new GetSymbolsTagsNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<SymbolTagsProto> SymbolTags => this.symbolTags_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetSymbolsTagsNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetSymbolsTagsNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.symbolTags_.Equals(other.symbolTags_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.symbolTags_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.symbolTags_.WriteTo(output, GetSymbolsTagsNotificationProto._repeated_symbolTags_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.symbolTags_.CalculateSize(GetSymbolsTagsNotificationProto._repeated_symbolTags_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetSymbolsTagsNotificationProto other)
    {
      if (other == null)
        return;
      this.symbolTags_.Add((IEnumerable<SymbolTagsProto>) other.symbolTags_);
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
          this.symbolTags_.AddEntriesFrom(input, GetSymbolsTagsNotificationProto._repeated_symbolTags_codec);
      }
    }
  }
}
