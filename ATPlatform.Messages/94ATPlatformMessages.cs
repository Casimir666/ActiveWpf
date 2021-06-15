// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.DynamicLeverageSettingsNotificationProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class DynamicLeverageSettingsNotificationProto : 
    IMessage<DynamicLeverageSettingsNotificationProto>,
    IMessage,
    IEquatable<DynamicLeverageSettingsNotificationProto>,
    IDeepCloneable<DynamicLeverageSettingsNotificationProto>
  {
    private static readonly MessageParser<DynamicLeverageSettingsNotificationProto> _parser = new MessageParser<DynamicLeverageSettingsNotificationProto>((Func<DynamicLeverageSettingsNotificationProto>) (() => new DynamicLeverageSettingsNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int DynamicLeverageSettingsFieldNumber = 1;
    private DynamicLeverageSettingsProto dynamicLeverageSettings_;

    [DebuggerNonUserCode]
    public static MessageParser<DynamicLeverageSettingsNotificationProto> Parser => DynamicLeverageSettingsNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[84];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => DynamicLeverageSettingsNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public DynamicLeverageSettingsNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public DynamicLeverageSettingsNotificationProto(DynamicLeverageSettingsNotificationProto other)
      : this()
    {
      this.dynamicLeverageSettings_ = other.dynamicLeverageSettings_ != null ? other.dynamicLeverageSettings_.Clone() : (DynamicLeverageSettingsProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public DynamicLeverageSettingsNotificationProto Clone() => new DynamicLeverageSettingsNotificationProto(this);

    [DebuggerNonUserCode]
    public DynamicLeverageSettingsProto DynamicLeverageSettings
    {
      get => this.dynamicLeverageSettings_;
      set => this.dynamicLeverageSettings_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as DynamicLeverageSettingsNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(DynamicLeverageSettingsNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return object.Equals((object) this.DynamicLeverageSettings, (object) other.DynamicLeverageSettings) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.dynamicLeverageSettings_ != null)
        num ^= this.DynamicLeverageSettings.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.dynamicLeverageSettings_ != null)
      {
        output.WriteRawTag((byte) 10);
        output.WriteMessage((IMessage) this.DynamicLeverageSettings);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.dynamicLeverageSettings_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.DynamicLeverageSettings);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(DynamicLeverageSettingsNotificationProto other)
    {
      if (other == null)
        return;
      if (other.dynamicLeverageSettings_ != null)
      {
        if (this.dynamicLeverageSettings_ == null)
          this.DynamicLeverageSettings = new DynamicLeverageSettingsProto();
        this.DynamicLeverageSettings.MergeFrom(other.DynamicLeverageSettings);
      }
      this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
    }

    [DebuggerNonUserCode]
    public void MergeFrom(CodedInputStream input)
    {
      uint num;
      while ((num = input.ReadTag()) != 0U)
      {
        if (num != 10U)
        {
          this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
        }
        else
        {
          if (this.dynamicLeverageSettings_ == null)
            this.DynamicLeverageSettings = new DynamicLeverageSettingsProto();
          input.ReadMessage((IMessage) this.DynamicLeverageSettings);
        }
      }
    }
  }
}
