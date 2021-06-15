// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetSymbolGroupsNotificationProto
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
  public sealed class GetSymbolGroupsNotificationProto : 
    IMessage<GetSymbolGroupsNotificationProto>,
    IMessage,
    IEquatable<GetSymbolGroupsNotificationProto>,
    IDeepCloneable<GetSymbolGroupsNotificationProto>
  {
    private static readonly MessageParser<GetSymbolGroupsNotificationProto> _parser = new MessageParser<GetSymbolGroupsNotificationProto>((Func<GetSymbolGroupsNotificationProto>) (() => new GetSymbolGroupsNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int GroupsFieldNumber = 1;
    private static readonly FieldCodec<SymbolGroupProto> _repeated_groups_codec = FieldCodec.ForMessage<SymbolGroupProto>(10U, SymbolGroupProto.Parser);
    private readonly RepeatedField<SymbolGroupProto> groups_ = new RepeatedField<SymbolGroupProto>();

    [DebuggerNonUserCode]
    public static MessageParser<GetSymbolGroupsNotificationProto> Parser => GetSymbolGroupsNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[37];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetSymbolGroupsNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetSymbolGroupsNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetSymbolGroupsNotificationProto(GetSymbolGroupsNotificationProto other)
      : this()
    {
      this.groups_ = other.groups_.Clone();
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetSymbolGroupsNotificationProto Clone() => new GetSymbolGroupsNotificationProto(this);

    [DebuggerNonUserCode]
    public RepeatedField<SymbolGroupProto> Groups => this.groups_;

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetSymbolGroupsNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetSymbolGroupsNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.groups_.Equals(other.groups_) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1 ^ this.groups_.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      this.groups_.WriteTo(output, GetSymbolGroupsNotificationProto._repeated_groups_codec);
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0 + this.groups_.CalculateSize(GetSymbolGroupsNotificationProto._repeated_groups_codec);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetSymbolGroupsNotificationProto other)
    {
      if (other == null)
        return;
      this.groups_.Add((IEnumerable<SymbolGroupProto>) other.groups_);
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
          this.groups_.AddEntriesFrom(input, GetSymbolGroupsNotificationProto._repeated_groups_codec);
      }
    }
  }
}
