// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetSymbolsMarginTiersNotificationProto
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
  public sealed class GetSymbolsMarginTiersNotificationProto : 
    IMessage<GetSymbolsMarginTiersNotificationProto>,
    IMessage,
    IEquatable<GetSymbolsMarginTiersNotificationProto>,
    IDeepCloneable<GetSymbolsMarginTiersNotificationProto>
  {
    private static readonly MessageParser<GetSymbolsMarginTiersNotificationProto> _parser = new MessageParser<GetSymbolsMarginTiersNotificationProto>((Func<GetSymbolsMarginTiersNotificationProto>) (() => new GetSymbolsMarginTiersNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int SymbolMarginTiersFieldNumber = 1;
    private static readonly FieldCodec<SymbolMarginTiersProto> _repeated_symbolMarginTiers_codec = FieldCodec.ForMessage<SymbolMarginTiersProto>(10U, SymbolMarginTiersProto.Parser);
    private readonly RepeatedField<SymbolMarginTiersProto> symbolMarginTiers_ = new RepeatedField<SymbolMarginTiersProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetSymbolsMarginTiersNotificationProto> Parser => GetSymbolsMarginTiersNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[46];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetSymbolsMarginTiersNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetSymbolsMarginTiersNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetSymbolsMarginTiersNotificationProto(GetSymbolsMarginTiersNotificationProto other)
      : this()
    {
      this.symbolMarginTiers_ = other.symbolMarginTiers_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetSymbolsMarginTiersNotificationProto Clone() => new GetSymbolsMarginTiersNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<SymbolMarginTiersProto> SymbolMarginTiers => this.symbolMarginTiers_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetSymbolsMarginTiersNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetSymbolsMarginTiersNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.symbolMarginTiers_.Equals(other.symbolMarginTiers_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.symbolMarginTiers_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.symbolMarginTiers_.WriteTo(output, GetSymbolsMarginTiersNotificationProto._repeated_symbolMarginTiers_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.symbolMarginTiers_.CalculateSize(GetSymbolsMarginTiersNotificationProto._repeated_symbolMarginTiers_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetSymbolsMarginTiersNotificationProto other)
    {
      if (other == null)
        return;
      this.symbolMarginTiers_.Add((IEnumerable<SymbolMarginTiersProto>) other.symbolMarginTiers_);
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
          this.symbolMarginTiers_.AddEntriesFrom(input, GetSymbolsMarginTiersNotificationProto._repeated_symbolMarginTiers_codec);
      }
    }
  }
}
