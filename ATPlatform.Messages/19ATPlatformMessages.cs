// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.BarsEditCompleteProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class BarsEditCompleteProto : 
    IMessage<BarsEditCompleteProto>,
    IMessage,
    IEquatable<BarsEditCompleteProto>,
    IDeepCloneable<BarsEditCompleteProto>
  {
    private static readonly MessageParser<BarsEditCompleteProto> _parser = new MessageParser<BarsEditCompleteProto>((Func<BarsEditCompleteProto>) (() => new BarsEditCompleteProto()));
    private UnknownFieldSet _unknownFields;
    public const int FromTimestampFieldNumber = 1;
    private long fromTimestamp_;
    public const int SymbolIdFieldNumber = 2;
    private string symbolId_ = "";

    [DebuggerNonUserCode]
    public static MessageParser<BarsEditCompleteProto> Parser => BarsEditCompleteProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[0];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => BarsEditCompleteProto.Descriptor;

    [DebuggerNonUserCode]
    public BarsEditCompleteProto()
    {
    }

    [DebuggerNonUserCode]
    public BarsEditCompleteProto(BarsEditCompleteProto other)
      : this()
    {
      this.fromTimestamp_ = other.fromTimestamp_;
      this.symbolId_ = other.symbolId_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public BarsEditCompleteProto Clone() => new BarsEditCompleteProto(this);

    [DebuggerNonUserCode]
    public long FromTimestamp
    {
      get => this.fromTimestamp_;
      set => this.fromTimestamp_ = value;
    }

    [DebuggerNonUserCode]
    public string SymbolId
    {
      get => this.symbolId_;
      set => this.symbolId_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as BarsEditCompleteProto);

    [DebuggerNonUserCode]
    public bool Equals(BarsEditCompleteProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.FromTimestamp == other.FromTimestamp && !(this.SymbolId != other.SymbolId) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.FromTimestamp != 0L)
        num ^= this.FromTimestamp.GetHashCode();
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
      if (this.FromTimestamp != 0L)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt64(this.FromTimestamp);
      }
      if (this.SymbolId.Length != 0)
      {
        output.WriteRawTag((byte) 18);
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
      if (this.FromTimestamp != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.FromTimestamp);
      if (this.SymbolId.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.SymbolId);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(BarsEditCompleteProto other)
    {
      if (other == null)
        return;
      if (other.FromTimestamp != 0L)
        this.FromTimestamp = other.FromTimestamp;
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
        switch (num)
        {
          case 8:
            this.FromTimestamp = input.ReadInt64();
            continue;
          case 18:
            this.SymbolId = input.ReadString();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
