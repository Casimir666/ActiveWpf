// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.CountryProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class CountryProto : 
    IMessage<CountryProto>,
    IMessage,
    IEquatable<CountryProto>,
    IDeepCloneable<CountryProto>
  {
    private static readonly MessageParser<CountryProto> _parser = new MessageParser<CountryProto>((Func<CountryProto>) (() => new CountryProto()));
    private UnknownFieldSet _unknownFields;
    public const int IdFieldNumber = 1;
    private int id_;
    public const int IsoCodeFieldNumber = 2;
    private string isoCode_ = "";
    public const int NameFieldNumber = 3;
    private string name_ = "";

    [DebuggerNonUserCode]
    public static MessageParser<CountryProto> Parser => CountryProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[133];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => CountryProto.Descriptor;

    [DebuggerNonUserCode]
    public CountryProto()
    {
    }

    [DebuggerNonUserCode]
    public CountryProto(CountryProto other)
      : this()
    {
      this.id_ = other.id_;
      this.isoCode_ = other.isoCode_;
      this.name_ = other.name_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public CountryProto Clone() => new CountryProto(this);

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
    public string Name
    {
      get => this.name_;
      set => this.name_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as CountryProto);

    [DebuggerNonUserCode]
    public bool Equals(CountryProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.Id == other.Id && !(this.IsoCode != other.IsoCode) && !(this.Name != other.Name) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.Id != 0)
        num ^= this.Id.GetHashCode();
      if (this.IsoCode.Length != 0)
        num ^= this.IsoCode.GetHashCode();
      if (this.Name.Length != 0)
        num ^= this.Name.GetHashCode();
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
      if (this.Name.Length != 0)
      {
        output.WriteRawTag((byte) 26);
        output.WriteString(this.Name);
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
      if (this.Name.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(CountryProto other)
    {
      if (other == null)
        return;
      if (other.Id != 0)
        this.Id = other.Id;
      if (other.IsoCode.Length != 0)
        this.IsoCode = other.IsoCode;
      if (other.Name.Length != 0)
        this.Name = other.Name;
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
          case 26:
            this.Name = input.ReadString();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
