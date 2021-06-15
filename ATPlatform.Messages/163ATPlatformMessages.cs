// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.UpdateBarsNotificationProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class UpdateBarsNotificationProto : 
    IMessage<UpdateBarsNotificationProto>,
    IMessage,
    IEquatable<UpdateBarsNotificationProto>,
    IDeepCloneable<UpdateBarsNotificationProto>
  {
    private static readonly MessageParser<UpdateBarsNotificationProto> _parser = new MessageParser<UpdateBarsNotificationProto>((Func<UpdateBarsNotificationProto>) (() => new UpdateBarsNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int SymbolIdFieldNumber = 1;
    private string symbolId_ = "";
    public const int DateFromFieldNumber = 2;
    private long dateFrom_;
    public const int DateToFieldNumber = 3;
    private long dateTo_;

    [DebuggerNonUserCode]
    public static MessageParser<UpdateBarsNotificationProto> Parser => UpdateBarsNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[156];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => UpdateBarsNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public UpdateBarsNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public UpdateBarsNotificationProto(UpdateBarsNotificationProto other)
      : this()
    {
      this.symbolId_ = other.symbolId_;
      this.dateFrom_ = other.dateFrom_;
      this.dateTo_ = other.dateTo_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public UpdateBarsNotificationProto Clone() => new UpdateBarsNotificationProto(this);

    [DebuggerNonUserCode]
    public string SymbolId
    {
      get => this.symbolId_;
      set => this.symbolId_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
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
    public override bool Equals(object other) => this.Equals(other as UpdateBarsNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(UpdateBarsNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return !(this.SymbolId != other.SymbolId) && this.DateFrom == other.DateFrom && this.DateTo == other.DateTo && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.SymbolId.Length != 0)
        num ^= this.SymbolId.GetHashCode();
      if (this.DateFrom != 0L)
        num ^= this.DateFrom.GetHashCode();
      if (this.DateTo != 0L)
        num ^= this.DateTo.GetHashCode();
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
      if (this.DateFrom != 0L)
      {
        output.WriteRawTag((byte) 16);
        output.WriteInt64(this.DateFrom);
      }
      if (this.DateTo != 0L)
      {
        output.WriteRawTag((byte) 24);
        output.WriteInt64(this.DateTo);
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
      if (this.DateFrom != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.DateFrom);
      if (this.DateTo != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.DateTo);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(UpdateBarsNotificationProto other)
    {
      if (other == null)
        return;
      if (other.SymbolId.Length != 0)
        this.SymbolId = other.SymbolId;
      if (other.DateFrom != 0L)
        this.DateFrom = other.DateFrom;
      if (other.DateTo != 0L)
        this.DateTo = other.DateTo;
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
          case 16:
            this.DateFrom = input.ReadInt64();
            continue;
          case 24:
            this.DateTo = input.ReadInt64();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
