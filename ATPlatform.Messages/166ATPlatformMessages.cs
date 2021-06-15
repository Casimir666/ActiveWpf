// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.CommissionSettingsProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class CommissionSettingsProto : 
    IMessage<CommissionSettingsProto>,
    IMessage,
    IEquatable<CommissionSettingsProto>,
    IDeepCloneable<CommissionSettingsProto>
  {
    private static readonly MessageParser<CommissionSettingsProto> _parser = new MessageParser<CommissionSettingsProto>((Func<CommissionSettingsProto>) (() => new CommissionSettingsProto()));
    private UnknownFieldSet _unknownFields;
    public const int CommissionGroupIdFieldNumber = 1;
    private int commissionGroupId_;
    public const int SymbolIdFieldNumber = 2;
    private string symbolId_ = "";
    public const int CommissionsFieldNumber = 3;
    private static readonly FieldCodec<CommissionProto> _repeated_commissions_codec = FieldCodec.ForMessage<CommissionProto>(26U, CommissionProto.Parser);
    private readonly RepeatedField<CommissionProto> commissions_ = new RepeatedField<CommissionProto>();
    public const int TagIdFieldNumber = 4;
    private int tagId_;

    [DebuggerNonUserCode]
    public static MessageParser<CommissionSettingsProto> Parser => CommissionSettingsProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[160];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => CommissionSettingsProto.Descriptor;

    [DebuggerNonUserCode]
    public CommissionSettingsProto()
    {
    }

    [DebuggerNonUserCode]
    public CommissionSettingsProto(CommissionSettingsProto other)
      : this()
    {
      this.commissionGroupId_ = other.commissionGroupId_;
      this.symbolId_ = other.symbolId_;
      this.commissions_ = other.commissions_.Clone();
      this.tagId_ = other.tagId_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public CommissionSettingsProto Clone() => new CommissionSettingsProto(this);

    [DebuggerNonUserCode]
    public int CommissionGroupId
    {
      get => this.commissionGroupId_;
      set => this.commissionGroupId_ = value;
    }

    [DebuggerNonUserCode]
    public string SymbolId
    {
      get => this.symbolId_;
      set => this.symbolId_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public RepeatedField<CommissionProto> Commissions => this.commissions_;

    [DebuggerNonUserCode]
    public int TagId
    {
      get => this.tagId_;
      set => this.tagId_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as CommissionSettingsProto);

    [DebuggerNonUserCode]
    public bool Equals(CommissionSettingsProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.CommissionGroupId == other.CommissionGroupId && !(this.SymbolId != other.SymbolId) && (this.commissions_.Equals(other.commissions_) && this.TagId == other.TagId) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      int num2;
      if (this.CommissionGroupId != 0)
      {
        int num3 = num1;
        num2 = this.CommissionGroupId;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.SymbolId.Length != 0)
        num1 ^= this.SymbolId.GetHashCode();
      int num4 = num1 ^ this.commissions_.GetHashCode();
      if (this.TagId != 0)
      {
        int num3 = num4;
        num2 = this.TagId;
        int hashCode = num2.GetHashCode();
        num4 = num3 ^ hashCode;
      }
      if (this._unknownFields != null)
        num4 ^= this._unknownFields.GetHashCode();
      return num4;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.CommissionGroupId != 0)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt32(this.CommissionGroupId);
      }
      if (this.SymbolId.Length != 0)
      {
        output.WriteRawTag((byte) 18);
        output.WriteString(this.SymbolId);
      }
      this.commissions_.WriteTo(output, CommissionSettingsProto._repeated_commissions_codec);
      if (this.TagId != 0)
      {
        output.WriteRawTag((byte) 32);
        output.WriteInt32(this.TagId);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num1 = 0;
      if (this.CommissionGroupId != 0)
        num1 += 1 + CodedOutputStream.ComputeInt32Size(this.CommissionGroupId);
      if (this.SymbolId.Length != 0)
        num1 += 1 + CodedOutputStream.ComputeStringSize(this.SymbolId);
      int num2 = num1 + this.commissions_.CalculateSize(CommissionSettingsProto._repeated_commissions_codec);
      if (this.TagId != 0)
        num2 += 1 + CodedOutputStream.ComputeInt32Size(this.TagId);
      if (this._unknownFields != null)
        num2 += this._unknownFields.CalculateSize();
      return num2;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(CommissionSettingsProto other)
    {
      if (other == null)
        return;
      if (other.CommissionGroupId != 0)
        this.CommissionGroupId = other.CommissionGroupId;
      if (other.SymbolId.Length != 0)
        this.SymbolId = other.SymbolId;
      this.commissions_.Add((IEnumerable<CommissionProto>) other.commissions_);
      if (other.TagId != 0)
        this.TagId = other.TagId;
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
            this.CommissionGroupId = input.ReadInt32();
            continue;
          case 18:
            this.SymbolId = input.ReadString();
            continue;
          case 26:
            this.commissions_.AddEntriesFrom(input, CommissionSettingsProto._repeated_commissions_codec);
            continue;
          case 32:
            this.TagId = input.ReadInt32();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
