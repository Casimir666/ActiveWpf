// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetLastTicksRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class GetLastTicksRequestProto : 
    IMessage<GetLastTicksRequestProto>,
    IMessage,
    IEquatable<GetLastTicksRequestProto>,
    IDeepCloneable<GetLastTicksRequestProto>
  {
    private static readonly MessageParser<GetLastTicksRequestProto> _parser = new MessageParser<GetLastTicksRequestProto>((Func<GetLastTicksRequestProto>) (() => new GetLastTicksRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int SymbolFieldNumber = 1;
    private string symbol_ = "";

    [DebuggerNonUserCode]
    public static MessageParser<GetLastTicksRequestProto> Parser => GetLastTicksRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[32];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetLastTicksRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public GetLastTicksRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public GetLastTicksRequestProto(GetLastTicksRequestProto other)
      : this()
    {
      this.symbol_ = other.symbol_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetLastTicksRequestProto Clone() => new GetLastTicksRequestProto(this);

    [DebuggerNonUserCode]
    public string Symbol
    {
      get => this.symbol_;
      set => this.symbol_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetLastTicksRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(GetLastTicksRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return !(this.Symbol != other.Symbol) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.Symbol.Length != 0)
        num ^= this.Symbol.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.Symbol.Length != 0)
      {
        output.WriteRawTag((byte) 10);
        output.WriteString(this.Symbol);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.Symbol.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Symbol);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetLastTicksRequestProto other)
    {
      if (other == null)
        return;
      if (other.Symbol.Length != 0)
        this.Symbol = other.Symbol;
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
          this.Symbol = input.ReadString();
      }
    }
  }
}
