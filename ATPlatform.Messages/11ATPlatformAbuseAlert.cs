// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.AbuseAlert.AbuseAlertRuleSettingKeyValueProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL.AbuseAlert
{
  public sealed class AbuseAlertRuleSettingKeyValueProto : 
    IMessage<AbuseAlertRuleSettingKeyValueProto>,
    IMessage,
    IEquatable<AbuseAlertRuleSettingKeyValueProto>,
    IDeepCloneable<AbuseAlertRuleSettingKeyValueProto>
  {
    private static readonly MessageParser<AbuseAlertRuleSettingKeyValueProto> _parser = new MessageParser<AbuseAlertRuleSettingKeyValueProto>((Func<AbuseAlertRuleSettingKeyValueProto>) (() => new AbuseAlertRuleSettingKeyValueProto()));
    private UnknownFieldSet _unknownFields;
    public const int KeyFieldNumber = 1;
    private string key_ = "";
    public const int ValueFieldNumber = 2;
    private string value_ = "";
    public const int TypeFieldNumber = 3;
    private string type_ = "";
    public const int DescriptionFieldNumber = 4;
    private string description_ = "";

    [DebuggerNonUserCode]
    public static MessageParser<AbuseAlertRuleSettingKeyValueProto> Parser => AbuseAlertRuleSettingKeyValueProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformAbuseAlertReflection.Descriptor.MessageTypes[10];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => AbuseAlertRuleSettingKeyValueProto.Descriptor;

    [DebuggerNonUserCode]
    public AbuseAlertRuleSettingKeyValueProto()
    {
    }

    [DebuggerNonUserCode]
    public AbuseAlertRuleSettingKeyValueProto(AbuseAlertRuleSettingKeyValueProto other)
      : this()
    {
      this.key_ = other.key_;
      this.value_ = other.value_;
      this.type_ = other.type_;
      this.description_ = other.description_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public AbuseAlertRuleSettingKeyValueProto Clone() => new AbuseAlertRuleSettingKeyValueProto(this);

    [DebuggerNonUserCode]
    public string Key
    {
      get => this.key_;
      set => this.key_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public string Value
    {
      get => this.value_;
      set => this.value_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public string Type
    {
      get => this.type_;
      set => this.type_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public string Description
    {
      get => this.description_;
      set => this.description_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as AbuseAlertRuleSettingKeyValueProto);

    [DebuggerNonUserCode]
    public bool Equals(AbuseAlertRuleSettingKeyValueProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return !(this.Key != other.Key) && !(this.Value != other.Value) && (!(this.Type != other.Type) && !(this.Description != other.Description)) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.Key.Length != 0)
        num ^= this.Key.GetHashCode();
      if (this.Value.Length != 0)
        num ^= this.Value.GetHashCode();
      if (this.Type.Length != 0)
        num ^= this.Type.GetHashCode();
      if (this.Description.Length != 0)
        num ^= this.Description.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.Key.Length != 0)
      {
        output.WriteRawTag((byte) 10);
        output.WriteString(this.Key);
      }
      if (this.Value.Length != 0)
      {
        output.WriteRawTag((byte) 18);
        output.WriteString(this.Value);
      }
      if (this.Type.Length != 0)
      {
        output.WriteRawTag((byte) 26);
        output.WriteString(this.Type);
      }
      if (this.Description.Length != 0)
      {
        output.WriteRawTag((byte) 34);
        output.WriteString(this.Description);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.Key.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Key);
      if (this.Value.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Value);
      if (this.Type.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Type);
      if (this.Description.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Description);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(AbuseAlertRuleSettingKeyValueProto other)
    {
      if (other == null)
        return;
      if (other.Key.Length != 0)
        this.Key = other.Key;
      if (other.Value.Length != 0)
        this.Value = other.Value;
      if (other.Type.Length != 0)
        this.Type = other.Type;
      if (other.Description.Length != 0)
        this.Description = other.Description;
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
            this.Key = input.ReadString();
            continue;
          case 18:
            this.Value = input.ReadString();
            continue;
          case 26:
            this.Type = input.ReadString();
            continue;
          case 34:
            this.Description = input.ReadString();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
