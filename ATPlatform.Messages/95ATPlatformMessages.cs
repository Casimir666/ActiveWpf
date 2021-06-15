// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetLastIdRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class GetLastIdRequestProto : 
    IMessage<GetLastIdRequestProto>,
    IMessage,
    IEquatable<GetLastIdRequestProto>,
    IDeepCloneable<GetLastIdRequestProto>
  {
    private static readonly MessageParser<GetLastIdRequestProto> _parser = new MessageParser<GetLastIdRequestProto>((Func<GetLastIdRequestProto>) (() => new GetLastIdRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int LastIdTypeFieldNumber = 1;
    private LastIdTypeProto lastIdType_;

    [DebuggerNonUserCode]
    public static MessageParser<GetLastIdRequestProto> Parser => GetLastIdRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[85];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetLastIdRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public GetLastIdRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public GetLastIdRequestProto(GetLastIdRequestProto other)
      : this()
    {
      this.lastIdType_ = other.lastIdType_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetLastIdRequestProto Clone() => new GetLastIdRequestProto(this);

    [DebuggerNonUserCode]
    public LastIdTypeProto LastIdType
    {
      get => this.lastIdType_;
      set => this.lastIdType_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetLastIdRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(GetLastIdRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.LastIdType == other.LastIdType && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.LastIdType != LastIdTypeProto.Undefined)
        num ^= this.LastIdType.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.LastIdType != LastIdTypeProto.Undefined)
      {
        output.WriteRawTag((byte) 8);
        output.WriteEnum((int) this.LastIdType);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.LastIdType != LastIdTypeProto.Undefined)
        num += 1 + CodedOutputStream.ComputeEnumSize((int) this.LastIdType);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetLastIdRequestProto other)
    {
      if (other == null)
        return;
      if (other.LastIdType != LastIdTypeProto.Undefined)
        this.LastIdType = other.LastIdType;
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
          this.LastIdType = (LastIdTypeProto) input.ReadEnum();
      }
    }
  }
}
