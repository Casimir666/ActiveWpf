// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.FeedSourceProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class FeedSourceProto : 
    IMessage<FeedSourceProto>,
    IMessage,
    IEquatable<FeedSourceProto>,
    IDeepCloneable<FeedSourceProto>
  {
    private static readonly MessageParser<FeedSourceProto> _parser = new MessageParser<FeedSourceProto>((Func<FeedSourceProto>) (() => new FeedSourceProto()));
    private UnknownFieldSet _unknownFields;
    public const int IdFieldNumber = 1;
    private int id_;
    public const int NameFieldNumber = 2;
    private string name_ = "";
    public const int PortFieldNumber = 3;
    private int port_;
    public const int AddressFieldNumber = 4;
    private string address_ = "";

    [DebuggerNonUserCode]
    public static MessageParser<FeedSourceProto> Parser => FeedSourceProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[205];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => FeedSourceProto.Descriptor;

    [DebuggerNonUserCode]
    public FeedSourceProto()
    {
    }

    [DebuggerNonUserCode]
    public FeedSourceProto(FeedSourceProto other)
      : this()
    {
      this.id_ = other.id_;
      this.name_ = other.name_;
      this.port_ = other.port_;
      this.address_ = other.address_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public FeedSourceProto Clone() => new FeedSourceProto(this);

    [DebuggerNonUserCode]
    public int Id
    {
      get => this.id_;
      set => this.id_ = value;
    }

    [DebuggerNonUserCode]
    public string Name
    {
      get => this.name_;
      set => this.name_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public int Port
    {
      get => this.port_;
      set => this.port_ = value;
    }

    [DebuggerNonUserCode]
    public string Address
    {
      get => this.address_;
      set => this.address_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as FeedSourceProto);

    [DebuggerNonUserCode]
    public bool Equals(FeedSourceProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.Id == other.Id && !(this.Name != other.Name) && (this.Port == other.Port && !(this.Address != other.Address)) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      int num2;
      if (this.Id != 0)
      {
        int num3 = num1;
        num2 = this.Id;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.Name.Length != 0)
        num1 ^= this.Name.GetHashCode();
      if (this.Port != 0)
      {
        int num3 = num1;
        num2 = this.Port;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.Address.Length != 0)
        num1 ^= this.Address.GetHashCode();
      if (this._unknownFields != null)
        num1 ^= this._unknownFields.GetHashCode();
      return num1;
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
      if (this.Name.Length != 0)
      {
        output.WriteRawTag((byte) 18);
        output.WriteString(this.Name);
      }
      if (this.Port != 0)
      {
        output.WriteRawTag((byte) 24);
        output.WriteInt32(this.Port);
      }
      if (this.Address.Length != 0)
      {
        output.WriteRawTag((byte) 34);
        output.WriteString(this.Address);
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
      if (this.Name.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
      if (this.Port != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.Port);
      if (this.Address.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.Address);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(FeedSourceProto other)
    {
      if (other == null)
        return;
      if (other.Id != 0)
        this.Id = other.Id;
      if (other.Name.Length != 0)
        this.Name = other.Name;
      if (other.Port != 0)
        this.Port = other.Port;
      if (other.Address.Length != 0)
        this.Address = other.Address;
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
            this.Name = input.ReadString();
            continue;
          case 24:
            this.Port = input.ReadInt32();
            continue;
          case 34:
            this.Address = input.ReadString();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
