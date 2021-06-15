// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.MarkupSettingsProto
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
  public sealed class MarkupSettingsProto : 
    IMessage<MarkupSettingsProto>,
    IMessage,
    IEquatable<MarkupSettingsProto>,
    IDeepCloneable<MarkupSettingsProto>
  {
    private static readonly MessageParser<MarkupSettingsProto> _parser = new MessageParser<MarkupSettingsProto>((Func<MarkupSettingsProto>) (() => new MarkupSettingsProto()));
    private UnknownFieldSet _unknownFields;
    public const int SymbolGroupIdFieldNumber = 1;
    private int symbolGroupId_;
    public const int SymbolIdFieldNumber = 2;
    private string symbolId_ = "";
    public const int AskMarkupFieldNumber = 3;
    private int askMarkup_;
    public const int BidMarkupFieldNumber = 4;
    private int bidMarkup_;
    public const int MarkupsVolumesFieldNumber = 5;
    private static readonly FieldCodec<MarkupVolumeProto> _repeated_markupsVolumes_codec = FieldCodec.ForMessage<MarkupVolumeProto>(42U, MarkupVolumeProto.Parser);
    private readonly RepeatedField<MarkupVolumeProto> markupsVolumes_ = new RepeatedField<MarkupVolumeProto>();
    public const int MarkupsSessionsFieldNumber = 6;
    private static readonly FieldCodec<MarkupSessionProto> _repeated_markupsSessions_codec = FieldCodec.ForMessage<MarkupSessionProto>(50U, MarkupSessionProto.Parser);
    private readonly RepeatedField<MarkupSessionProto> markupsSessions_ = new RepeatedField<MarkupSessionProto>();
    public const int ConversionRateMarkupFieldNumber = 7;
    private double conversionRateMarkup_;
    public const int TagIdFieldNumber = 8;
    private int tagId_;

    [DebuggerNonUserCode]
    public static MessageParser<MarkupSettingsProto> Parser => MarkupSettingsProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[75];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => MarkupSettingsProto.Descriptor;

    [DebuggerNonUserCode]
    public MarkupSettingsProto()
    {
    }

    [DebuggerNonUserCode]
    public MarkupSettingsProto(MarkupSettingsProto other)
      : this()
    {
      this.symbolGroupId_ = other.symbolGroupId_;
      this.symbolId_ = other.symbolId_;
      this.askMarkup_ = other.askMarkup_;
      this.bidMarkup_ = other.bidMarkup_;
      this.markupsVolumes_ = other.markupsVolumes_.Clone();
      this.markupsSessions_ = other.markupsSessions_.Clone();
      this.conversionRateMarkup_ = other.conversionRateMarkup_;
      this.tagId_ = other.tagId_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public MarkupSettingsProto Clone() => new MarkupSettingsProto(this);

    [DebuggerNonUserCode]
    public int SymbolGroupId
    {
      get => this.symbolGroupId_;
      set => this.symbolGroupId_ = value;
    }

    [DebuggerNonUserCode]
    public string SymbolId
    {
      get => this.symbolId_;
      set => this.symbolId_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public int AskMarkup
    {
      get => this.askMarkup_;
      set => this.askMarkup_ = value;
    }

    [DebuggerNonUserCode]
    public int BidMarkup
    {
      get => this.bidMarkup_;
      set => this.bidMarkup_ = value;
    }

    [DebuggerNonUserCode]
    public RepeatedField<MarkupVolumeProto> MarkupsVolumes => this.markupsVolumes_;

    [DebuggerNonUserCode]
    public RepeatedField<MarkupSessionProto> MarkupsSessions => this.markupsSessions_;

    [DebuggerNonUserCode]
    public double ConversionRateMarkup
    {
      get => this.conversionRateMarkup_;
      set => this.conversionRateMarkup_ = value;
    }

    [DebuggerNonUserCode]
    public int TagId
    {
      get => this.tagId_;
      set => this.tagId_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as MarkupSettingsProto);

    [DebuggerNonUserCode]
    public bool Equals(MarkupSettingsProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.SymbolGroupId == other.SymbolGroupId && !(this.SymbolId != other.SymbolId) && (this.AskMarkup == other.AskMarkup && this.BidMarkup == other.BidMarkup) && (this.markupsVolumes_.Equals(other.markupsVolumes_) && this.markupsSessions_.Equals(other.markupsSessions_) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.ConversionRateMarkup, other.ConversionRateMarkup) && this.TagId == other.TagId)) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      int num2;
      if (this.SymbolGroupId != 0)
      {
        int num3 = num1;
        num2 = this.SymbolGroupId;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.SymbolId.Length != 0)
        num1 ^= this.SymbolId.GetHashCode();
      if (this.AskMarkup != 0)
      {
        int num3 = num1;
        num2 = this.AskMarkup;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.BidMarkup != 0)
      {
        int num3 = num1;
        num2 = this.BidMarkup;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      int num4 = num1 ^ this.markupsVolumes_.GetHashCode() ^ this.markupsSessions_.GetHashCode();
      if (this.ConversionRateMarkup != 0.0)
        num4 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.ConversionRateMarkup);
      if (this.TagId != 0)
      {
        int num3 = num4;
        num2 = this.TagId;
        int hashCode = num2.GetHashCode();
        num4 = num3 ^ hashCode;
      }
      if (this._unknownFields != null)
        num4 ^= this._unknownFields.GetHashCode();
      return num4;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.SymbolGroupId != 0)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt32(this.SymbolGroupId);
      }
      if (this.SymbolId.Length != 0)
      {
        output.WriteRawTag((byte) 18);
        output.WriteString(this.SymbolId);
      }
      if (this.AskMarkup != 0)
      {
        output.WriteRawTag((byte) 24);
        output.WriteInt32(this.AskMarkup);
      }
      if (this.BidMarkup != 0)
      {
        output.WriteRawTag((byte) 32);
        output.WriteInt32(this.BidMarkup);
      }
      this.markupsVolumes_.WriteTo(output, MarkupSettingsProto._repeated_markupsVolumes_codec);
      this.markupsSessions_.WriteTo(output, MarkupSettingsProto._repeated_markupsSessions_codec);
      if (this.ConversionRateMarkup != 0.0)
      {
        output.WriteRawTag((byte) 57);
        output.WriteDouble(this.ConversionRateMarkup);
      }
      if (this.TagId != 0)
      {
        output.WriteRawTag((byte) 64);
        output.WriteInt32(this.TagId);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num1 = 0;
      if (this.SymbolGroupId != 0)
        num1 += 1 + CodedOutputStream.ComputeInt32Size(this.SymbolGroupId);
      if (this.SymbolId.Length != 0)
        num1 += 1 + CodedOutputStream.ComputeStringSize(this.SymbolId);
      if (this.AskMarkup != 0)
        num1 += 1 + CodedOutputStream.ComputeInt32Size(this.AskMarkup);
      if (this.BidMarkup != 0)
        num1 += 1 + CodedOutputStream.ComputeInt32Size(this.BidMarkup);
      int num2 = num1 + this.markupsVolumes_.CalculateSize(MarkupSettingsProto._repeated_markupsVolumes_codec) + this.markupsSessions_.CalculateSize(MarkupSettingsProto._repeated_markupsSessions_codec);
      if (this.ConversionRateMarkup != 0.0)
        num2 += 9;
      if (this.TagId != 0)
        num2 += 1 + CodedOutputStream.ComputeInt32Size(this.TagId);
      if (this._unknownFields != null)
        num2 += this._unknownFields.CalculateSize();
      return num2;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(MarkupSettingsProto other)
    {
      if (other == null)
        return;
      if (other.SymbolGroupId != 0)
        this.SymbolGroupId = other.SymbolGroupId;
      if (other.SymbolId.Length != 0)
        this.SymbolId = other.SymbolId;
      if (other.AskMarkup != 0)
        this.AskMarkup = other.AskMarkup;
      if (other.BidMarkup != 0)
        this.BidMarkup = other.BidMarkup;
      this.markupsVolumes_.Add((IEnumerable<MarkupVolumeProto>) other.markupsVolumes_);
      this.markupsSessions_.Add((IEnumerable<MarkupSessionProto>) other.markupsSessions_);
      if (other.ConversionRateMarkup != 0.0)
        this.ConversionRateMarkup = other.ConversionRateMarkup;
      if (other.TagId != 0)
        this.TagId = other.TagId;
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
          case 8:
            this.SymbolGroupId = input.ReadInt32();
            continue;
          case 18:
            this.SymbolId = input.ReadString();
            continue;
          case 24:
            this.AskMarkup = input.ReadInt32();
            continue;
          case 32:
            this.BidMarkup = input.ReadInt32();
            continue;
          case 42:
            this.markupsVolumes_.AddEntriesFrom(input, MarkupSettingsProto._repeated_markupsVolumes_codec);
            continue;
          case 50:
            this.markupsSessions_.AddEntriesFrom(input, MarkupSettingsProto._repeated_markupsSessions_codec);
            continue;
          case 57:
            this.ConversionRateMarkup = input.ReadDouble();
            continue;
          case 64:
            this.TagId = input.ReadInt32();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
