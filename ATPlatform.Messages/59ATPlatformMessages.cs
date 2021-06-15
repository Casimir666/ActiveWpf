// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetSymbolNotificationProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class GetSymbolNotificationProto : 
    IMessage<GetSymbolNotificationProto>,
    IMessage,
    IEquatable<GetSymbolNotificationProto>,
    IDeepCloneable<GetSymbolNotificationProto>
  {
    private static readonly MessageParser<GetSymbolNotificationProto> _parser = new MessageParser<GetSymbolNotificationProto>((Func<GetSymbolNotificationProto>) (() => new GetSymbolNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int SymbolFieldNumber = 1;
    private SymbolProto symbol_;

    [DebuggerNonUserCode]
    public static MessageParser<GetSymbolNotificationProto> Parser => GetSymbolNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[42];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetSymbolNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetSymbolNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetSymbolNotificationProto(GetSymbolNotificationProto other)
      : this()
    {
      this.symbol_ = other.symbol_ != null ? other.symbol_.Clone() : (SymbolProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetSymbolNotificationProto Clone() => new GetSymbolNotificationProto(this);

    [DebuggerNonUserCode]
    public SymbolProto Symbol
    {
      get => this.symbol_;
      set => this.symbol_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetSymbolNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetSymbolNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return object.Equals((object) this.Symbol, (object) other.Symbol) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.symbol_ != null)
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
      if (this.symbol_ != null)
      {
        output.WriteRawTag((byte) 10);
        output.WriteMessage((IMessage) this.Symbol);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.symbol_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.Symbol);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetSymbolNotificationProto other)
    {
      if (other == null)
        return;
      if (other.symbol_ != null)
      {
        if (this.symbol_ == null)
          this.Symbol = new SymbolProto();
        this.Symbol.MergeFrom(other.Symbol);
      }
      this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
    }

    [DebuggerNonUserCode]
    public void MergeFrom(CodedInputStream input)
    {
      uint num;
      while ((num = input.ReadTag()) != 0U)
      {
        if (num != 10U)
        {
          this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
        }
        else
        {
          if (this.symbol_ == null)
            this.Symbol = new SymbolProto();
          input.ReadMessage((IMessage) this.Symbol);
        }
      }
    }
  }
}
