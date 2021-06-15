// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.HedgeSettingsProto
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
  public sealed class HedgeSettingsProto : 
    IMessage<HedgeSettingsProto>,
    IMessage,
    IEquatable<HedgeSettingsProto>,
    IDeepCloneable<HedgeSettingsProto>
  {
    private static readonly MessageParser<HedgeSettingsProto> _parser = new MessageParser<HedgeSettingsProto>((Func<HedgeSettingsProto>) (() => new HedgeSettingsProto()));
    private UnknownFieldSet _unknownFields;
    public const int SymbolGroupIdFieldNumber = 1;
    private int symbolGroupId_;
    public const int SymbolIdFieldNumber = 2;
    private string symbolId_ = "";
    public const int HedgeLiquidityProviderFieldNumber = 3;
    private HedgeLiquidityProviderProto hedgeLiquidityProvider_;
    public const int IsSmartFieldNumber = 4;
    private bool isSmart_;
    public const int VolumeCoefficientFieldNumber = 5;
    private double volumeCoefficient_;
    public const int AccumulationIntervalFieldNumber = 6;
    private int accumulationInterval_;
    public const int AllowLevel2VolumesFieldNumber = 7;
    private bool allowLevel2Volumes_;
    public const int TagIdFieldNumber = 8;
    private int tagId_;

    [DebuggerNonUserCode]
    public static MessageParser<HedgeSettingsProto> Parser => HedgeSettingsProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[193];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => HedgeSettingsProto.Descriptor;

    [DebuggerNonUserCode]
    public HedgeSettingsProto()
    {
    }

    [DebuggerNonUserCode]
    public HedgeSettingsProto(HedgeSettingsProto other)
      : this()
    {
      this.symbolGroupId_ = other.symbolGroupId_;
      this.symbolId_ = other.symbolId_;
      this.hedgeLiquidityProvider_ = other.hedgeLiquidityProvider_ != null ? other.hedgeLiquidityProvider_.Clone() : (HedgeLiquidityProviderProto) null;
      this.isSmart_ = other.isSmart_;
      this.volumeCoefficient_ = other.volumeCoefficient_;
      this.accumulationInterval_ = other.accumulationInterval_;
      this.allowLevel2Volumes_ = other.allowLevel2Volumes_;
      this.tagId_ = other.tagId_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public HedgeSettingsProto Clone() => new HedgeSettingsProto(this);

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
    public HedgeLiquidityProviderProto HedgeLiquidityProvider
    {
      get => this.hedgeLiquidityProvider_;
      set => this.hedgeLiquidityProvider_ = value;
    }

    [DebuggerNonUserCode]
    public bool IsSmart
    {
      get => this.isSmart_;
      set => this.isSmart_ = value;
    }

    [DebuggerNonUserCode]
    public double VolumeCoefficient
    {
      get => this.volumeCoefficient_;
      set => this.volumeCoefficient_ = value;
    }

    [DebuggerNonUserCode]
    public int AccumulationInterval
    {
      get => this.accumulationInterval_;
      set => this.accumulationInterval_ = value;
    }

    [DebuggerNonUserCode]
    public bool AllowLevel2Volumes
    {
      get => this.allowLevel2Volumes_;
      set => this.allowLevel2Volumes_ = value;
    }

    [DebuggerNonUserCode]
    public int TagId
    {
      get => this.tagId_;
      set => this.tagId_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as HedgeSettingsProto);

    [DebuggerNonUserCode]
    public bool Equals(HedgeSettingsProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.SymbolGroupId == other.SymbolGroupId && !(this.SymbolId != other.SymbolId) && (object.Equals((object) this.HedgeLiquidityProvider, (object) other.HedgeLiquidityProvider) && this.IsSmart == other.IsSmart) && (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.VolumeCoefficient, other.VolumeCoefficient) && this.AccumulationInterval == other.AccumulationInterval && (this.AllowLevel2Volumes == other.AllowLevel2Volumes && this.TagId == other.TagId)) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
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
      if (this.hedgeLiquidityProvider_ != null)
        num1 ^= this.HedgeLiquidityProvider.GetHashCode();
      bool flag;
      if (this.IsSmart)
      {
        int num3 = num1;
        flag = this.IsSmart;
        int hashCode = flag.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.VolumeCoefficient != 0.0)
        num1 ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.VolumeCoefficient);
      if (this.AccumulationInterval != 0)
      {
        int num3 = num1;
        num2 = this.AccumulationInterval;
        int hashCode = num2.GetHashCode();
        num1 = num3 ^ hashCode;
      }
      if (this.AllowLevel2Volumes)
      {
        int num3 = num1;
        flag = this.AllowLevel2Volumes;
        int hashCode = flag.GetHashCode();
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
      if (this.hedgeLiquidityProvider_ != null)
      {
        output.WriteRawTag((byte) 26);
        output.WriteMessage((IMessage) this.HedgeLiquidityProvider);
      }
      if (this.IsSmart)
      {
        output.WriteRawTag((byte) 32);
        output.WriteBool(this.IsSmart);
      }
      if (this.VolumeCoefficient != 0.0)
      {
        output.WriteRawTag((byte) 41);
        output.WriteDouble(this.VolumeCoefficient);
      }
      if (this.AccumulationInterval != 0)
      {
        output.WriteRawTag((byte) 48);
        output.WriteInt32(this.AccumulationInterval);
      }
      if (this.AllowLevel2Volumes)
      {
        output.WriteRawTag((byte) 56);
        output.WriteBool(this.AllowLevel2Volumes);
      }
      if (this.TagId != 0)
      {
        output.WriteRawTag((byte) 64);
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
      if (this.hedgeLiquidityProvider_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.HedgeLiquidityProvider);
      if (this.IsSmart)
        num += 2;
      if (this.VolumeCoefficient != 0.0)
        num += 9;
      if (this.AccumulationInterval != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.AccumulationInterval);
      if (this.AllowLevel2Volumes)
        num += 2;
      if (this.TagId != 0)
        num += 1 + CodedOutputStream.ComputeInt32Size(this.TagId);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(HedgeSettingsProto other)
    {
      if (other == null)
        return;
      if (other.SymbolGroupId != 0)
        this.SymbolGroupId = other.SymbolGroupId;
      if (other.SymbolId.Length != 0)
        this.SymbolId = other.SymbolId;
      if (other.hedgeLiquidityProvider_ != null)
      {
        if (this.hedgeLiquidityProvider_ == null)
          this.HedgeLiquidityProvider = new HedgeLiquidityProviderProto();
        this.HedgeLiquidityProvider.MergeFrom(other.HedgeLiquidityProvider);
      }
      if (other.IsSmart)
        this.IsSmart = other.IsSmart;
      if (other.VolumeCoefficient != 0.0)
        this.VolumeCoefficient = other.VolumeCoefficient;
      if (other.AccumulationInterval != 0)
        this.AccumulationInterval = other.AccumulationInterval;
      if (other.AllowLevel2Volumes)
        this.AllowLevel2Volumes = other.AllowLevel2Volumes;
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
          case 26:
            if (this.hedgeLiquidityProvider_ == null)
              this.HedgeLiquidityProvider = new HedgeLiquidityProviderProto();
            input.ReadMessage((IMessage) this.HedgeLiquidityProvider);
            continue;
          case 32:
            this.IsSmart = input.ReadBool();
            continue;
          case 41:
            this.VolumeCoefficient = input.ReadDouble();
            continue;
          case 48:
            this.AccumulationInterval = input.ReadInt32();
            continue;
          case 56:
            this.AllowLevel2Volumes = input.ReadBool();
            continue;
          case 64:
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
