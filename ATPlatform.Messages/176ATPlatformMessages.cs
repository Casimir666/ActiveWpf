// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetAdministratorsNotificationProto
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
  public sealed class GetAdministratorsNotificationProto : 
    IMessage<GetAdministratorsNotificationProto>,
    IMessage,
    IEquatable<GetAdministratorsNotificationProto>,
    IDeepCloneable<GetAdministratorsNotificationProto>
  {
    private static readonly MessageParser<GetAdministratorsNotificationProto> _parser = new MessageParser<GetAdministratorsNotificationProto>((Func<GetAdministratorsNotificationProto>) (() => new GetAdministratorsNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int AdministratorsFieldNumber = 1;
    private static readonly FieldCodec<AdministratorProto> _repeated_administrators_codec = FieldCodec.ForMessage<AdministratorProto>(10U, AdministratorProto.Parser);
    private readonly RepeatedField<AdministratorProto> administrators_ = new RepeatedField<AdministratorProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetAdministratorsNotificationProto> Parser => GetAdministratorsNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[173];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetAdministratorsNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetAdministratorsNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetAdministratorsNotificationProto(GetAdministratorsNotificationProto other)
      : this()
    {
      this.administrators_ = other.administrators_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetAdministratorsNotificationProto Clone() => new GetAdministratorsNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<AdministratorProto> Administrators => this.administrators_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetAdministratorsNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetAdministratorsNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.administrators_.Equals(other.administrators_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.administrators_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.administrators_.WriteTo(output, GetAdministratorsNotificationProto._repeated_administrators_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.administrators_.CalculateSize(GetAdministratorsNotificationProto._repeated_administrators_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetAdministratorsNotificationProto other)
    {
      if (other == null)
        return;
      this.administrators_.Add((IEnumerable<AdministratorProto>) other.administrators_);
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
          this.administrators_.AddEntriesFrom(input, GetAdministratorsNotificationProto._repeated_administrators_codec);
      }
    }
  }
}
