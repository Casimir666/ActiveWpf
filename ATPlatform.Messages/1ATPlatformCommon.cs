// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.ProtocolVersionProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class ProtocolVersionProto : 
    IMessage<ProtocolVersionProto>,
    IMessage,
    IEquatable<ProtocolVersionProto>,
    IDeepCloneable<ProtocolVersionProto>
  {
    private static readonly MessageParser<ProtocolVersionProto> _parser = new MessageParser<ProtocolVersionProto>((Func<ProtocolVersionProto>) (() => new ProtocolVersionProto()));
    private UnknownFieldSet _unknownFields;
    public const int MajorFieldNumber = 1;
    private int major_;
    public const int MinorFieldNumber = 2;
    private int minor_;
    public const int PatchFieldNumber = 3;
    private int patch_;

    [DebuggerNonUserCode]
    public static MessageParser<ProtocolVersionProto> Parser => ProtocolVersionProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformCommonReflection.Descriptor.MessageTypes[0];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => ProtocolVersionProto.Descriptor;

    [DebuggerNonUserCode]
    public ProtocolVersionProto()
    {
    }

    [DebuggerNonUserCode]
    public ProtocolVersionProto(ProtocolVersionProto other)
      : this()
    {
      this.major_ = other.major_;
      this.minor_ = other.minor_;
      this.patch_ = other.patch_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public ProtocolVersionProto Clone() => new ProtocolVersionProto(this);

    [DebuggerNonUserCode]
    public int Major
    {
      get => this.major_;
      set => this.major_ = value;
    }

    [DebuggerNonUserCode]
    public int Minor
    {
      get => this.minor_;
      set => this.minor_ = value;
    }

    [DebuggerNonUserCode]
    public int Patch
    {
      get => this.patch_;
      set => this.patch_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as ProtocolVersionProto);

    [DebuggerNonUserCode]
    public bool Equals(ProtocolVersionProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.Major == other.Major && this.Minor == other.Minor && this.Patch == other.Patch && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      int num2;
      if (this.Major != 0)
      {
        int num3 = num1;
        num2 = this.Major;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.Minor != 0)
      {
        int num3 = num1;
        num2 = this.Minor;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.Patch != 0)
      {
        int num3 = num1;
        num2 = this.Patch;
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
      if (this.Major != 0)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt32(this.Major);
      }
      if (this.Minor != 0)
      {
        output.WriteRawTag((byte) 16);
        output.WriteInt32(this.Minor);
      }
      if (this.Patch != 0)
      {
        output.WriteRawTag((byte) 24);
        output.WriteInt32(this.Patch);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.Major != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.Major);
      if (this.Minor != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.Minor);
      if (this.Patch != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.Patch);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(ProtocolVersionProto other)
    {
      if (other == null)
        return;
      if (other.Major != 0)
        this.Major = other.Major;
      if (other.Minor != 0)
        this.Minor = other.Minor;
      if (other.Patch != 0)
        this.Patch = other.Patch;
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
            this.Major = input.ReadInt32();
            continue;
          case 16:
            this.Minor = input.ReadInt32();
            continue;
          case 24:
            this.Patch = input.ReadInt32();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
