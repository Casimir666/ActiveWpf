// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.CloneBarsRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class CloneBarsRequestProto : 
    IMessage<CloneBarsRequestProto>,
    IMessage,
    IEquatable<CloneBarsRequestProto>,
    IDeepCloneable<CloneBarsRequestProto>
  {
    private static readonly MessageParser<CloneBarsRequestProto> _parser = new MessageParser<CloneBarsRequestProto>((Func<CloneBarsRequestProto>) (() => new CloneBarsRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int SourceSymbolIdFieldNumber = 1;
    private string sourceSymbolId_ = "";
    public const int TargetSymbolIdFieldNumber = 2;
    private string targetSymbolId_ = "";
    public const int DateFromFieldNumber = 3;
    private long dateFrom_;
    public const int DateToFieldNumber = 4;
    private long dateTo_;
    public const int OffsetFieldNumber = 5;
    private int offset_;

    [DebuggerNonUserCode]
    public static MessageParser<CloneBarsRequestProto> Parser => CloneBarsRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[151];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => CloneBarsRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public CloneBarsRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public CloneBarsRequestProto(CloneBarsRequestProto other)
      : this()
    {
      this.sourceSymbolId_ = other.sourceSymbolId_;
      this.targetSymbolId_ = other.targetSymbolId_;
      this.dateFrom_ = other.dateFrom_;
      this.dateTo_ = other.dateTo_;
      this.offset_ = other.offset_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public CloneBarsRequestProto Clone() => new CloneBarsRequestProto(this);

    [DebuggerNonUserCode]
    public string SourceSymbolId
    {
      get => this.sourceSymbolId_;
      set => this.sourceSymbolId_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public string TargetSymbolId
    {
      get => this.targetSymbolId_;
      set => this.targetSymbolId_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public long DateFrom
    {
      get => this.dateFrom_;
      set => this.dateFrom_ = value;
    }

    [DebuggerNonUserCode]
    public long DateTo
    {
      get => this.dateTo_;
      set => this.dateTo_ = value;
    }

    [DebuggerNonUserCode]
    public int Offset
    {
      get => this.offset_;
      set => this.offset_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as CloneBarsRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(CloneBarsRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return !(this.SourceSymbolId != other.SourceSymbolId) && !(this.TargetSymbolId != other.TargetSymbolId) && (this.DateFrom == other.DateFrom && this.DateTo == other.DateTo) && this.Offset == other.Offset && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.SourceSymbolId.Length != 0)
        num ^= this.SourceSymbolId.GetHashCode();
      if (this.TargetSymbolId.Length != 0)
        num ^= this.TargetSymbolId.GetHashCode();
      if (this.DateFrom != 0L)
        num ^= this.DateFrom.GetHashCode();
      if (this.DateTo != 0L)
        num ^= this.DateTo.GetHashCode();
      if (this.Offset != 0)
        num ^= this.Offset.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.SourceSymbolId.Length != 0)
      {
        output.WriteRawTag((byte) 10);
        output.WriteString(this.SourceSymbolId);
      }
      if (this.TargetSymbolId.Length != 0)
      {
        output.WriteRawTag((byte) 18);
        output.WriteString(this.TargetSymbolId);
      }
      if (this.DateFrom != 0L)
      {
        output.WriteRawTag((byte) 24);
        output.WriteInt64(this.DateFrom);
      }
      if (this.DateTo != 0L)
      {
        output.WriteRawTag((byte) 32);
        output.WriteInt64(this.DateTo);
      }
      if (this.Offset != 0)
      {
        output.WriteRawTag((byte) 40);
        output.WriteInt32(this.Offset);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.SourceSymbolId.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.SourceSymbolId);
      if (this.TargetSymbolId.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.TargetSymbolId);
      if (this.DateFrom != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.DateFrom);
      if (this.DateTo != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.DateTo);
      if (this.Offset != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.Offset);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(CloneBarsRequestProto other)
    {
      if (other == null)
        return;
      if (other.SourceSymbolId.Length != 0)
        this.SourceSymbolId = other.SourceSymbolId;
      if (other.TargetSymbolId.Length != 0)
        this.TargetSymbolId = other.TargetSymbolId;
      if (other.DateFrom != 0L)
        this.DateFrom = other.DateFrom;
      if (other.DateTo != 0L)
        this.DateTo = other.DateTo;
      if (other.Offset != 0)
        this.Offset = other.Offset;
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
            this.SourceSymbolId = input.ReadString();
            continue;
          case 18:
            this.TargetSymbolId = input.ReadString();
            continue;
          case 24:
            this.DateFrom = input.ReadInt64();
            continue;
          case 32:
            this.DateTo = input.ReadInt64();
            continue;
          case 40:
            this.Offset = input.ReadInt32();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
