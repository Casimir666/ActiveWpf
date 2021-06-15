// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.SymbolTagsProto
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
  public sealed class SymbolTagsProto : 
    IMessage<SymbolTagsProto>,
    IMessage,
    IEquatable<SymbolTagsProto>,
    IDeepCloneable<SymbolTagsProto>
  {
    private static readonly MessageParser<SymbolTagsProto> _parser = new MessageParser<SymbolTagsProto>((Func<SymbolTagsProto>) (() => new SymbolTagsProto()));
    private UnknownFieldSet _unknownFields;
    public const int SymbolIdFieldNumber = 1;
    private string symbolId_ = "";
    public const int TagIdsFieldNumber = 2;
    private static readonly FieldCodec<int> _repeated_tagIds_codec = FieldCodec.ForInt32(18U);
    private readonly RepeatedField<int> tagIds_ = new RepeatedField<int>();

    [DebuggerNonUserCode]
    public static MessageParser<SymbolTagsProto> Parser => SymbolTagsProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[107];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => SymbolTagsProto.Descriptor;

    [DebuggerNonUserCode]
    public SymbolTagsProto()
    {
    }

    [DebuggerNonUserCode]
    public SymbolTagsProto(SymbolTagsProto other)
      : this()
    {
      this.symbolId_ = other.symbolId_;
      this.tagIds_ = other.tagIds_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public SymbolTagsProto Clone() => new SymbolTagsProto(this);

    [DebuggerNonUserCode]
    public string SymbolId
    {
      get => this.symbolId_;
      set => this.symbolId_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public RepeatedField<int> TagIds => this.tagIds_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as SymbolTagsProto);

    [DebuggerNonUserCode]
    public bool Equals(SymbolTagsProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return !(this.SymbolId != other.SymbolId) && this.tagIds_.Equals(other.tagIds_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      if (this.SymbolId.Length != 0)
        num1 ^= this.SymbolId.GetHashCode();
      int num2 = num1 ^ this.tagIds_.GetHashCode();
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
      this.tagIds_.WriteTo(output, SymbolTagsProto._repeated_tagIds_codec);
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
      int num2 = num1 + this.tagIds_.CalculateSize(SymbolTagsProto._repeated_tagIds_codec);
      if (this._unknownFields != null)
        num2 += this._unknownFields.CalculateSize();
      return num2;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(SymbolTagsProto other)
    {
      if (other == null)
        return;
      if (other.SymbolId.Length != 0)
        this.SymbolId = other.SymbolId;
      this.tagIds_.Add((IEnumerable<int>) other.tagIds_);
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
          case 16:
          case 18:
            this.tagIds_.AddEntriesFrom(input, SymbolTagsProto._repeated_tagIds_codec);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
