// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.CommissionSettingsSetRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class CommissionSettingsSetRequestProto : 
    IMessage<CommissionSettingsSetRequestProto>,
    IMessage,
    IEquatable<CommissionSettingsSetRequestProto>,
    IDeepCloneable<CommissionSettingsSetRequestProto>
  {
    private static readonly MessageParser<CommissionSettingsSetRequestProto> _parser = new MessageParser<CommissionSettingsSetRequestProto>((Func<CommissionSettingsSetRequestProto>) (() => new CommissionSettingsSetRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int CommissionSettingsSetFieldNumber = 1;
    private CommissionSettingsSetProto commissionSettingsSet_;

    [DebuggerNonUserCode]
    public static MessageParser<CommissionSettingsSetRequestProto> Parser => CommissionSettingsSetRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[169];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => CommissionSettingsSetRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public CommissionSettingsSetRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public CommissionSettingsSetRequestProto(CommissionSettingsSetRequestProto other)
      : this()
    {
      this.commissionSettingsSet_ = other.commissionSettingsSet_ != null ? other.commissionSettingsSet_.Clone() : (CommissionSettingsSetProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public CommissionSettingsSetRequestProto Clone() => new CommissionSettingsSetRequestProto(this);

    [DebuggerNonUserCode]
    public CommissionSettingsSetProto CommissionSettingsSet
    {
      get => this.commissionSettingsSet_;
      set => this.commissionSettingsSet_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as CommissionSettingsSetRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(CommissionSettingsSetRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return object.Equals((object) this.CommissionSettingsSet, (object) other.CommissionSettingsSet) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.commissionSettingsSet_ != null)
        num ^= this.CommissionSettingsSet.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.commissionSettingsSet_ != null)
      {
        output.WriteRawTag((byte) 10);
        output.WriteMessage((IMessage) this.CommissionSettingsSet);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.commissionSettingsSet_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.CommissionSettingsSet);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(CommissionSettingsSetRequestProto other)
    {
      if (other == null)
        return;
      if (other.commissionSettingsSet_ != null)
      {
        if (this.commissionSettingsSet_ == null)
          this.CommissionSettingsSet = new CommissionSettingsSetProto();
        this.CommissionSettingsSet.MergeFrom(other.CommissionSettingsSet);
      }
      this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
    }

    [DebuggerNonUserCode]
    public void MergeFrom(CodedInputStream input)
    {
      uint num;
      while ((num = input.ReadTag()) != 0U)
      {
        if (num != 10U)
        {
          this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
        }
        else
        {
          if (this.commissionSettingsSet_ == null)
            this.CommissionSettingsSet = new CommissionSettingsSetProto();
          input.ReadMessage((IMessage) this.CommissionSettingsSet);
        }
      }
    }
  }
}
