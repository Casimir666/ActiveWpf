// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetClosedOrdersForAccountRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class GetClosedOrdersForAccountRequestProto : 
    IMessage<GetClosedOrdersForAccountRequestProto>,
    IMessage,
    IEquatable<GetClosedOrdersForAccountRequestProto>,
    IDeepCloneable<GetClosedOrdersForAccountRequestProto>
  {
    private static readonly MessageParser<GetClosedOrdersForAccountRequestProto> _parser = new MessageParser<GetClosedOrdersForAccountRequestProto>((Func<GetClosedOrdersForAccountRequestProto>) (() => new GetClosedOrdersForAccountRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int AccountIdFieldNumber = 1;
    private int accountId_;
    public const int FromFieldNumber = 2;
    private long from_;
    public const int ToFieldNumber = 3;
    private long to_;
    public const int SkipFieldNumber = 4;
    private int skip_;
    public const int TakeFieldNumber = 5;
    private int take_;

    [DebuggerNonUserCode]
    public static MessageParser<GetClosedOrdersForAccountRequestProto> Parser => GetClosedOrdersForAccountRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[87];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetClosedOrdersForAccountRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public GetClosedOrdersForAccountRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public GetClosedOrdersForAccountRequestProto(GetClosedOrdersForAccountRequestProto other)
      : this()
    {
      this.accountId_ = other.accountId_;
      this.from_ = other.from_;
      this.to_ = other.to_;
      this.skip_ = other.skip_;
      this.take_ = other.take_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetClosedOrdersForAccountRequestProto Clone() => new GetClosedOrdersForAccountRequestProto(this);

    [DebuggerNonUserCode]
    public int AccountId
    {
      get => this.accountId_;
      set => this.accountId_ = value;
    }

    [DebuggerNonUserCode]
    public long From
    {
      get => this.from_;
      set => this.from_ = value;
    }

    [DebuggerNonUserCode]
    public long To
    {
      get => this.to_;
      set => this.to_ = value;
    }

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
    public override bool Equals(object other) => this.Equals(other as GetClosedOrdersForAccountRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(GetClosedOrdersForAccountRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.AccountId == other.AccountId && this.From == other.From && (this.To == other.To && this.Skip == other.Skip) && this.Take == other.Take && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      int num2;
      if (this.AccountId != 0)
      {
        int num3 = num1;
        num2 = this.AccountId;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      long num4;
      if (this.From != 0L)
      {
        int num3 = num1;
        num4 = this.From;
        int hashCode = num4.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.To != 0L)
      {
        int num3 = num1;
        num4 = this.To;
        int hashCode = num4.GetHashCode();
        num1 = num3 ^ hashCode;
      }
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
      if (this._unknownFields != null)
        num1 ^= this._unknownFields.GetHashCode();
      return num1;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.AccountId != 0)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt32(this.AccountId);
      }
      if (this.From != 0L)
      {
        output.WriteRawTag((byte) 16);
        output.WriteInt64(this.From);
      }
      if (this.To != 0L)
      {
        output.WriteRawTag((byte) 24);
        output.WriteInt64(this.To);
      }
      if (this.Skip != 0)
      {
        output.WriteRawTag((byte) 32);
        output.WriteInt32(this.Skip);
      }
      if (this.Take != 0)
      {
        output.WriteRawTag((byte) 40);
        output.WriteInt32(this.Take);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.AccountId != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.AccountId);
      if (this.From != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.From);
      if (this.To != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.To);
      if (this.Skip != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.Skip);
      if (this.Take != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.Take);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetClosedOrdersForAccountRequestProto other)
    {
      if (other == null)
        return;
      if (other.AccountId != 0)
        this.AccountId = other.AccountId;
      if (other.From != 0L)
        this.From = other.From;
      if (other.To != 0L)
        this.To = other.To;
      if (other.Skip != 0)
        this.Skip = other.Skip;
      if (other.Take != 0)
        this.Take = other.Take;
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
            this.AccountId = input.ReadInt32();
            continue;
          case 16:
            this.From = input.ReadInt64();
            continue;
          case 24:
            this.To = input.ReadInt64();
            continue;
          case 32:
            this.Skip = input.ReadInt32();
            continue;
          case 40:
            this.Take = input.ReadInt32();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
