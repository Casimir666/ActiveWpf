// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.MarkupSettingsSetProto
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
  public sealed class MarkupSettingsSetProto : 
    IMessage<MarkupSettingsSetProto>,
    IMessage,
    IEquatable<MarkupSettingsSetProto>,
    IDeepCloneable<MarkupSettingsSetProto>
  {
    private static readonly MessageParser<MarkupSettingsSetProto> _parser = new MessageParser<MarkupSettingsSetProto>((Func<MarkupSettingsSetProto>) (() => new MarkupSettingsSetProto()));
    private UnknownFieldSet _unknownFields;
    public const int IdFieldNumber = 1;
    private int id_;
    public const int NameFieldNumber = 2;
    private string name_ = "";
    public const int IsTemplateFieldNumber = 3;
    private bool isTemplate_;
    public const int MarkupSettingsFieldNumber = 4;
    private static readonly FieldCodec<MarkupSettingsProto> _repeated_markupSettings_codec = FieldCodec.ForMessage<MarkupSettingsProto>(34U, MarkupSettingsProto.Parser);
    private readonly RepeatedField<MarkupSettingsProto> markupSettings_ = new RepeatedField<MarkupSettingsProto>();

    [DebuggerNonUserCode]
    public static MessageParser<MarkupSettingsSetProto> Parser => MarkupSettingsSetProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[76];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => MarkupSettingsSetProto.Descriptor;

    [DebuggerNonUserCode]
    public MarkupSettingsSetProto()
    {
    }

    [DebuggerNonUserCode]
    public MarkupSettingsSetProto(MarkupSettingsSetProto other)
      : this()
    {
      this.id_ = other.id_;
      this.name_ = other.name_;
      this.isTemplate_ = other.isTemplate_;
      this.markupSettings_ = other.markupSettings_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public MarkupSettingsSetProto Clone() => new MarkupSettingsSetProto(this);

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
    public RepeatedField<MarkupSettingsProto> MarkupSettings => this.markupSettings_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as MarkupSettingsSetProto);

    [DebuggerNonUserCode]
    public bool Equals(MarkupSettingsSetProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.Id == other.Id && !(this.Name != other.Name) && (this.IsTemplate == other.IsTemplate && this.markupSettings_.Equals(other.markupSettings_)) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
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
      int num2 = num1 ^ this.markupSettings_.GetHashCode();
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
      this.markupSettings_.WriteTo(output, MarkupSettingsSetProto._repeated_markupSettings_codec);
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
      int num2 = num1 + this.markupSettings_.CalculateSize(MarkupSettingsSetProto._repeated_markupSettings_codec);
      if (this._unknownFields != null)
        num2 += this._unknownFields.CalculateSize();
      return num2;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(MarkupSettingsSetProto other)
    {
      if (other == null)
        return;
      if (other.Id != 0)
        this.Id = other.Id;
      if (other.Name.Length != 0)
        this.Name = other.Name;
      if (other.IsTemplate)
        this.IsTemplate = other.IsTemplate;
      this.markupSettings_.Add((IEnumerable<MarkupSettingsProto>) other.markupSettings_);
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
            this.markupSettings_.AddEntriesFrom(input, MarkupSettingsSetProto._repeated_markupSettings_codec);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
