// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.SymbolGroupProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class SymbolGroupProto : 
    IMessage<SymbolGroupProto>,
    IMessage,
    IEquatable<SymbolGroupProto>,
    IDeepCloneable<SymbolGroupProto>
  {
    private static readonly MessageParser<SymbolGroupProto> _parser = new MessageParser<SymbolGroupProto>((Func<SymbolGroupProto>) (() => new SymbolGroupProto()));
    private UnknownFieldSet _unknownFields;
    public const int IdFieldNumber = 1;
    private int id_;
    public const int NameFieldNumber = 2;
    private string name_ = "";
    public const int ParentIdFieldNumber = 3;
    private int parentId_;
    public const int ColorHexFieldNumber = 4;
    private string colorHex_ = "";
    public const int RankFieldNumber = 5;
    private int rank_;
    public const int IsVirtualFieldNumber = 6;
    private bool isVirtual_;

    [DebuggerNonUserCode]
    public static MessageParser<SymbolGroupProto> Parser => SymbolGroupProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[38];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => SymbolGroupProto.Descriptor;

    [DebuggerNonUserCode]
    public SymbolGroupProto()
    {
    }

    [DebuggerNonUserCode]
    public SymbolGroupProto(SymbolGroupProto other)
      : this()
    {
      this.id_ = other.id_;
      this.name_ = other.name_;
      this.parentId_ = other.parentId_;
      this.colorHex_ = other.colorHex_;
      this.rank_ = other.rank_;
      this.isVirtual_ = other.isVirtual_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public SymbolGroupProto Clone() => new SymbolGroupProto(this);

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
    public int ParentId
    {
      get => this.parentId_;
      set => this.parentId_ = value;
    }

    [DebuggerNonUserCode]
    public string ColorHex
    {
      get => this.colorHex_;
      set => this.colorHex_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public int Rank
    {
      get => this.rank_;
      set => this.rank_ = value;
    }

    [DebuggerNonUserCode]
    public bool IsVirtual
    {
      get => this.isVirtual_;
      set => this.isVirtual_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as SymbolGroupProto);

    [DebuggerNonUserCode]
    public bool Equals(SymbolGroupProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.Id == other.Id && !(this.Name != other.Name) && (this.ParentId == other.ParentId && !(this.ColorHex != other.ColorHex)) && (this.Rank == other.Rank && this.IsVirtual == other.IsVirtual) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
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
      if (this.ParentId != 0)
      {
        int num3 = num1;
        num2 = this.ParentId;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.ColorHex.Length != 0)
        num1 ^= this.ColorHex.GetHashCode();
      if (this.Rank != 0)
      {
        int num3 = num1;
        num2 = this.Rank;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.IsVirtual)
        num1 ^= this.IsVirtual.GetHashCode();
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
      if (this.ParentId != 0)
      {
        output.WriteRawTag((byte) 24);
        output.WriteInt32(this.ParentId);
      }
      if (this.ColorHex.Length != 0)
      {
        output.WriteRawTag((byte) 34);
        output.WriteString(this.ColorHex);
      }
      if (this.Rank != 0)
      {
        output.WriteRawTag((byte) 40);
        output.WriteInt32(this.Rank);
      }
      if (this.IsVirtual)
      {
        output.WriteRawTag((byte) 48);
        output.WriteBool(this.IsVirtual);
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
      if (this.ParentId != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.ParentId);
      if (this.ColorHex.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.ColorHex);
      if (this.Rank != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.Rank);
      if (this.IsVirtual)
        num += 2;
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(SymbolGroupProto other)
    {
      if (other == null)
        return;
      if (other.Id != 0)
        this.Id = other.Id;
      if (other.Name.Length != 0)
        this.Name = other.Name;
      if (other.ParentId != 0)
        this.ParentId = other.ParentId;
      if (other.ColorHex.Length != 0)
        this.ColorHex = other.ColorHex;
      if (other.Rank != 0)
        this.Rank = other.Rank;
      if (other.IsVirtual)
        this.IsVirtual = other.IsVirtual;
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
            this.ParentId = input.ReadInt32();
            continue;
          case 34:
            this.ColorHex = input.ReadString();
            continue;
          case 40:
            this.Rank = input.ReadInt32();
            continue;
          case 48:
            this.IsVirtual = input.ReadBool();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
