// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetClientSessionRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class GetClientSessionRequestProto : 
    IMessage<GetClientSessionRequestProto>,
    IMessage,
    IEquatable<GetClientSessionRequestProto>,
    IDeepCloneable<GetClientSessionRequestProto>
  {
    private static readonly MessageParser<GetClientSessionRequestProto> _parser = new MessageParser<GetClientSessionRequestProto>((Func<GetClientSessionRequestProto>) (() => new GetClientSessionRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int SkipFieldNumber = 1;
    private int skip_;
    public const int TakeFieldNumber = 2;
    private int take_;
    public const int FilterFieldNumber = 3;
    private GetClientSessionFilterProto filter_;

    [DebuggerNonUserCode]
    public static MessageParser<GetClientSessionRequestProto> Parser => GetClientSessionRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[124];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetClientSessionRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public GetClientSessionRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public GetClientSessionRequestProto(GetClientSessionRequestProto other)
      : this()
    {
      this.skip_ = other.skip_;
      this.take_ = other.take_;
      this.filter_ = other.filter_ != null ? other.filter_.Clone() : (GetClientSessionFilterProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetClientSessionRequestProto Clone() => new GetClientSessionRequestProto(this);

    [DebuggerNonUserCode]
    public int Skip
    {
      get => this.skip_;
      set => this.skip_ = value;
    }

    [DebuggerNonUserCode]
    public int Take
    {
      get => this.take_;
      set => this.take_ = value;
    }

    [DebuggerNonUserCode]
    public GetClientSessionFilterProto Filter
    {
      get => this.filter_;
      set => this.filter_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetClientSessionRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(GetClientSessionRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.Skip == other.Skip && this.Take == other.Take && object.Equals((object) this.Filter, (object) other.Filter) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      int num2;
      if (this.Skip != 0)
      {
        int num3 = num1;
        num2 = this.Skip;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.Take != 0)
      {
        int num3 = num1;
        num2 = this.Take;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.filter_ != null)
        num1 ^= this.Filter.GetHashCode();
      if (this._unknownFields != null)
        num1 ^= this._unknownFields.GetHashCode();
      return num1;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.Skip != 0)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt32(this.Skip);
      }
      if (this.Take != 0)
      {
        output.WriteRawTag((byte) 16);
        output.WriteInt32(this.Take);
      }
      if (this.filter_ != null)
      {
        output.WriteRawTag((byte) 26);
        output.WriteMessage((IMessage) this.Filter);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.Skip != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.Skip);
      if (this.Take != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.Take);
      if (this.filter_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.Filter);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetClientSessionRequestProto other)
    {
      if (other == null)
        return;
      if (other.Skip != 0)
        this.Skip = other.Skip;
      if (other.Take != 0)
        this.Take = other.Take;
      if (other.filter_ != null)
      {
        if (this.filter_ == null)
          this.Filter = new GetClientSessionFilterProto();
        this.Filter.MergeFrom(other.Filter);
      }
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
            this.Skip = input.ReadInt32();
            continue;
          case 16:
            this.Take = input.ReadInt32();
            continue;
          case 26:
            if (this.filter_ == null)
              this.Filter = new GetClientSessionFilterProto();
            input.ReadMessage((IMessage) this.Filter);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
