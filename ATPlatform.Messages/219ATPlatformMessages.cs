// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetAccountsTradeSummaryPrevDayRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class GetAccountsTradeSummaryPrevDayRequestProto : 
    IMessage<GetAccountsTradeSummaryPrevDayRequestProto>,
    IMessage,
    IEquatable<GetAccountsTradeSummaryPrevDayRequestProto>,
    IDeepCloneable<GetAccountsTradeSummaryPrevDayRequestProto>
  {
    private static readonly MessageParser<GetAccountsTradeSummaryPrevDayRequestProto> _parser = new MessageParser<GetAccountsTradeSummaryPrevDayRequestProto>((Func<GetAccountsTradeSummaryPrevDayRequestProto>) (() => new GetAccountsTradeSummaryPrevDayRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int FromTimestampFieldNumber = 1;
    private long fromTimestamp_;

    [DebuggerNonUserCode]
    public static MessageParser<GetAccountsTradeSummaryPrevDayRequestProto> Parser => GetAccountsTradeSummaryPrevDayRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[220];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetAccountsTradeSummaryPrevDayRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public GetAccountsTradeSummaryPrevDayRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public GetAccountsTradeSummaryPrevDayRequestProto(
      GetAccountsTradeSummaryPrevDayRequestProto other)
      : this()
    {
      this.fromTimestamp_ = other.fromTimestamp_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetAccountsTradeSummaryPrevDayRequestProto Clone() => new GetAccountsTradeSummaryPrevDayRequestProto(this);

    [DebuggerNonUserCode]
    public long FromTimestamp
    {
      get => this.fromTimestamp_;
      set => this.fromTimestamp_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetAccountsTradeSummaryPrevDayRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(GetAccountsTradeSummaryPrevDayRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.FromTimestamp == other.FromTimestamp && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.FromTimestamp != 0L)
        num ^= this.FromTimestamp.GetHashCode();
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
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetAccountsTradeSummaryPrevDayRequestProto other)
    {
      if (other == null)
        return;
      if (other.FromTimestamp != 0L)
        this.FromTimestamp = other.FromTimestamp;
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
          this.FromTimestamp = input.ReadInt64();
      }
    }
  }
}
