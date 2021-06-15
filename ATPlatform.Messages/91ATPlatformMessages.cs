// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.DynamicLeverageSettingsProto
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
  public sealed class DynamicLeverageSettingsProto : 
    IMessage<DynamicLeverageSettingsProto>,
    IMessage,
    IEquatable<DynamicLeverageSettingsProto>,
    IDeepCloneable<DynamicLeverageSettingsProto>
  {
    private static readonly MessageParser<DynamicLeverageSettingsProto> _parser = new MessageParser<DynamicLeverageSettingsProto>((Func<DynamicLeverageSettingsProto>) (() => new DynamicLeverageSettingsProto()));
    private UnknownFieldSet _unknownFields;
    public const int IdFieldNumber = 1;
    private int id_;
    public const int NameFieldNumber = 2;
    private string name_ = "";
    public const int UsedMarginTiersFieldNumber = 3;
    private static readonly FieldCodec<MarginTierProto> _repeated_usedMarginTiers_codec = FieldCodec.ForMessage<MarginTierProto>(26U, MarginTierProto.Parser);
    private readonly RepeatedField<MarginTierProto> usedMarginTiers_ = new RepeatedField<MarginTierProto>();

    [DebuggerNonUserCode]
    public static MessageParser<DynamicLeverageSettingsProto> Parser => DynamicLeverageSettingsProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[80];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => DynamicLeverageSettingsProto.Descriptor;

    [DebuggerNonUserCode]
    public DynamicLeverageSettingsProto()
    {
    }

    [DebuggerNonUserCode]
    public DynamicLeverageSettingsProto(DynamicLeverageSettingsProto other)
      : this()
    {
      this.id_ = other.id_;
      this.name_ = other.name_;
      this.usedMarginTiers_ = other.usedMarginTiers_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public DynamicLeverageSettingsProto Clone() => new DynamicLeverageSettingsProto(this);

    [DebuggerNonUserCode]
    public int Id
    {
      get => this.id_;
      set => this.id_ = value;
    }

    [DebuggerNonUserCode]
    public string Name
    {
      get => this.name_;
      set => this.name_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public RepeatedField<MarginTierProto> UsedMarginTiers => this.usedMarginTiers_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as DynamicLeverageSettingsProto);

    [DebuggerNonUserCode]
    public bool Equals(DynamicLeverageSettingsProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.Id == other.Id && !(this.Name != other.Name) && this.usedMarginTiers_.Equals(other.usedMarginTiers_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      if (this.Id != 0)
        num1 ^= this.Id.GetHashCode();
      if (this.Name.Length != 0)
        num1 ^= this.Name.GetHashCode();
      int num2 = num1 ^ this.usedMarginTiers_.GetHashCode();
      if (this._unknownFields != null)
        num2 ^= this._unknownFields.GetHashCode();
      return num2;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.Id != 0)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt32(this.Id);
      }
      if (this.Name.Length != 0)
      {
        output.WriteRawTag((byte) 18);
        output.WriteString(this.Name);
      }
      this.usedMarginTiers_.WriteTo(output, DynamicLeverageSettingsProto._repeated_usedMarginTiers_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num1 = 0;
      if (this.Id != 0)
        num1 += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
      if (this.Name.Length != 0)
        num1 += 1 + CodedOutputStream.ComputeStringSize(this.Name);
      int num2 = num1 + this.usedMarginTiers_.CalculateSize(DynamicLeverageSettingsProto._repeated_usedMarginTiers_codec);
      if (this._unknownFields != null)
        num2 += this._unknownFields.CalculateSize();
      return num2;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(DynamicLeverageSettingsProto other)
    {
      if (other == null)
        return;
      if (other.Id != 0)
        this.Id = other.Id;
      if (other.Name.Length != 0)
        this.Name = other.Name;
      this.usedMarginTiers_.Add((IEnumerable<MarginTierProto>) other.usedMarginTiers_);
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
            this.Id = input.ReadInt32();
            continue;
          case 18:
            this.Name = input.ReadString();
            continue;
          case 26:
            this.usedMarginTiers_.AddEntriesFrom(input, DynamicLeverageSettingsProto._repeated_usedMarginTiers_codec);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
