// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetDynamicLeverageSettingsNotificationProto
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
  public sealed class GetDynamicLeverageSettingsNotificationProto : 
    IMessage<GetDynamicLeverageSettingsNotificationProto>,
    IMessage,
    IEquatable<GetDynamicLeverageSettingsNotificationProto>,
    IDeepCloneable<GetDynamicLeverageSettingsNotificationProto>
  {
    private static readonly MessageParser<GetDynamicLeverageSettingsNotificationProto> _parser = new MessageParser<GetDynamicLeverageSettingsNotificationProto>((Func<GetDynamicLeverageSettingsNotificationProto>) (() => new GetDynamicLeverageSettingsNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int DynamicLeverageSettingsFieldNumber = 1;
    private static readonly FieldCodec<DynamicLeverageSettingsProto> _repeated_dynamicLeverageSettings_codec = FieldCodec.ForMessage<DynamicLeverageSettingsProto>(10U, DynamicLeverageSettingsProto.Parser);
    private readonly RepeatedField<DynamicLeverageSettingsProto> dynamicLeverageSettings_ = new RepeatedField<DynamicLeverageSettingsProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetDynamicLeverageSettingsNotificationProto> Parser => GetDynamicLeverageSettingsNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[82];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetDynamicLeverageSettingsNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetDynamicLeverageSettingsNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetDynamicLeverageSettingsNotificationProto(
      GetDynamicLeverageSettingsNotificationProto other)
      : this()
    {
      this.dynamicLeverageSettings_ = other.dynamicLeverageSettings_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetDynamicLeverageSettingsNotificationProto Clone() => new GetDynamicLeverageSettingsNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<DynamicLeverageSettingsProto> DynamicLeverageSettings => this.dynamicLeverageSettings_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetDynamicLeverageSettingsNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetDynamicLeverageSettingsNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.dynamicLeverageSettings_.Equals(other.dynamicLeverageSettings_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.dynamicLeverageSettings_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.dynamicLeverageSettings_.WriteTo(output, GetDynamicLeverageSettingsNotificationProto._repeated_dynamicLeverageSettings_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.dynamicLeverageSettings_.CalculateSize(GetDynamicLeverageSettingsNotificationProto._repeated_dynamicLeverageSettings_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetDynamicLeverageSettingsNotificationProto other)
    {
      if (other == null)
        return;
      this.dynamicLeverageSettings_.Add((IEnumerable<DynamicLeverageSettingsProto>) other.dynamicLeverageSettings_);
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
          this.dynamicLeverageSettings_.AddEntriesFrom(input, GetDynamicLeverageSettingsNotificationProto._repeated_dynamicLeverageSettings_codec);
      }
    }
  }
}
