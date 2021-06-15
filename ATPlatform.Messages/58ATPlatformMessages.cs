// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetSymbolRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class GetSymbolRequestProto : 
    IMessage<GetSymbolRequestProto>,
    IMessage,
    IEquatable<GetSymbolRequestProto>,
    IDeepCloneable<GetSymbolRequestProto>
  {
    private static readonly MessageParser<GetSymbolRequestProto> _parser = new MessageParser<GetSymbolRequestProto>((Func<GetSymbolRequestProto>) (() => new GetSymbolRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int SymbolIdFieldNumber = 1;
    private string symbolId_ = "";

    [DebuggerNonUserCode]
    public static MessageParser<GetSymbolRequestProto> Parser => GetSymbolRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[41];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetSymbolRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public GetSymbolRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public GetSymbolRequestProto(GetSymbolRequestProto other)
      : this()
    {
      this.symbolId_ = other.symbolId_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetSymbolRequestProto Clone() => new GetSymbolRequestProto(this);

    [DebuggerNonUserCode]
    public string SymbolId
    {
      get => this.symbolId_;
      set => this.symbolId_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetSymbolRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(GetSymbolRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return !(this.SymbolId != other.SymbolId) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.SymbolId.Length != 0)
        num ^= this.SymbolId.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.SymbolId.Length != 0)
      {
        output.WriteRawTag((byte) 10);
        output.WriteString(this.SymbolId);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.SymbolId.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.SymbolId);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetSymbolRequestProto other)
    {
      if (other == null)
        return;
      if (other.SymbolId.Length != 0)
        this.SymbolId = other.SymbolId;
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
          this.SymbolId = input.ReadString();
      }
    }
  }
}
