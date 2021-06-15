// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetSymbolsHedgeSettingsByHedgeSetNotificationProto
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
  public sealed class GetSymbolsHedgeSettingsByHedgeSetNotificationProto : 
    IMessage<GetSymbolsHedgeSettingsByHedgeSetNotificationProto>,
    IMessage,
    IEquatable<GetSymbolsHedgeSettingsByHedgeSetNotificationProto>,
    IDeepCloneable<GetSymbolsHedgeSettingsByHedgeSetNotificationProto>
  {
    private static readonly MessageParser<GetSymbolsHedgeSettingsByHedgeSetNotificationProto> _parser = new MessageParser<GetSymbolsHedgeSettingsByHedgeSetNotificationProto>((Func<GetSymbolsHedgeSettingsByHedgeSetNotificationProto>) (() => new GetSymbolsHedgeSettingsByHedgeSetNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int HedgeSetNameFieldNumber = 1;
    private string hedgeSetName_ = "";
    public const int SymbolsHedgeSettingsFieldNumber = 2;
    private static readonly MapField<string, HedgeSettingsProto>.Codec _map_symbolsHedgeSettings_codec = new MapField<string, HedgeSettingsProto>.Codec(FieldCodec.ForString(10U), FieldCodec.ForMessage<HedgeSettingsProto>(18U, HedgeSettingsProto.Parser), 18U);
    private readonly MapField<string, HedgeSettingsProto> symbolsHedgeSettings_ = new MapField<string, HedgeSettingsProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetSymbolsHedgeSettingsByHedgeSetNotificationProto> Parser => GetSymbolsHedgeSettingsByHedgeSetNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[115];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetSymbolsHedgeSettingsByHedgeSetNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetSymbolsHedgeSettingsByHedgeSetNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetSymbolsHedgeSettingsByHedgeSetNotificationProto(
      GetSymbolsHedgeSettingsByHedgeSetNotificationProto other)
      : this()
    {
      this.hedgeSetName_ = other.hedgeSetName_;
      this.symbolsHedgeSettings_ = other.symbolsHedgeSettings_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetSymbolsHedgeSettingsByHedgeSetNotificationProto Clone() => new GetSymbolsHedgeSettingsByHedgeSetNotificationProto(this);

    [DebuggerNonUserCode]
    public string HedgeSetName
    {
      get => this.hedgeSetName_;
      set => this.hedgeSetName_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public MapField<string, HedgeSettingsProto> SymbolsHedgeSettings => this.symbolsHedgeSettings_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetSymbolsHedgeSettingsByHedgeSetNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(
      GetSymbolsHedgeSettingsByHedgeSetNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return !(this.HedgeSetName != other.HedgeSetName) && this.SymbolsHedgeSettings.Equals(other.SymbolsHedgeSettings) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      if (this.HedgeSetName.Length != 0)
        num1 ^= this.HedgeSetName.GetHashCode();
      int num2 = num1 ^ this.SymbolsHedgeSettings.GetHashCode();
      if (this._unknownFields != null)
        num2 ^= this._unknownFields.GetHashCode();
      return num2;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.HedgeSetName.Length != 0)
      {
        output.WriteRawTag((byte) 10);
        output.WriteString(this.HedgeSetName);
      }
      this.symbolsHedgeSettings_.WriteTo(output, GetSymbolsHedgeSettingsByHedgeSetNotificationProto._map_symbolsHedgeSettings_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num1 = 0;
      if (this.HedgeSetName.Length != 0)
        num1 += 1 + CodedOutputStream.ComputeStringSize(this.HedgeSetName);
      int num2 = num1 + this.symbolsHedgeSettings_.CalculateSize(GetSymbolsHedgeSettingsByHedgeSetNotificationProto._map_symbolsHedgeSettings_codec);
      if (this._unknownFields != null)
        num2 += this._unknownFields.CalculateSize();
      return num2;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(
      GetSymbolsHedgeSettingsByHedgeSetNotificationProto other)
    {
      if (other == null)
        return;
      if (other.HedgeSetName.Length != 0)
        this.HedgeSetName = other.HedgeSetName;
      this.symbolsHedgeSettings_.Add((IDictionary<string, HedgeSettingsProto>) other.symbolsHedgeSettings_);
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
            this.HedgeSetName = input.ReadString();
            continue;
          case 18:
            this.symbolsHedgeSettings_.AddEntriesFrom(input, GetSymbolsHedgeSettingsByHedgeSetNotificationProto._map_symbolsHedgeSettings_codec);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
