﻿// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetClientMessageRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class GetClientMessageRequestProto : 
    IMessage<GetClientMessageRequestProto>,
    IMessage,
    IEquatable<GetClientMessageRequestProto>,
    IDeepCloneable<GetClientMessageRequestProto>
  {
    private static readonly MessageParser<GetClientMessageRequestProto> _parser = new MessageParser<GetClientMessageRequestProto>((Func<GetClientMessageRequestProto>) (() => new GetClientMessageRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int IdFieldNumber = 1;
    private int id_;

    [DebuggerNonUserCode]
    public static MessageParser<GetClientMessageRequestProto> Parser => GetClientMessageRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[229];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetClientMessageRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public GetClientMessageRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public GetClientMessageRequestProto(GetClientMessageRequestProto other)
      : this()
    {
      this.id_ = other.id_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetClientMessageRequestProto Clone() => new GetClientMessageRequestProto(this);

    [DebuggerNonUserCode]
    public int Id
    {
      get => this.id_;
      set => this.id_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetClientMessageRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(GetClientMessageRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.Id == other.Id && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.Id != 0)
        num ^= this.Id.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
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
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.Id != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetClientMessageRequestProto other)
    {
      if (other == null)
        return;
      if (other.Id != 0)
        this.Id = other.Id;
      this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
    }

    [DebuggerNonUserCode]
    public void MergeFrom(CodedInputStream input)
    {
      uint num;
      while ((num = input.ReadTag()) != 0U)
      {
        if (num != 8U)
          this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
        else
          this.Id = input.ReadInt32();
      }
    }
  }
}
