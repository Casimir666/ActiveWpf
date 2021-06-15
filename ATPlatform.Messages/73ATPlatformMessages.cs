// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetAccountBalanceOperationRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class GetAccountBalanceOperationRequestProto : 
    IMessage<GetAccountBalanceOperationRequestProto>,
    IMessage,
    IEquatable<GetAccountBalanceOperationRequestProto>,
    IDeepCloneable<GetAccountBalanceOperationRequestProto>
  {
    private static readonly MessageParser<GetAccountBalanceOperationRequestProto> _parser = new MessageParser<GetAccountBalanceOperationRequestProto>((Func<GetAccountBalanceOperationRequestProto>) (() => new GetAccountBalanceOperationRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int ExternalOperationIdFieldNumber = 1;
    private long externalOperationId_;

    [DebuggerNonUserCode]
    public static MessageParser<GetAccountBalanceOperationRequestProto> Parser => GetAccountBalanceOperationRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[58];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetAccountBalanceOperationRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public GetAccountBalanceOperationRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public GetAccountBalanceOperationRequestProto(GetAccountBalanceOperationRequestProto other)
      : this()
    {
      this.externalOperationId_ = other.externalOperationId_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetAccountBalanceOperationRequestProto Clone() => new GetAccountBalanceOperationRequestProto(this);

    [DebuggerNonUserCode]
    public long ExternalOperationId
    {
      get => this.externalOperationId_;
      set => this.externalOperationId_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetAccountBalanceOperationRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(GetAccountBalanceOperationRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.ExternalOperationId == other.ExternalOperationId && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.ExternalOperationId != 0L)
        num ^= this.ExternalOperationId.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.ExternalOperationId != 0L)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt64(this.ExternalOperationId);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.ExternalOperationId != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.ExternalOperationId);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetAccountBalanceOperationRequestProto other)
    {
      if (other == null)
        return;
      if (other.ExternalOperationId != 0L)
        this.ExternalOperationId = other.ExternalOperationId;
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
          this.ExternalOperationId = input.ReadInt64();
      }
    }
  }
}
