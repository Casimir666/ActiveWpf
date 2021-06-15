// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.SymbolSpreadProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class SymbolSpreadProto : 
    IMessage<SymbolSpreadProto>,
    IMessage,
    IEquatable<SymbolSpreadProto>,
    IDeepCloneable<SymbolSpreadProto>
  {
    private static readonly MessageParser<SymbolSpreadProto> _parser = new MessageParser<SymbolSpreadProto>((Func<SymbolSpreadProto>) (() => new SymbolSpreadProto()));
    private UnknownFieldSet _unknownFields;
    public const int SymbolIdFieldNumber = 1;
    private string symbolId_ = "";
    public const int TargetSpreadFieldNumber = 2;
    private double targetSpread_;
    public const int AverageSpreadFieldNumber = 3;
    private double averageSpread_;

    [DebuggerNonUserCode]
    public static MessageParser<SymbolSpreadProto> Parser => SymbolSpreadProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[184];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => SymbolSpreadProto.Descriptor;

    [DebuggerNonUserCode]
    public SymbolSpreadProto()
    {
    }

    [DebuggerNonUserCode]
    public SymbolSpreadProto(SymbolSpreadProto other)
      : this()
    {
      this.symbolId_ = other.symbolId_;
      this.targetSpread_ = other.targetSpread_;
      this.averageSpread_ = other.averageSpread_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public SymbolSpreadProto Clone() => new SymbolSpreadProto(this);

    [DebuggerNonUserCode]
    public string SymbolId
    {
      get => this.symbolId_;
      set => this.symbolId_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public double TargetSpread
    {
      get => this.targetSpread_;
      set => this.targetSpread_ = value;
    }

    [DebuggerNonUserCode]
    public double AverageSpread
    {
      get => this.averageSpread_;
      set => this.averageSpread_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as SymbolSpreadProto);

    [DebuggerNonUserCode]
    public bool Equals(SymbolSpreadProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return !(this.SymbolId != other.SymbolId) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TargetSpread, other.TargetSpread) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.AverageSpread, other.AverageSpread) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.SymbolId.Length != 0)
        num ^= this.SymbolId.GetHashCode();
      if (this.TargetSpread != 0.0)
        num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.TargetSpread);
      if (this.AverageSpread != 0.0)
        num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.AverageSpread);
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
      if (this.TargetSpread != 0.0)
      {
        output.WriteRawTag((byte) 17);
        output.WriteDouble(this.TargetSpread);
      }
      if (this.AverageSpread != 0.0)
      {
        output.WriteRawTag((byte) 25);
        output.WriteDouble(this.AverageSpread);
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
      if (this.TargetSpread != 0.0)
        num += 9;
      if (this.AverageSpread != 0.0)
        num += 9;
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(SymbolSpreadProto other)
    {
      if (other == null)
        return;
      if (other.SymbolId.Length != 0)
        this.SymbolId = other.SymbolId;
      if (other.TargetSpread != 0.0)
        this.TargetSpread = other.TargetSpread;
      if (other.AverageSpread != 0.0)
        this.AverageSpread = other.AverageSpread;
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
          case 10:
            this.SymbolId = input.ReadString();
            continue;
          case 17:
            this.TargetSpread = input.ReadDouble();
            continue;
          case 25:
            this.AverageSpread = input.ReadDouble();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
