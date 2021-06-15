// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetClientSessionFilterProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class GetClientSessionFilterProto : 
    IMessage<GetClientSessionFilterProto>,
    IMessage,
    IEquatable<GetClientSessionFilterProto>,
    IDeepCloneable<GetClientSessionFilterProto>
  {
    private static readonly MessageParser<GetClientSessionFilterProto> _parser = new MessageParser<GetClientSessionFilterProto>((Func<GetClientSessionFilterProto>) (() => new GetClientSessionFilterProto()));
    private UnknownFieldSet _unknownFields;
    public const int AccountIdFieldNumber = 1;
    private int accountId_;
    public const int FromFieldNumber = 2;
    private long from_;
    public const int ToFieldNumber = 3;
    private long to_;
    public const int UniqueOnlyFieldNumber = 4;
    private bool uniqueOnly_;

    [DebuggerNonUserCode]
    public static MessageParser<GetClientSessionFilterProto> Parser => GetClientSessionFilterProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[123];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetClientSessionFilterProto.Descriptor;

    [DebuggerNonUserCode]
    public GetClientSessionFilterProto()
    {
    }

    [DebuggerNonUserCode]
    public GetClientSessionFilterProto(GetClientSessionFilterProto other)
      : this()
    {
      this.accountId_ = other.accountId_;
      this.from_ = other.from_;
      this.to_ = other.to_;
      this.uniqueOnly_ = other.uniqueOnly_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetClientSessionFilterProto Clone() => new GetClientSessionFilterProto(this);

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
    public bool UniqueOnly
    {
      get => this.uniqueOnly_;
      set => this.uniqueOnly_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetClientSessionFilterProto);

    [DebuggerNonUserCode]
    public bool Equals(GetClientSessionFilterProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.AccountId == other.AccountId && this.From == other.From && (this.To == other.To && this.UniqueOnly == other.UniqueOnly) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      if (this.AccountId != 0)
        num1 ^= this.AccountId.GetHashCode();
      long num2;
      if (this.From != 0L)
      {
        int num3 = num1;
        num2 = this.From;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.To != 0L)
      {
        int num3 = num1;
        num2 = this.To;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.UniqueOnly)
        num1 ^= this.UniqueOnly.GetHashCode();
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
      if (this.UniqueOnly)
      {
        output.WriteRawTag((byte) 32);
        output.WriteBool(this.UniqueOnly);
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
      if (this.UniqueOnly)
        num += 2;
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetClientSessionFilterProto other)
    {
      if (other == null)
        return;
      if (other.AccountId != 0)
        this.AccountId = other.AccountId;
      if (other.From != 0L)
        this.From = other.From;
      if (other.To != 0L)
        this.To = other.To;
      if (other.UniqueOnly)
        this.UniqueOnly = other.UniqueOnly;
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
            this.UniqueOnly = input.ReadBool();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
