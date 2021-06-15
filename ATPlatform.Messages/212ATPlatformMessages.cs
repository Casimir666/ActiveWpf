// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetATServerConfigurationNotificationProto
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
  public sealed class GetATServerConfigurationNotificationProto : 
    IMessage<GetATServerConfigurationNotificationProto>,
    IMessage,
    IEquatable<GetATServerConfigurationNotificationProto>,
    IDeepCloneable<GetATServerConfigurationNotificationProto>
  {
    private static readonly MessageParser<GetATServerConfigurationNotificationProto> _parser = new MessageParser<GetATServerConfigurationNotificationProto>((Func<GetATServerConfigurationNotificationProto>) (() => new GetATServerConfigurationNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int AtserverConfigurationsProtoFieldNumber = 1;
    private static readonly FieldCodec<ATServerConfigurationProto> _repeated_atserverConfigurationsProto_codec = FieldCodec.ForMessage<ATServerConfigurationProto>(10U, ATServerConfigurationProto.Parser);
    private readonly RepeatedField<ATServerConfigurationProto> atserverConfigurationsProto_ = new RepeatedField<ATServerConfigurationProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetATServerConfigurationNotificationProto> Parser => GetATServerConfigurationNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[212];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetATServerConfigurationNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetATServerConfigurationNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetATServerConfigurationNotificationProto(GetATServerConfigurationNotificationProto other)
      : this()
    {
      this.atserverConfigurationsProto_ = other.atserverConfigurationsProto_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetATServerConfigurationNotificationProto Clone() => new GetATServerConfigurationNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<ATServerConfigurationProto> AtserverConfigurationsProto => this.atserverConfigurationsProto_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetATServerConfigurationNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetATServerConfigurationNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.atserverConfigurationsProto_.Equals(other.atserverConfigurationsProto_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.atserverConfigurationsProto_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.atserverConfigurationsProto_.WriteTo(output, GetATServerConfigurationNotificationProto._repeated_atserverConfigurationsProto_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.atserverConfigurationsProto_.CalculateSize(GetATServerConfigurationNotificationProto._repeated_atserverConfigurationsProto_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetATServerConfigurationNotificationProto other)
    {
      if (other == null)
        return;
      this.atserverConfigurationsProto_.Add((IEnumerable<ATServerConfigurationProto>) other.atserverConfigurationsProto_);
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
          this.atserverConfigurationsProto_.AddEntriesFrom(input, GetATServerConfigurationNotificationProto._repeated_atserverConfigurationsProto_codec);
      }
    }
  }
}
