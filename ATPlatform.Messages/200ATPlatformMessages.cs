// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.SmartBridgeSettingsProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class SmartBridgeSettingsProto : 
    IMessage<SmartBridgeSettingsProto>,
    IMessage,
    IEquatable<SmartBridgeSettingsProto>,
    IDeepCloneable<SmartBridgeSettingsProto>
  {
    private static readonly MessageParser<SmartBridgeSettingsProto> _parser = new MessageParser<SmartBridgeSettingsProto>((Func<SmartBridgeSettingsProto>) (() => new SmartBridgeSettingsProto()));
    private UnknownFieldSet _unknownFields;
    public const int SymbolGroupIdFieldNumber = 1;
    private int symbolGroupId_;
    public const int SymbolIdFieldNumber = 2;
    private string symbolId_ = "";
    public const int TriggerPriceOffsetTicksTier1FieldNumber = 3;
    private int triggerPriceOffsetTicksTier1_;
    public const int TrailingStopTicksTier1FieldNumber = 4;
    private int trailingStopTicksTier1_;
    public const int TriggerPriceOffsetTicksTier2FieldNumber = 5;
    private int triggerPriceOffsetTicksTier2_;
    public const int TrailingStopTicksTier2FieldNumber = 6;
    private int trailingStopTicksTier2_;
    public const int TriggerPriceOffsetTicksTier3FieldNumber = 7;
    private int triggerPriceOffsetTicksTier3_;
    public const int TrailingStopTicksTier3FieldNumber = 8;
    private int trailingStopTicksTier3_;
    public const int HedgeThresholdMultiplierFieldNumber = 9;
    private int hedgeThresholdMultiplier_;
    public const int HedgeDealPercentageFieldNumber = 10;
    private int hedgeDealPercentage_;
    public const int TagIdFieldNumber = 11;
    private int tagId_;

    [DebuggerNonUserCode]
    public static MessageParser<SmartBridgeSettingsProto> Parser => SmartBridgeSettingsProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[199];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => SmartBridgeSettingsProto.Descriptor;

    [DebuggerNonUserCode]
    public SmartBridgeSettingsProto()
    {
    }

    [DebuggerNonUserCode]
    public SmartBridgeSettingsProto(SmartBridgeSettingsProto other)
      : this()
    {
      this.symbolGroupId_ = other.symbolGroupId_;
      this.symbolId_ = other.symbolId_;
      this.triggerPriceOffsetTicksTier1_ = other.triggerPriceOffsetTicksTier1_;
      this.trailingStopTicksTier1_ = other.trailingStopTicksTier1_;
      this.triggerPriceOffsetTicksTier2_ = other.triggerPriceOffsetTicksTier2_;
      this.trailingStopTicksTier2_ = other.trailingStopTicksTier2_;
      this.triggerPriceOffsetTicksTier3_ = other.triggerPriceOffsetTicksTier3_;
      this.trailingStopTicksTier3_ = other.trailingStopTicksTier3_;
      this.hedgeThresholdMultiplier_ = other.hedgeThresholdMultiplier_;
      this.hedgeDealPercentage_ = other.hedgeDealPercentage_;
      this.tagId_ = other.tagId_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public SmartBridgeSettingsProto Clone() => new SmartBridgeSettingsProto(this);

    [DebuggerNonUserCode]
    public int SymbolGroupId
    {
      get => this.symbolGroupId_;
      set => this.symbolGroupId_ = value;
    }

    [DebuggerNonUserCode]
    public string SymbolId
    {
      get => this.symbolId_;
      set => this.symbolId_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public int TriggerPriceOffsetTicksTier1
    {
      get => this.triggerPriceOffsetTicksTier1_;
      set => this.triggerPriceOffsetTicksTier1_ = value;
    }

    [DebuggerNonUserCode]
    public int TrailingStopTicksTier1
    {
      get => this.trailingStopTicksTier1_;
      set => this.trailingStopTicksTier1_ = value;
    }

    [DebuggerNonUserCode]
    public int TriggerPriceOffsetTicksTier2
    {
      get => this.triggerPriceOffsetTicksTier2_;
      set => this.triggerPriceOffsetTicksTier2_ = value;
    }

    [DebuggerNonUserCode]
    public int TrailingStopTicksTier2
    {
      get => this.trailingStopTicksTier2_;
      set => this.trailingStopTicksTier2_ = value;
    }

    [DebuggerNonUserCode]
    public int TriggerPriceOffsetTicksTier3
    {
      get => this.triggerPriceOffsetTicksTier3_;
      set => this.triggerPriceOffsetTicksTier3_ = value;
    }

    [DebuggerNonUserCode]
    public int TrailingStopTicksTier3
    {
      get => this.trailingStopTicksTier3_;
      set => this.trailingStopTicksTier3_ = value;
    }

    [DebuggerNonUserCode]
    public int HedgeThresholdMultiplier
    {
      get => this.hedgeThresholdMultiplier_;
      set => this.hedgeThresholdMultiplier_ = value;
    }

    [DebuggerNonUserCode]
    public int HedgeDealPercentage
    {
      get => this.hedgeDealPercentage_;
      set => this.hedgeDealPercentage_ = value;
    }

    [DebuggerNonUserCode]
    public int TagId
    {
      get => this.tagId_;
      set => this.tagId_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as SmartBridgeSettingsProto);

    [DebuggerNonUserCode]
    public bool Equals(SmartBridgeSettingsProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.SymbolGroupId == other.SymbolGroupId && !(this.SymbolId != other.SymbolId) && (this.TriggerPriceOffsetTicksTier1 == other.TriggerPriceOffsetTicksTier1 && this.TrailingStopTicksTier1 == other.TrailingStopTicksTier1) && (this.TriggerPriceOffsetTicksTier2 == other.TriggerPriceOffsetTicksTier2 && this.TrailingStopTicksTier2 == other.TrailingStopTicksTier2 && (this.TriggerPriceOffsetTicksTier3 == other.TriggerPriceOffsetTicksTier3 && this.TrailingStopTicksTier3 == other.TrailingStopTicksTier3)) && (this.HedgeThresholdMultiplier == other.HedgeThresholdMultiplier && this.HedgeDealPercentage == other.HedgeDealPercentage && this.TagId == other.TagId) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      int num2;
      if (this.SymbolGroupId != 0)
      {
        int num3 = num1;
        num2 = this.SymbolGroupId;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.SymbolId.Length != 0)
        num1 ^= this.SymbolId.GetHashCode();
      if (this.TriggerPriceOffsetTicksTier1 != 0)
      {
        int num3 = num1;
        num2 = this.TriggerPriceOffsetTicksTier1;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.TrailingStopTicksTier1 != 0)
      {
        int num3 = num1;
        num2 = this.TrailingStopTicksTier1;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.TriggerPriceOffsetTicksTier2 != 0)
      {
        int num3 = num1;
        num2 = this.TriggerPriceOffsetTicksTier2;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.TrailingStopTicksTier2 != 0)
      {
        int num3 = num1;
        num2 = this.TrailingStopTicksTier2;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.TriggerPriceOffsetTicksTier3 != 0)
      {
        int num3 = num1;
        num2 = this.TriggerPriceOffsetTicksTier3;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.TrailingStopTicksTier3 != 0)
      {
        int num3 = num1;
        num2 = this.TrailingStopTicksTier3;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.HedgeThresholdMultiplier != 0)
      {
        int num3 = num1;
        num2 = this.HedgeThresholdMultiplier;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.HedgeDealPercentage != 0)
      {
        int num3 = num1;
        num2 = this.HedgeDealPercentage;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.TagId != 0)
      {
        int num3 = num1;
        num2 = this.TagId;
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
      if (this.SymbolGroupId != 0)
      {
        output.WriteRawTag((byte) 8);
        output.WriteInt32(this.SymbolGroupId);
      }
      if (this.SymbolId.Length != 0)
      {
        output.WriteRawTag((byte) 18);
        output.WriteString(this.SymbolId);
      }
      if (this.TriggerPriceOffsetTicksTier1 != 0)
      {
        output.WriteRawTag((byte) 24);
        output.WriteInt32(this.TriggerPriceOffsetTicksTier1);
      }
      if (this.TrailingStopTicksTier1 != 0)
      {
        output.WriteRawTag((byte) 32);
        output.WriteInt32(this.TrailingStopTicksTier1);
      }
      if (this.TriggerPriceOffsetTicksTier2 != 0)
      {
        output.WriteRawTag((byte) 40);
        output.WriteInt32(this.TriggerPriceOffsetTicksTier2);
      }
      if (this.TrailingStopTicksTier2 != 0)
      {
        output.WriteRawTag((byte) 48);
        output.WriteInt32(this.TrailingStopTicksTier2);
      }
      if (this.TriggerPriceOffsetTicksTier3 != 0)
      {
        output.WriteRawTag((byte) 56);
        output.WriteInt32(this.TriggerPriceOffsetTicksTier3);
      }
      if (this.TrailingStopTicksTier3 != 0)
      {
        output.WriteRawTag((byte) 64);
        output.WriteInt32(this.TrailingStopTicksTier3);
      }
      if (this.HedgeThresholdMultiplier != 0)
      {
        output.WriteRawTag((byte) 72);
        output.WriteInt32(this.HedgeThresholdMultiplier);
      }
      if (this.HedgeDealPercentage != 0)
      {
        output.WriteRawTag((byte) 80);
        output.WriteInt32(this.HedgeDealPercentage);
      }
      if (this.TagId != 0)
      {
        output.WriteRawTag((byte) 88);
        output.WriteInt32(this.TagId);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.SymbolGroupId != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.SymbolGroupId);
      if (this.SymbolId.Length != 0)
        num += 1 + CodedOutputStream.ComputeStringSize(this.SymbolId);
      if (this.TriggerPriceOffsetTicksTier1 != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.TriggerPriceOffsetTicksTier1);
      if (this.TrailingStopTicksTier1 != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.TrailingStopTicksTier1);
      if (this.TriggerPriceOffsetTicksTier2 != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.TriggerPriceOffsetTicksTier2);
      if (this.TrailingStopTicksTier2 != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.TrailingStopTicksTier2);
      if (this.TriggerPriceOffsetTicksTier3 != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.TriggerPriceOffsetTicksTier3);
      if (this.TrailingStopTicksTier3 != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.TrailingStopTicksTier3);
      if (this.HedgeThresholdMultiplier != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.HedgeThresholdMultiplier);
      if (this.HedgeDealPercentage != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.HedgeDealPercentage);
      if (this.TagId != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.TagId);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(SmartBridgeSettingsProto other)
    {
      if (other == null)
        return;
      if (other.SymbolGroupId != 0)
        this.SymbolGroupId = other.SymbolGroupId;
      if (other.SymbolId.Length != 0)
        this.SymbolId = other.SymbolId;
      if (other.TriggerPriceOffsetTicksTier1 != 0)
        this.TriggerPriceOffsetTicksTier1 = other.TriggerPriceOffsetTicksTier1;
      if (other.TrailingStopTicksTier1 != 0)
        this.TrailingStopTicksTier1 = other.TrailingStopTicksTier1;
      if (other.TriggerPriceOffsetTicksTier2 != 0)
        this.TriggerPriceOffsetTicksTier2 = other.TriggerPriceOffsetTicksTier2;
      if (other.TrailingStopTicksTier2 != 0)
        this.TrailingStopTicksTier2 = other.TrailingStopTicksTier2;
      if (other.TriggerPriceOffsetTicksTier3 != 0)
        this.TriggerPriceOffsetTicksTier3 = other.TriggerPriceOffsetTicksTier3;
      if (other.TrailingStopTicksTier3 != 0)
        this.TrailingStopTicksTier3 = other.TrailingStopTicksTier3;
      if (other.HedgeThresholdMultiplier != 0)
        this.HedgeThresholdMultiplier = other.HedgeThresholdMultiplier;
      if (other.HedgeDealPercentage != 0)
        this.HedgeDealPercentage = other.HedgeDealPercentage;
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
            this.SymbolGroupId = input.ReadInt32();
            continue;
          case 18:
            this.SymbolId = input.ReadString();
            continue;
          case 24:
            this.TriggerPriceOffsetTicksTier1 = input.ReadInt32();
            continue;
          case 32:
            this.TrailingStopTicksTier1 = input.ReadInt32();
            continue;
          case 40:
            this.TriggerPriceOffsetTicksTier2 = input.ReadInt32();
            continue;
          case 48:
            this.TrailingStopTicksTier2 = input.ReadInt32();
            continue;
          case 56:
            this.TriggerPriceOffsetTicksTier3 = input.ReadInt32();
            continue;
          case 64:
            this.TrailingStopTicksTier3 = input.ReadInt32();
            continue;
          case 72:
            this.HedgeThresholdMultiplier = input.ReadInt32();
            continue;
          case 80:
            this.HedgeDealPercentage = input.ReadInt32();
            continue;
          case 88:
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
