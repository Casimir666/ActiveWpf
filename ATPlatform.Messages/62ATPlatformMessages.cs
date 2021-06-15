// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.SymbolMarginTiersProto
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
  public sealed class SymbolMarginTiersProto : 
    IMessage<SymbolMarginTiersProto>,
    IMessage,
    IEquatable<SymbolMarginTiersProto>,
    IDeepCloneable<SymbolMarginTiersProto>
  {
    private static readonly MessageParser<SymbolMarginTiersProto> _parser = new MessageParser<SymbolMarginTiersProto>((Func<SymbolMarginTiersProto>) (() => new SymbolMarginTiersProto()));
    private UnknownFieldSet _unknownFields;
    public const int SymbolIdFieldNumber = 1;
    private string symbolId_ = "";
    public const int MarginTiersFieldNumber = 2;
    private static readonly FieldCodec<MarginTierProto> _repeated_marginTiers_codec = FieldCodec.ForMessage<MarginTierProto>(18U, MarginTierProto.Parser);
    private readonly RepeatedField<MarginTierProto> marginTiers_ = new RepeatedField<MarginTierProto>();

    [DebuggerNonUserCode]
    public static MessageParser<SymbolMarginTiersProto> Parser => SymbolMarginTiersProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[45];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => SymbolMarginTiersProto.Descriptor;

    [DebuggerNonUserCode]
    public SymbolMarginTiersProto()
    {
    }

    [DebuggerNonUserCode]
    public SymbolMarginTiersProto(SymbolMarginTiersProto other)
      : this()
    {
      this.symbolId_ = other.symbolId_;
      this.marginTiers_ = other.marginTiers_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public SymbolMarginTiersProto Clone() => new SymbolMarginTiersProto(this);

    [DebuggerNonUserCode]
    public string SymbolId
    {
      get => this.symbolId_;
      set => this.symbolId_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public RepeatedField<MarginTierProto> MarginTiers => this.marginTiers_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as SymbolMarginTiersProto);

    [DebuggerNonUserCode]
    public bool Equals(SymbolMarginTiersProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return !(this.SymbolId != other.SymbolId) && this.marginTiers_.Equals(other.marginTiers_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      if (this.SymbolId.Length != 0)
        num1 ^= this.SymbolId.GetHashCode();
      int num2 = num1 ^ this.marginTiers_.GetHashCode();
      if (this._unknownFields != null)
        num2 ^= this._unknownFields.GetHashCode();
      return num2;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.SymbolId.Length != 0)
      {
        output.WriteRawTag((byte) 10);
        output.WriteString(this.SymbolId);
      }
      this.marginTiers_.WriteTo(output, SymbolMarginTiersProto._repeated_marginTiers_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num1 = 0;
      if (this.SymbolId.Length != 0)
        num1 += 1 + CodedOutputStream.ComputeStringSize(this.SymbolId);
      int num2 = num1 + this.marginTiers_.CalculateSize(SymbolMarginTiersProto._repeated_marginTiers_codec);
      if (this._unknownFields != null)
        num2 += this._unknownFields.CalculateSize();
      return num2;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(SymbolMarginTiersProto other)
    {
      if (other == null)
        return;
      if (other.SymbolId.Length != 0)
        this.SymbolId = other.SymbolId;
      this.marginTiers_.Add((IEnumerable<MarginTierProto>) other.marginTiers_);
      this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
    }

    [DebuggerNonUserCode]
    public void MergeFrom(CodedInputStream input)
    {
      uint num;
      while ((num = input.ReadTag()) != 0U)
      {
        switch (num)
        {
          case 10:
            this.SymbolId = input.ReadString();
            continue;
          case 18:
            this.marginTiers_.AddEntriesFrom(input, SymbolMarginTiersProto._repeated_marginTiers_codec);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
