// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.CurrencyProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class CurrencyProto : 
    IMessage<CurrencyProto>,
    IMessage,
    IEquatable<CurrencyProto>,
    IDeepCloneable<CurrencyProto>
  {
    private static readonly MessageParser<CurrencyProto> _parser = new MessageParser<CurrencyProto>((Func<CurrencyProto>) (() => new CurrencyProto()));
    private UnknownFieldSet _unknownFields;
    public const int IdFieldNumber = 1;
    private int id_;
    public const int IsoCodeFieldNumber = 2;
    private string isoCode_ = "";
    public const int PrimeFieldNumber = 3;
    private bool prime_;

    [DebuggerNonUserCode]
    public static MessageParser<CurrencyProto> Parser => CurrencyProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[130];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => CurrencyProto.Descriptor;

    [DebuggerNonUserCode]
    public CurrencyProto()
    {
    }

    [DebuggerNonUserCode]
    public CurrencyProto(CurrencyProto other)
      : this()
    {
      this.id_ = other.id_;
      this.isoCode_ = other.isoCode_;
      this.prime_ = other.prime_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public CurrencyProto Clone() => new CurrencyProto(this);

    [DebuggerNonUserCode]
    public int Id
    {
      get => this.id_;
      set => this.id_ = value;
    }

    [DebuggerNonUserCode]
    public string IsoCode
    {
      get => this.isoCode_;
      set => this.isoCode_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public bool Prime
    {
      get => this.prime_;
      set => this.prime_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as CurrencyProto);

    [DebuggerNonUserCode]
    public bool Equals(CurrencyProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.Id == other.Id && !(this.IsoCode != other.IsoCode) && this.Prime == other.Prime && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.Id != 0)
        num ^= this.Id.GetHashCode();
      if (this.IsoCode.Length != 0)
        num ^= this.IsoCode.GetHashCode();
      if (this.Prime)
        num ^= this.Prime.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.Id != 0)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt32(this.Id);
      }
      if (this.IsoCode.Length != 0)
      {
        output.WriteRawTag((byte) 18);
        output.WriteString(this.IsoCode);
      }
      if (this.Prime)
      {
        output.WriteRawTag((byte) 24);
        output.WriteBool(this.Prime);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.Id != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
      if (this.IsoCode.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.IsoCode);
      if (this.Prime)
        num += 2;
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(CurrencyProto other)
    {
      if (other == null)
        return;
      if (other.Id != 0)
        this.Id = other.Id;
      if (other.IsoCode.Length != 0)
        this.IsoCode = other.IsoCode;
      if (other.Prime)
        this.Prime = other.Prime;
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
            this.Id = input.ReadInt32();
            continue;
          case 18:
            this.IsoCode = input.ReadString();
            continue;
          case 24:
            this.Prime = input.ReadBool();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
