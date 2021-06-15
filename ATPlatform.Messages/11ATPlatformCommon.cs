// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetServerPublicInfoNotificationProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class GetServerPublicInfoNotificationProto : 
    IMessage<GetServerPublicInfoNotificationProto>,
    IMessage,
    IEquatable<GetServerPublicInfoNotificationProto>,
    IDeepCloneable<GetServerPublicInfoNotificationProto>
  {
    private static readonly MessageParser<GetServerPublicInfoNotificationProto> _parser = new MessageParser<GetServerPublicInfoNotificationProto>((Func<GetServerPublicInfoNotificationProto>) (() => new GetServerPublicInfoNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int PlatformTypeFieldNumber = 1;
    private PlatformTypeProto platformType_;
    public const int TimeZoneFieldNumber = 2;
    private PlatformTimeZoneProto timeZone_;
    public const int ProtocolVersionFieldNumber = 3;
    private ProtocolVersionProto protocolVersion_;

    [DebuggerNonUserCode]
    public static MessageParser<GetServerPublicInfoNotificationProto> Parser => GetServerPublicInfoNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformCommonReflection.Descriptor.MessageTypes[10];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetServerPublicInfoNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetServerPublicInfoNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetServerPublicInfoNotificationProto(GetServerPublicInfoNotificationProto other)
      : this()
    {
      this.platformType_ = other.platformType_;
      this.timeZone_ = other.timeZone_;
      this.protocolVersion_ = other.protocolVersion_ != null ? other.protocolVersion_.Clone() : (ProtocolVersionProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetServerPublicInfoNotificationProto Clone() => new GetServerPublicInfoNotificationProto(this);

    [DebuggerNonUserCode]
    public PlatformTypeProto PlatformType
    {
      get => this.platformType_;
      set => this.platformType_ = value;
    }

    [DebuggerNonUserCode]
    public PlatformTimeZoneProto TimeZone
    {
      get => this.timeZone_;
      set => this.timeZone_ = value;
    }

    [DebuggerNonUserCode]
    public ProtocolVersionProto ProtocolVersion
    {
      get => this.protocolVersion_;
      set => this.protocolVersion_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetServerPublicInfoNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetServerPublicInfoNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.PlatformType == other.PlatformType && this.TimeZone == other.TimeZone && object.Equals((object) this.ProtocolVersion, (object) other.ProtocolVersion) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.PlatformType != PlatformTypeProto.UndefinedTradingPlatform)
        num ^= this.PlatformType.GetHashCode();
      if (this.TimeZone != PlatformTimeZoneProto.UndefinedTimeZone)
        num ^= this.TimeZone.GetHashCode();
      if (this.protocolVersion_ != null)
        num ^= this.ProtocolVersion.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.PlatformType != PlatformTypeProto.UndefinedTradingPlatform)
      {
        output.WriteRawTag((byte) 8);
        output.WriteEnum((int) this.PlatformType);
      }
      if (this.TimeZone != PlatformTimeZoneProto.UndefinedTimeZone)
      {
        output.WriteRawTag((byte) 16);
        output.WriteEnum((int) this.TimeZone);
      }
      if (this.protocolVersion_ != null)
      {
        output.WriteRawTag((byte) 26);
        output.WriteMessage((IMessage) this.ProtocolVersion);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.PlatformType != PlatformTypeProto.UndefinedTradingPlatform)
        num += 1 + CodedOutputStream.ComputeEnumSize((int) this.PlatformType);
      if (this.TimeZone != PlatformTimeZoneProto.UndefinedTimeZone)
        num += 1 + CodedOutputStream.ComputeEnumSize((int) this.TimeZone);
      if (this.protocolVersion_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.ProtocolVersion);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetServerPublicInfoNotificationProto other)
    {
      if (other == null)
        return;
      if (other.PlatformType != PlatformTypeProto.UndefinedTradingPlatform)
        this.PlatformType = other.PlatformType;
      if (other.TimeZone != PlatformTimeZoneProto.UndefinedTimeZone)
        this.TimeZone = other.TimeZone;
      if (other.protocolVersion_ != null)
      {
        if (this.protocolVersion_ == null)
          this.ProtocolVersion = new ProtocolVersionProto();
        this.ProtocolVersion.MergeFrom(other.ProtocolVersion);
      }
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
            this.PlatformType = (PlatformTypeProto) input.ReadEnum();
            continue;
          case 16:
            this.TimeZone = (PlatformTimeZoneProto) input.ReadEnum();
            continue;
          case 26:
            if (this.protocolVersion_ == null)
              this.ProtocolVersion = new ProtocolVersionProto();
            input.ReadMessage((IMessage) this.ProtocolVersion);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
