// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetSymbolGroupsRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class GetSymbolGroupsRequestProto : 
    IMessage<GetSymbolGroupsRequestProto>,
    IMessage,
    IEquatable<GetSymbolGroupsRequestProto>,
    IDeepCloneable<GetSymbolGroupsRequestProto>
  {
    private static readonly MessageParser<GetSymbolGroupsRequestProto> _parser = new MessageParser<GetSymbolGroupsRequestProto>((Func<GetSymbolGroupsRequestProto>) (() => new GetSymbolGroupsRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int RequestIdFieldNumber = 1;
    private int requestId_;

    [DebuggerNonUserCode]
    public static MessageParser<GetSymbolGroupsRequestProto> Parser => GetSymbolGroupsRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[36];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetSymbolGroupsRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public GetSymbolGroupsRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public GetSymbolGroupsRequestProto(GetSymbolGroupsRequestProto other)
      : this()
    {
      this.requestId_ = other.requestId_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetSymbolGroupsRequestProto Clone() => new GetSymbolGroupsRequestProto(this);

    [DebuggerNonUserCode]
    public int RequestId
    {
      get => this.requestId_;
      set => this.requestId_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetSymbolGroupsRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(GetSymbolGroupsRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.RequestId == other.RequestId && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.RequestId != 0)
        num ^= this.RequestId.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.RequestId != 0)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt32(this.RequestId);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.RequestId != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.RequestId);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetSymbolGroupsRequestProto other)
    {
      if (other == null)
        return;
      if (other.RequestId != 0)
        this.RequestId = other.RequestId;
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
          this.RequestId = input.ReadInt32();
      }
    }
  }
}
