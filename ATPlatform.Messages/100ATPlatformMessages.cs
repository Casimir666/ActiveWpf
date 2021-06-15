// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.BaseMessageForAccountProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class BaseMessageForAccountProto : 
    IMessage<BaseMessageForAccountProto>,
    IMessage,
    IEquatable<BaseMessageForAccountProto>,
    IDeepCloneable<BaseMessageForAccountProto>
  {
    private static readonly MessageParser<BaseMessageForAccountProto> _parser = new MessageParser<BaseMessageForAccountProto>((Func<BaseMessageForAccountProto>) (() => new BaseMessageForAccountProto()));
    private UnknownFieldSet _unknownFields;
    public const int AccountIdFieldNumber = 1;
    private int accountId_;

    [DebuggerNonUserCode]
    public static MessageParser<BaseMessageForAccountProto> Parser => BaseMessageForAccountProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[92];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => BaseMessageForAccountProto.Descriptor;

    [DebuggerNonUserCode]
    public BaseMessageForAccountProto()
    {
    }

    [DebuggerNonUserCode]
    public BaseMessageForAccountProto(BaseMessageForAccountProto other)
      : this()
    {
      this.accountId_ = other.accountId_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public BaseMessageForAccountProto Clone() => new BaseMessageForAccountProto(this);

    [DebuggerNonUserCode]
    public int AccountId
    {
      get => this.accountId_;
      set => this.accountId_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as BaseMessageForAccountProto);

    [DebuggerNonUserCode]
    public bool Equals(BaseMessageForAccountProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.AccountId == other.AccountId && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.AccountId != 0)
        num ^= this.AccountId.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.AccountId != 0)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt32(this.AccountId);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.AccountId != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.AccountId);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(BaseMessageForAccountProto other)
    {
      if (other == null)
        return;
      if (other.AccountId != 0)
        this.AccountId = other.AccountId;
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
          this.AccountId = input.ReadInt32();
      }
    }
  }
}
