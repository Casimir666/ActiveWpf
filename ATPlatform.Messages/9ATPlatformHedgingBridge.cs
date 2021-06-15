// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.HedgingBridge.BridgeErrorNotificationProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL.HedgingBridge
{
  public sealed class BridgeErrorNotificationProto : 
    IMessage<BridgeErrorNotificationProto>,
    IMessage,
    IEquatable<BridgeErrorNotificationProto>,
    IDeepCloneable<BridgeErrorNotificationProto>
  {
    private static readonly MessageParser<BridgeErrorNotificationProto> _parser = new MessageParser<BridgeErrorNotificationProto>((Func<BridgeErrorNotificationProto>) (() => new BridgeErrorNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int ErrorCodeFieldNumber = 1;
    private ErrorCodeProto errorCode_;
    public const int RequestIdFieldNumber = 2;
    private long requestId_;

    [DebuggerNonUserCode]
    public static MessageParser<BridgeErrorNotificationProto> Parser => BridgeErrorNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformHedgingBridgeReflection.Descriptor.MessageTypes[8];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => BridgeErrorNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public BridgeErrorNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public BridgeErrorNotificationProto(BridgeErrorNotificationProto other)
      : this()
    {
      this.errorCode_ = other.errorCode_;
      this.requestId_ = other.requestId_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public BridgeErrorNotificationProto Clone() => new BridgeErrorNotificationProto(this);

    [DebuggerNonUserCode]
    public ErrorCodeProto ErrorCode
    {
      get => this.errorCode_;
      set => this.errorCode_ = value;
    }

    [DebuggerNonUserCode]
    public long RequestId
    {
      get => this.requestId_;
      set => this.requestId_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as BridgeErrorNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(BridgeErrorNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.ErrorCode == other.ErrorCode && this.RequestId == other.RequestId && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.ErrorCode != ErrorCodeProto.Success)
        num ^= this.ErrorCode.GetHashCode();
      if (this.RequestId != 0L)
        num ^= this.RequestId.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.ErrorCode != ErrorCodeProto.Success)
      {
        output.WriteRawTag((byte) 8);
        output.WriteEnum((int) this.ErrorCode);
      }
      if (this.RequestId != 0L)
      {
        output.WriteRawTag((byte) 16);
        output.WriteInt64(this.RequestId);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.ErrorCode != ErrorCodeProto.Success)
        num += 1 + CodedOutputStream.ComputeEnumSize((int) this.ErrorCode);
      if (this.RequestId != 0L)
        num += 1 + CodedOutputStream.ComputeInt64Size(this.RequestId);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(BridgeErrorNotificationProto other)
    {
      if (other == null)
        return;
      if (other.ErrorCode != ErrorCodeProto.Success)
        this.ErrorCode = other.ErrorCode;
      if (other.RequestId != 0L)
        this.RequestId = other.RequestId;
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
            this.ErrorCode = (ErrorCodeProto) input.ReadEnum();
            continue;
          case 16:
            this.RequestId = input.ReadInt64();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
