// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.MarginRequirementCheckNotificationProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class MarginRequirementCheckNotificationProto : 
    IMessage<MarginRequirementCheckNotificationProto>,
    IMessage,
    IEquatable<MarginRequirementCheckNotificationProto>,
    IDeepCloneable<MarginRequirementCheckNotificationProto>
  {
    private static readonly MessageParser<MarginRequirementCheckNotificationProto> _parser = new MessageParser<MarginRequirementCheckNotificationProto>((Func<MarginRequirementCheckNotificationProto>) (() => new MarginRequirementCheckNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int AccountIdFieldNumber = 1;
    private int accountId_;
    public const int RequiredMarginFieldNumber = 2;
    private double requiredMargin_;
    public const int AskMarkupFieldNumber = 3;
    private double askMarkup_;
    public const int BidMarkupFieldNumber = 4;
    private double bidMarkup_;

    [DebuggerNonUserCode]
    public static MessageParser<MarginRequirementCheckNotificationProto> Parser => MarginRequirementCheckNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[10];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => MarginRequirementCheckNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public MarginRequirementCheckNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public MarginRequirementCheckNotificationProto(MarginRequirementCheckNotificationProto other)
      : this()
    {
      this.accountId_ = other.accountId_;
      this.requiredMargin_ = other.requiredMargin_;
      this.askMarkup_ = other.askMarkup_;
      this.bidMarkup_ = other.bidMarkup_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public MarginRequirementCheckNotificationProto Clone() => new MarginRequirementCheckNotificationProto(this);

    [DebuggerNonUserCode]
    public int AccountId
    {
      get => this.accountId_;
      set => this.accountId_ = value;
    }

    [DebuggerNonUserCode]
    public double RequiredMargin
    {
      get => this.requiredMargin_;
      set => this.requiredMargin_ = value;
    }

    [DebuggerNonUserCode]
    public double AskMarkup
    {
      get => this.askMarkup_;
      set => this.askMarkup_ = value;
    }

    [DebuggerNonUserCode]
    public double BidMarkup
    {
      get => this.bidMarkup_;
      set => this.bidMarkup_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as MarginRequirementCheckNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(MarginRequirementCheckNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.AccountId == other.AccountId && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.RequiredMargin, other.RequiredMargin) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.AskMarkup, other.AskMarkup) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.BidMarkup, other.BidMarkup)) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.AccountId != 0)
        num ^= this.AccountId.GetHashCode();
      if (this.RequiredMargin != 0.0)
        num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.RequiredMargin);
      if (this.AskMarkup != 0.0)
        num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.AskMarkup);
      if (this.BidMarkup != 0.0)
        num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.BidMarkup);
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
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
      if (this.RequiredMargin != 0.0)
      {
        output.WriteRawTag((byte) 17);
        output.WriteDouble(this.RequiredMargin);
      }
      if (this.AskMarkup != 0.0)
      {
        output.WriteRawTag((byte) 25);
        output.WriteDouble(this.AskMarkup);
      }
      if (this.BidMarkup != 0.0)
      {
        output.WriteRawTag((byte) 33);
        output.WriteDouble(this.BidMarkup);
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
      if (this.RequiredMargin != 0.0)
        num += 9;
      if (this.AskMarkup != 0.0)
        num += 9;
      if (this.BidMarkup != 0.0)
        num += 9;
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(MarginRequirementCheckNotificationProto other)
    {
      if (other == null)
        return;
      if (other.AccountId != 0)
        this.AccountId = other.AccountId;
      if (other.RequiredMargin != 0.0)
        this.RequiredMargin = other.RequiredMargin;
      if (other.AskMarkup != 0.0)
        this.AskMarkup = other.AskMarkup;
      if (other.BidMarkup != 0.0)
        this.BidMarkup = other.BidMarkup;
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
          case 17:
            this.RequiredMargin = input.ReadDouble();
            continue;
          case 25:
            this.AskMarkup = input.ReadDouble();
            continue;
          case 33:
            this.BidMarkup = input.ReadDouble();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
