// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetSymbolsMarkupSettingsByMarkupSetNotificationProto
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
  public sealed class GetSymbolsMarkupSettingsByMarkupSetNotificationProto : 
    IMessage<GetSymbolsMarkupSettingsByMarkupSetNotificationProto>,
    IMessage,
    IEquatable<GetSymbolsMarkupSettingsByMarkupSetNotificationProto>,
    IDeepCloneable<GetSymbolsMarkupSettingsByMarkupSetNotificationProto>
  {
    private static readonly MessageParser<GetSymbolsMarkupSettingsByMarkupSetNotificationProto> _parser = new MessageParser<GetSymbolsMarkupSettingsByMarkupSetNotificationProto>((Func<GetSymbolsMarkupSettingsByMarkupSetNotificationProto>) (() => new GetSymbolsMarkupSettingsByMarkupSetNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int MarkupSetNameFieldNumber = 1;
    private string markupSetName_ = "";
    public const int SymbolsMarkupSettingsFieldNumber = 2;
    private static readonly MapField<string, MarkupSettingsProto>.Codec _map_symbolsMarkupSettings_codec = new MapField<string, MarkupSettingsProto>.Codec(FieldCodec.ForString(10U), FieldCodec.ForMessage<MarkupSettingsProto>(18U, MarkupSettingsProto.Parser), 18U);
    private readonly MapField<string, MarkupSettingsProto> symbolsMarkupSettings_ = new MapField<string, MarkupSettingsProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetSymbolsMarkupSettingsByMarkupSetNotificationProto> Parser => GetSymbolsMarkupSettingsByMarkupSetNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[113];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetSymbolsMarkupSettingsByMarkupSetNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetSymbolsMarkupSettingsByMarkupSetNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetSymbolsMarkupSettingsByMarkupSetNotificationProto(
      GetSymbolsMarkupSettingsByMarkupSetNotificationProto other)
      : this()
    {
      this.markupSetName_ = other.markupSetName_;
      this.symbolsMarkupSettings_ = other.symbolsMarkupSettings_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetSymbolsMarkupSettingsByMarkupSetNotificationProto Clone() => new GetSymbolsMarkupSettingsByMarkupSetNotificationProto(this);

    [DebuggerNonUserCode]
    public string MarkupSetName
    {
      get => this.markupSetName_;
      set => this.markupSetName_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public MapField<string, MarkupSettingsProto> SymbolsMarkupSettings => this.symbolsMarkupSettings_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetSymbolsMarkupSettingsByMarkupSetNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(
      GetSymbolsMarkupSettingsByMarkupSetNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return !(this.MarkupSetName != other.MarkupSetName) && this.SymbolsMarkupSettings.Equals(other.SymbolsMarkupSettings) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      if (this.MarkupSetName.Length != 0)
        num1 ^= this.MarkupSetName.GetHashCode();
      int num2 = num1 ^ this.SymbolsMarkupSettings.GetHashCode();
      if (this._unknownFields != null)
        num2 ^= this._unknownFields.GetHashCode();
      return num2;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.MarkupSetName.Length != 0)
      {
        output.WriteRawTag((byte) 10);
        output.WriteString(this.MarkupSetName);
      }
      this.symbolsMarkupSettings_.WriteTo(output, GetSymbolsMarkupSettingsByMarkupSetNotificationProto._map_symbolsMarkupSettings_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num1 = 0;
      if (this.MarkupSetName.Length != 0)
        num1 += 1 + CodedOutputStream.ComputeStringSize(this.MarkupSetName);
      int num2 = num1 + this.symbolsMarkupSettings_.CalculateSize(GetSymbolsMarkupSettingsByMarkupSetNotificationProto._map_symbolsMarkupSettings_codec);
      if (this._unknownFields != null)
        num2 += this._unknownFields.CalculateSize();
      return num2;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(
      GetSymbolsMarkupSettingsByMarkupSetNotificationProto other)
    {
      if (other == null)
        return;
      if (other.MarkupSetName.Length != 0)
        this.MarkupSetName = other.MarkupSetName;
      this.symbolsMarkupSettings_.Add((IDictionary<string, MarkupSettingsProto>) other.symbolsMarkupSettings_);
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
            this.MarkupSetName = input.ReadString();
            continue;
          case 18:
            this.symbolsMarkupSettings_.AddEntriesFrom(input, GetSymbolsMarkupSettingsByMarkupSetNotificationProto._map_symbolsMarkupSettings_codec);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
