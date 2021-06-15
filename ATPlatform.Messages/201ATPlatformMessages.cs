// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetSmartBridgeSettingsSetsNotificationProto
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
  public sealed class GetSmartBridgeSettingsSetsNotificationProto : 
    IMessage<GetSmartBridgeSettingsSetsNotificationProto>,
    IMessage,
    IEquatable<GetSmartBridgeSettingsSetsNotificationProto>,
    IDeepCloneable<GetSmartBridgeSettingsSetsNotificationProto>
  {
    private static readonly MessageParser<GetSmartBridgeSettingsSetsNotificationProto> _parser = new MessageParser<GetSmartBridgeSettingsSetsNotificationProto>((Func<GetSmartBridgeSettingsSetsNotificationProto>) (() => new GetSmartBridgeSettingsSetsNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int SmartBridgeSettingsSetsFieldNumber = 1;
    private static readonly FieldCodec<SmartBridgeSettingsSetProto> _repeated_smartBridgeSettingsSets_codec = FieldCodec.ForMessage<SmartBridgeSettingsSetProto>(10U, SmartBridgeSettingsSetProto.Parser);
    private readonly RepeatedField<SmartBridgeSettingsSetProto> smartBridgeSettingsSets_ = new RepeatedField<SmartBridgeSettingsSetProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetSmartBridgeSettingsSetsNotificationProto> Parser => GetSmartBridgeSettingsSetsNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[201];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetSmartBridgeSettingsSetsNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetSmartBridgeSettingsSetsNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetSmartBridgeSettingsSetsNotificationProto(
      GetSmartBridgeSettingsSetsNotificationProto other)
      : this()
    {
      this.smartBridgeSettingsSets_ = other.smartBridgeSettingsSets_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetSmartBridgeSettingsSetsNotificationProto Clone() => new GetSmartBridgeSettingsSetsNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<SmartBridgeSettingsSetProto> SmartBridgeSettingsSets => this.smartBridgeSettingsSets_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetSmartBridgeSettingsSetsNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetSmartBridgeSettingsSetsNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.smartBridgeSettingsSets_.Equals(other.smartBridgeSettingsSets_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.smartBridgeSettingsSets_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.smartBridgeSettingsSets_.WriteTo(output, GetSmartBridgeSettingsSetsNotificationProto._repeated_smartBridgeSettingsSets_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.smartBridgeSettingsSets_.CalculateSize(GetSmartBridgeSettingsSetsNotificationProto._repeated_smartBridgeSettingsSets_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetSmartBridgeSettingsSetsNotificationProto other)
    {
      if (other == null)
        return;
      this.smartBridgeSettingsSets_.Add((IEnumerable<SmartBridgeSettingsSetProto>) other.smartBridgeSettingsSets_);
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
          this.smartBridgeSettingsSets_.AddEntriesFrom(input, GetSmartBridgeSettingsSetsNotificationProto._repeated_smartBridgeSettingsSets_codec);
      }
    }
  }
}
