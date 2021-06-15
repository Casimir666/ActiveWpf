// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetCountRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class GetCountRequestProto : 
    IGetCount,
    IMessage<GetCountRequestProto>,
    IMessage,
    IEquatable<GetCountRequestProto>,
    IDeepCloneable<GetCountRequestProto>
  {
    private static readonly MessageParser<GetCountRequestProto> _parser = new MessageParser<GetCountRequestProto>((Func<GetCountRequestProto>) (() => new GetCountRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int CountRequestFieldNumber = 1;
    private CountTypeProto countRequest_;

    [DebuggerNonUserCode]
    public static MessageParser<GetCountRequestProto> Parser => GetCountRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[89];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetCountRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public GetCountRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public GetCountRequestProto(GetCountRequestProto other)
      : this()
    {
      this.countRequest_ = other.countRequest_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetCountRequestProto Clone() => new GetCountRequestProto(this);

    [DebuggerNonUserCode]
    public CountTypeProto CountRequest
    {
      get => this.countRequest_;
      set => this.countRequest_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetCountRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(GetCountRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.CountRequest == other.CountRequest && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.CountRequest != CountTypeProto.UndefinedCountRequest)
        num ^= this.CountRequest.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.CountRequest != CountTypeProto.UndefinedCountRequest)
      {
        output.WriteRawTag((byte) 8);
        output.WriteEnum((int) this.CountRequest);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.CountRequest != CountTypeProto.UndefinedCountRequest)
        num += 1 + CodedOutputStream.ComputeEnumSize((int) this.CountRequest);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetCountRequestProto other)
    {
      if (other == null)
        return;
      if (other.CountRequest != CountTypeProto.UndefinedCountRequest)
        this.CountRequest = other.CountRequest;
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
          this.CountRequest = (CountTypeProto) input.ReadEnum();
      }
    }
  }
}
