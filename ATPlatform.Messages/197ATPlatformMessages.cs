// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.HedgeSettingsSetProto
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
  public sealed class HedgeSettingsSetProto : 
    IMessage<HedgeSettingsSetProto>,
    IMessage,
    IEquatable<HedgeSettingsSetProto>,
    IDeepCloneable<HedgeSettingsSetProto>
  {
    private static readonly MessageParser<HedgeSettingsSetProto> _parser = new MessageParser<HedgeSettingsSetProto>((Func<HedgeSettingsSetProto>) (() => new HedgeSettingsSetProto()));
    private UnknownFieldSet _unknownFields;
    public const int IdFieldNumber = 1;
    private int id_;
    public const int NameFieldNumber = 2;
    private string name_ = "";
    public const int IsTemplateFieldNumber = 3;
    private bool isTemplate_;
    public const int HedgeSettingsFieldNumber = 4;
    private static readonly FieldCodec<HedgeSettingsProto> _repeated_hedgeSettings_codec = FieldCodec.ForMessage<HedgeSettingsProto>(34U, HedgeSettingsProto.Parser);
    private readonly RepeatedField<HedgeSettingsProto> hedgeSettings_ = new RepeatedField<HedgeSettingsProto>();

    [DebuggerNonUserCode]
    public static MessageParser<HedgeSettingsSetProto> Parser => HedgeSettingsSetProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[196];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => HedgeSettingsSetProto.Descriptor;

    [DebuggerNonUserCode]
    public HedgeSettingsSetProto()
    {
    }

    [DebuggerNonUserCode]
    public HedgeSettingsSetProto(HedgeSettingsSetProto other)
      : this()
    {
      this.id_ = other.id_;
      this.name_ = other.name_;
      this.isTemplate_ = other.isTemplate_;
      this.hedgeSettings_ = other.hedgeSettings_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public HedgeSettingsSetProto Clone() => new HedgeSettingsSetProto(this);

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
    public bool IsTemplate
    {
      get => this.isTemplate_;
      set => this.isTemplate_ = value;
    }

    [DebuggerNonUserCode]
    public RepeatedField<HedgeSettingsProto> HedgeSettings => this.hedgeSettings_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as HedgeSettingsSetProto);

    [DebuggerNonUserCode]
    public bool Equals(HedgeSettingsSetProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.Id == other.Id && !(this.Name != other.Name) && (this.IsTemplate == other.IsTemplate && this.hedgeSettings_.Equals(other.hedgeSettings_)) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      if (this.Id != 0)
        num1 ^= this.Id.GetHashCode();
      if (this.Name.Length != 0)
        num1 ^= this.Name.GetHashCode();
      if (this.IsTemplate)
        num1 ^= this.IsTemplate.GetHashCode();
      int num2 = num1 ^ this.hedgeSettings_.GetHashCode();
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
      if (this.IsTemplate)
      {
        output.WriteRawTag((byte) 24);
        output.WriteBool(this.IsTemplate);
      }
      this.hedgeSettings_.WriteTo(output, HedgeSettingsSetProto._repeated_hedgeSettings_codec);
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
      if (this.IsTemplate)
        num1 += 2;
      int num2 = num1 + this.hedgeSettings_.CalculateSize(HedgeSettingsSetProto._repeated_hedgeSettings_codec);
      if (this._unknownFields != null)
        num2 += this._unknownFields.CalculateSize();
      return num2;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(HedgeSettingsSetProto other)
    {
      if (other == null)
        return;
      if (other.Id != 0)
        this.Id = other.Id;
      if (other.Name.Length != 0)
        this.Name = other.Name;
      if (other.IsTemplate)
        this.IsTemplate = other.IsTemplate;
      this.hedgeSettings_.Add((IEnumerable<HedgeSettingsProto>) other.hedgeSettings_);
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
          case 24:
            this.IsTemplate = input.ReadBool();
            continue;
          case 34:
            this.hedgeSettings_.AddEntriesFrom(input, HedgeSettingsSetProto._repeated_hedgeSettings_codec);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
