// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetSymbolsByTradeSetRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class GetSymbolsByTradeSetRequestProto : 
    IMessage<GetSymbolsByTradeSetRequestProto>,
    IMessage,
    IEquatable<GetSymbolsByTradeSetRequestProto>,
    IDeepCloneable<GetSymbolsByTradeSetRequestProto>
  {
    private static readonly MessageParser<GetSymbolsByTradeSetRequestProto> _parser = new MessageParser<GetSymbolsByTradeSetRequestProto>((Func<GetSymbolsByTradeSetRequestProto>) (() => new GetSymbolsByTradeSetRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int TradeSetNameFieldNumber = 1;
    private string tradeSetName_ = "";

    [DebuggerNonUserCode]
    public static MessageParser<GetSymbolsByTradeSetRequestProto> Parser => GetSymbolsByTradeSetRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[110];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetSymbolsByTradeSetRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public GetSymbolsByTradeSetRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public GetSymbolsByTradeSetRequestProto(GetSymbolsByTradeSetRequestProto other)
      : this()
    {
      this.tradeSetName_ = other.tradeSetName_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetSymbolsByTradeSetRequestProto Clone() => new GetSymbolsByTradeSetRequestProto(this);

    [DebuggerNonUserCode]
    public string TradeSetName
    {
      get => this.tradeSetName_;
      set => this.tradeSetName_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetSymbolsByTradeSetRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(GetSymbolsByTradeSetRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return !(this.TradeSetName != other.TradeSetName) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.TradeSetName.Length != 0)
        num ^= this.TradeSetName.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.TradeSetName.Length != 0)
      {
        output.WriteRawTag((byte) 10);
        output.WriteString(this.TradeSetName);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.TradeSetName.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.TradeSetName);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetSymbolsByTradeSetRequestProto other)
    {
      if (other == null)
        return;
      if (other.TradeSetName.Length != 0)
        this.TradeSetName = other.TradeSetName;
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
          this.TradeSetName = input.ReadString();
      }
    }
  }
}
