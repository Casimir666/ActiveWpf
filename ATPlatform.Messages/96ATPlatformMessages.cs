// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetLastIdNotificationProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class GetLastIdNotificationProto : 
    IMessage<GetLastIdNotificationProto>,
    IMessage,
    IEquatable<GetLastIdNotificationProto>,
    IDeepCloneable<GetLastIdNotificationProto>
  {
    private static readonly MessageParser<GetLastIdNotificationProto> _parser = new MessageParser<GetLastIdNotificationProto>((Func<GetLastIdNotificationProto>) (() => new GetLastIdNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int LastIdTypeFieldNumber = 1;
    private LastIdTypeProto lastIdType_;
    public const int LastIdFieldNumber = 2;
    private long lastId_;

    [DebuggerNonUserCode]
    public static MessageParser<GetLastIdNotificationProto> Parser => GetLastIdNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[86];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetLastIdNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetLastIdNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetLastIdNotificationProto(GetLastIdNotificationProto other)
      : this()
    {
      this.lastIdType_ = other.lastIdType_;
      this.lastId_ = other.lastId_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetLastIdNotificationProto Clone() => new GetLastIdNotificationProto(this);

    [DebuggerNonUserCode]
    public LastIdTypeProto LastIdType
    {
      get => this.lastIdType_;
      set => this.lastIdType_ = value;
    }

    [DebuggerNonUserCode]
    public long LastId
    {
      get => this.lastId_;
      set => this.lastId_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetLastIdNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetLastIdNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.LastIdType == other.LastIdType && this.LastId == other.LastId && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.LastIdType != LastIdTypeProto.Undefined)
        num ^= this.LastIdType.GetHashCode();
      if (this.LastId != 0L)
        num ^= this.LastId.GetHashCode();
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
      if (this.LastId != 0L)
      {
        output.WriteRawTag((byte) 16);
        output.WriteInt64(this.LastId);
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
      if (this.LastId != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.LastId);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetLastIdNotificationProto other)
    {
      if (other == null)
        return;
      if (other.LastIdType != LastIdTypeProto.Undefined)
        this.LastIdType = other.LastIdType;
      if (other.LastId != 0L)
        this.LastId = other.LastId;
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
          case 8:
            this.LastIdType = (LastIdTypeProto) input.ReadEnum();
            continue;
          case 16:
            this.LastId = input.ReadInt64();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
