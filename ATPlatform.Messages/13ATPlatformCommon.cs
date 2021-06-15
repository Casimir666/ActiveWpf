// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.GetServerInfoNotificationProto
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
  public sealed class GetServerInfoNotificationProto : 
    IMessage<GetServerInfoNotificationProto>,
    IMessage,
    IEquatable<GetServerInfoNotificationProto>,
    IDeepCloneable<GetServerInfoNotificationProto>
  {
    private static readonly MessageParser<GetServerInfoNotificationProto> _parser = new MessageParser<GetServerInfoNotificationProto>((Func<GetServerInfoNotificationProto>) (() => new GetServerInfoNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int ServerNameFieldNumber = 1;
    private string serverName_ = "";
    public const int ServerHostNameFieldNumber = 2;
    private string serverHostName_ = "";
    public const int ServerRouterPortFieldNumber = 3;
    private int serverRouterPort_;
    public const int ServerPublisherPortFieldNumber = 4;
    private int serverPublisherPort_;
    public const int SqlAddressFieldNumber = 5;
    private string sqlAddress_ = "";
    public const int SqlPortFieldNumber = 6;
    private int sqlPort_;
    public const int JournalAddressFieldNumber = 7;
    private string journalAddress_ = "";
    public const int JournalPortFieldNumber = 8;
    private int journalPort_;
    public const int FeedAddressFieldNumber = 9;
    private string feedAddress_ = "";
    public const int FeedPortFieldNumber = 10;
    private int feedPort_;
    public const int HedgingBridgeAddressFieldNumber = 11;
    private string hedgingBridgeAddress_ = "";
    public const int HedgingBridgePortFieldNumber = 12;
    private int hedgingBridgePort_;
    public const int TimeZoneFieldNumber = 13;
    private PlatformTimeZoneProto timeZone_;
    public const int PlatformTypeFieldNumber = 14;
    private PlatformTypeProto platformType_;
    public const int ProtocolVersionFieldNumber = 15;
    private ProtocolVersionProto protocolVersion_;
    public const int AggregationAccountIdsFieldNumber = 16;
    private static readonly FieldCodec<int> _repeated_aggregationAccountIds_codec = FieldCodec.ForInt32(130U);
    private readonly RepeatedField<int> aggregationAccountIds_ = new RepeatedField<int>();
    public const int IsStpModeFieldNumber = 17;
    private bool isStpMode_;
    public const int AbuseAlertAddressFieldNumber = 18;
    private string abuseAlertAddress_ = "";
    public const int AbuseAlertPortFieldNumber = 19;
    private int abuseAlertPort_;
    public const int PlatformIdFieldNumber = 20;
    private string platformId_ = "";

    [DebuggerNonUserCode]
    public static MessageParser<GetServerInfoNotificationProto> Parser => GetServerInfoNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformCommonReflection.Descriptor.MessageTypes[12];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetServerInfoNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public GetServerInfoNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public GetServerInfoNotificationProto(GetServerInfoNotificationProto other)
      : this()
    {
      this.serverName_ = other.serverName_;
      this.serverHostName_ = other.serverHostName_;
      this.serverRouterPort_ = other.serverRouterPort_;
      this.serverPublisherPort_ = other.serverPublisherPort_;
      this.sqlAddress_ = other.sqlAddress_;
      this.sqlPort_ = other.sqlPort_;
      this.journalAddress_ = other.journalAddress_;
      this.journalPort_ = other.journalPort_;
      this.feedAddress_ = other.feedAddress_;
      this.feedPort_ = other.feedPort_;
      this.hedgingBridgeAddress_ = other.hedgingBridgeAddress_;
      this.hedgingBridgePort_ = other.hedgingBridgePort_;
      this.timeZone_ = other.timeZone_;
      this.platformType_ = other.platformType_;
      this.protocolVersion_ = other.protocolVersion_ != null ? other.protocolVersion_.Clone() : (ProtocolVersionProto) null;
      this.aggregationAccountIds_ = other.aggregationAccountIds_.Clone();
      this.isStpMode_ = other.isStpMode_;
      this.abuseAlertAddress_ = other.abuseAlertAddress_;
      this.abuseAlertPort_ = other.abuseAlertPort_;
      this.platformId_ = other.platformId_;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetServerInfoNotificationProto Clone() => new GetServerInfoNotificationProto(this);

    [DebuggerNonUserCode]
    public string ServerName
    {
      get => this.serverName_;
      set => this.serverName_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public string ServerHostName
    {
      get => this.serverHostName_;
      set => this.serverHostName_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public int ServerRouterPort
    {
      get => this.serverRouterPort_;
      set => this.serverRouterPort_ = value;
    }

    [DebuggerNonUserCode]
    public int ServerPublisherPort
    {
      get => this.serverPublisherPort_;
      set => this.serverPublisherPort_ = value;
    }

    [DebuggerNonUserCode]
    public string SqlAddress
    {
      get => this.sqlAddress_;
      set => this.sqlAddress_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public int SqlPort
    {
      get => this.sqlPort_;
      set => this.sqlPort_ = value;
    }

    [DebuggerNonUserCode]
    public string JournalAddress
    {
      get => this.journalAddress_;
      set => this.journalAddress_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public int JournalPort
    {
      get => this.journalPort_;
      set => this.journalPort_ = value;
    }

    [DebuggerNonUserCode]
    public string FeedAddress
    {
      get => this.feedAddress_;
      set => this.feedAddress_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public int FeedPort
    {
      get => this.feedPort_;
      set => this.feedPort_ = value;
    }

    [DebuggerNonUserCode]
    public string HedgingBridgeAddress
    {
      get => this.hedgingBridgeAddress_;
      set => this.hedgingBridgeAddress_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public int HedgingBridgePort
    {
      get => this.hedgingBridgePort_;
      set => this.hedgingBridgePort_ = value;
    }

    [DebuggerNonUserCode]
    public PlatformTimeZoneProto TimeZone
    {
      get => this.timeZone_;
      set => this.timeZone_ = value;
    }

    [DebuggerNonUserCode]
    public PlatformTypeProto PlatformType
    {
      get => this.platformType_;
      set => this.platformType_ = value;
    }

    [DebuggerNonUserCode]
    public ProtocolVersionProto ProtocolVersion
    {
      get => this.protocolVersion_;
      set => this.protocolVersion_ = value;
    }

    [DebuggerNonUserCode]
    public RepeatedField<int> AggregationAccountIds => this.aggregationAccountIds_;

    [DebuggerNonUserCode]
    public bool IsStpMode
    {
      get => this.isStpMode_;
      set => this.isStpMode_ = value;
    }

    [DebuggerNonUserCode]
    public string AbuseAlertAddress
    {
      get => this.abuseAlertAddress_;
      set => this.abuseAlertAddress_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public int AbuseAlertPort
    {
      get => this.abuseAlertPort_;
      set => this.abuseAlertPort_ = value;
    }

    [DebuggerNonUserCode]
    public string PlatformId
    {
      get => this.platformId_;
      set => this.platformId_ = ProtoPreconditions.CheckNotNull<string>(value, nameof (value));
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetServerInfoNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(GetServerInfoNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return !(this.ServerName != other.ServerName) && !(this.ServerHostName != other.ServerHostName) && (this.ServerRouterPort == other.ServerRouterPort && this.ServerPublisherPort == other.ServerPublisherPort) && (!(this.SqlAddress != other.SqlAddress) && this.SqlPort == other.SqlPort && (!(this.JournalAddress != other.JournalAddress) && this.JournalPort == other.JournalPort)) && (!(this.FeedAddress != other.FeedAddress) && this.FeedPort == other.FeedPort && (!(this.HedgingBridgeAddress != other.HedgingBridgeAddress) && this.HedgingBridgePort == other.HedgingBridgePort) && (this.TimeZone == other.TimeZone && this.PlatformType == other.PlatformType && (object.Equals((object) this.ProtocolVersion, (object) other.ProtocolVersion) && this.aggregationAccountIds_.Equals(other.aggregationAccountIds_)))) && (this.IsStpMode == other.IsStpMode && !(this.AbuseAlertAddress != other.AbuseAlertAddress) && (this.AbuseAlertPort == other.AbuseAlertPort && !(this.PlatformId != other.PlatformId))) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num1 = 1;
      if (this.ServerName.Length != 0)
        num1 ^= this.ServerName.GetHashCode();
      if (this.ServerHostName.Length != 0)
        num1 ^= this.ServerHostName.GetHashCode();
      if (this.ServerRouterPort != 0)
        num1 ^= this.ServerRouterPort.GetHashCode();
      if (this.ServerPublisherPort != 0)
        num1 ^= this.ServerPublisherPort.GetHashCode();
      if (this.SqlAddress.Length != 0)
        num1 ^= this.SqlAddress.GetHashCode();
      if (this.SqlPort != 0)
        num1 ^= this.SqlPort.GetHashCode();
      if (this.JournalAddress.Length != 0)
        num1 ^= this.JournalAddress.GetHashCode();
      if (this.JournalPort != 0)
        num1 ^= this.JournalPort.GetHashCode();
      if (this.FeedAddress.Length != 0)
        num1 ^= this.FeedAddress.GetHashCode();
      if (this.FeedPort != 0)
        num1 ^= this.FeedPort.GetHashCode();
      if (this.HedgingBridgeAddress.Length != 0)
        num1 ^= this.HedgingBridgeAddress.GetHashCode();
      if (this.HedgingBridgePort != 0)
        num1 ^= this.HedgingBridgePort.GetHashCode();
      if (this.TimeZone != PlatformTimeZoneProto.UndefinedTimeZone)
        num1 ^= this.TimeZone.GetHashCode();
      if (this.PlatformType != PlatformTypeProto.UndefinedTradingPlatform)
        num1 ^= this.PlatformType.GetHashCode();
      if (this.protocolVersion_ != null)
        num1 ^= this.ProtocolVersion.GetHashCode();
      int num2 = num1 ^ this.aggregationAccountIds_.GetHashCode();
      if (this.IsStpMode)
        num2 ^= this.IsStpMode.GetHashCode();
      if (this.AbuseAlertAddress.Length != 0)
        num2 ^= this.AbuseAlertAddress.GetHashCode();
      if (this.AbuseAlertPort != 0)
        num2 ^= this.AbuseAlertPort.GetHashCode();
      if (this.PlatformId.Length != 0)
        num2 ^= this.PlatformId.GetHashCode();
      if (this._unknownFields != null)
        num2 ^= this._unknownFields.GetHashCode();
      return num2;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.ServerName.Length != 0)
      {
        output.WriteRawTag((byte) 10);
        output.WriteString(this.ServerName);
      }
      if (this.ServerHostName.Length != 0)
      {
        output.WriteRawTag((byte) 18);
        output.WriteString(this.ServerHostName);
      }
      if (this.ServerRouterPort != 0)
      {
        output.WriteRawTag((byte) 24);
        output.WriteInt32(this.ServerRouterPort);
      }
      if (this.ServerPublisherPort != 0)
      {
        output.WriteRawTag((byte) 32);
        output.WriteInt32(this.ServerPublisherPort);
      }
      if (this.SqlAddress.Length != 0)
      {
        output.WriteRawTag((byte) 42);
        output.WriteString(this.SqlAddress);
      }
      if (this.SqlPort != 0)
      {
        output.WriteRawTag((byte) 48);
        output.WriteInt32(this.SqlPort);
      }
      if (this.JournalAddress.Length != 0)
      {
        output.WriteRawTag((byte) 58);
        output.WriteString(this.JournalAddress);
      }
      if (this.JournalPort != 0)
      {
        output.WriteRawTag((byte) 64);
        output.WriteInt32(this.JournalPort);
      }
      if (this.FeedAddress.Length != 0)
      {
        output.WriteRawTag((byte) 74);
        output.WriteString(this.FeedAddress);
      }
      if (this.FeedPort != 0)
      {
        output.WriteRawTag((byte) 80);
        output.WriteInt32(this.FeedPort);
      }
      if (this.HedgingBridgeAddress.Length != 0)
      {
        output.WriteRawTag((byte) 90);
        output.WriteString(this.HedgingBridgeAddress);
      }
      if (this.HedgingBridgePort != 0)
      {
        output.WriteRawTag((byte) 96);
        output.WriteInt32(this.HedgingBridgePort);
      }
      if (this.TimeZone != PlatformTimeZoneProto.UndefinedTimeZone)
      {
        output.WriteRawTag((byte) 104);
        output.WriteEnum((int) this.TimeZone);
      }
      if (this.PlatformType != PlatformTypeProto.UndefinedTradingPlatform)
      {
        output.WriteRawTag((byte) 112);
        output.WriteEnum((int) this.PlatformType);
      }
      if (this.protocolVersion_ != null)
      {
        output.WriteRawTag((byte) 122);
        output.WriteMessage((IMessage) this.ProtocolVersion);
      }
      this.aggregationAccountIds_.WriteTo(output, GetServerInfoNotificationProto._repeated_aggregationAccountIds_codec);
      if (this.IsStpMode)
      {
        output.WriteRawTag((byte) 136, (byte) 1);
        output.WriteBool(this.IsStpMode);
      }
      if (this.AbuseAlertAddress.Length != 0)
      {
        output.WriteRawTag((byte) 146, (byte) 1);
        output.WriteString(this.AbuseAlertAddress);
      }
      if (this.AbuseAlertPort != 0)
      {
        output.WriteRawTag((byte) 152, (byte) 1);
        output.WriteInt32(this.AbuseAlertPort);
      }
      if (this.PlatformId.Length != 0)
      {
        output.WriteRawTag((byte) 162, (byte) 1);
        output.WriteString(this.PlatformId);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num1 = 0;
      if (this.ServerName.Length != 0)
        num1 += 1 + CodedOutputStream.ComputeStringSize(this.ServerName);
      if (this.ServerHostName.Length != 0)
        num1 += 1 + CodedOutputStream.ComputeStringSize(this.ServerHostName);
      if (this.ServerRouterPort != 0)
        num1 += 1 + CodedOutputStream.ComputeInt32Size(this.ServerRouterPort);
      if (this.ServerPublisherPort != 0)
        num1 += 1 + CodedOutputStream.ComputeInt32Size(this.ServerPublisherPort);
      if (this.SqlAddress.Length != 0)
        num1 += 1 + CodedOutputStream.ComputeStringSize(this.SqlAddress);
      if (this.SqlPort != 0)
        num1 += 1 + CodedOutputStream.ComputeInt32Size(this.SqlPort);
      if (this.JournalAddress.Length != 0)
        num1 += 1 + CodedOutputStream.ComputeStringSize(this.JournalAddress);
      if (this.JournalPort != 0)
        num1 += 1 + CodedOutputStream.ComputeInt32Size(this.JournalPort);
      if (this.FeedAddress.Length != 0)
        num1 += 1 + CodedOutputStream.ComputeStringSize(this.FeedAddress);
      if (this.FeedPort != 0)
        num1 += 1 + CodedOutputStream.ComputeInt32Size(this.FeedPort);
      if (this.HedgingBridgeAddress.Length != 0)
        num1 += 1 + CodedOutputStream.ComputeStringSize(this.HedgingBridgeAddress);
      if (this.HedgingBridgePort != 0)
        num1 += 1 + CodedOutputStream.ComputeInt32Size(this.HedgingBridgePort);
      if (this.TimeZone != PlatformTimeZoneProto.UndefinedTimeZone)
        num1 += 1 + CodedOutputStream.ComputeEnumSize((int) this.TimeZone);
      if (this.PlatformType != PlatformTypeProto.UndefinedTradingPlatform)
        num1 += 1 + CodedOutputStream.ComputeEnumSize((int) this.PlatformType);
      if (this.protocolVersion_ != null)
        num1 += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.ProtocolVersion);
      int num2 = num1 + this.aggregationAccountIds_.CalculateSize(GetServerInfoNotificationProto._repeated_aggregationAccountIds_codec);
      if (this.IsStpMode)
        num2 += 3;
      if (this.AbuseAlertAddress.Length != 0)
        num2 += 2 + CodedOutputStream.ComputeStringSize(this.AbuseAlertAddress);
      if (this.AbuseAlertPort != 0)
        num2 += 2 + CodedOutputStream.ComputeInt32Size(this.AbuseAlertPort);
      if (this.PlatformId.Length != 0)
        num2 += 2 + CodedOutputStream.ComputeStringSize(this.PlatformId);
      if (this._unknownFields != null)
        num2 += this._unknownFields.CalculateSize();
      return num2;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetServerInfoNotificationProto other)
    {
      if (other == null)
        return;
      if (other.ServerName.Length != 0)
        this.ServerName = other.ServerName;
      if (other.ServerHostName.Length != 0)
        this.ServerHostName = other.ServerHostName;
      if (other.ServerRouterPort != 0)
        this.ServerRouterPort = other.ServerRouterPort;
      if (other.ServerPublisherPort != 0)
        this.ServerPublisherPort = other.ServerPublisherPort;
      if (other.SqlAddress.Length != 0)
        this.SqlAddress = other.SqlAddress;
      if (other.SqlPort != 0)
        this.SqlPort = other.SqlPort;
      if (other.JournalAddress.Length != 0)
        this.JournalAddress = other.JournalAddress;
      if (other.JournalPort != 0)
        this.JournalPort = other.JournalPort;
      if (other.FeedAddress.Length != 0)
        this.FeedAddress = other.FeedAddress;
      if (other.FeedPort != 0)
        this.FeedPort = other.FeedPort;
      if (other.HedgingBridgeAddress.Length != 0)
        this.HedgingBridgeAddress = other.HedgingBridgeAddress;
      if (other.HedgingBridgePort != 0)
        this.HedgingBridgePort = other.HedgingBridgePort;
      if (other.TimeZone != PlatformTimeZoneProto.UndefinedTimeZone)
        this.TimeZone = other.TimeZone;
      if (other.PlatformType != PlatformTypeProto.UndefinedTradingPlatform)
        this.PlatformType = other.PlatformType;
      if (other.protocolVersion_ != null)
      {
        if (this.protocolVersion_ == null)
          this.ProtocolVersion = new ProtocolVersionProto();
        this.ProtocolVersion.MergeFrom(other.ProtocolVersion);
      }
      this.aggregationAccountIds_.Add((IEnumerable<int>) other.aggregationAccountIds_);
      if (other.IsStpMode)
        this.IsStpMode = other.IsStpMode;
      if (other.AbuseAlertAddress.Length != 0)
        this.AbuseAlertAddress = other.AbuseAlertAddress;
      if (other.AbuseAlertPort != 0)
        this.AbuseAlertPort = other.AbuseAlertPort;
      if (other.PlatformId.Length != 0)
        this.PlatformId = other.PlatformId;
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
          case 10:
            this.ServerName = input.ReadString();
            continue;
          case 18:
            this.ServerHostName = input.ReadString();
            continue;
          case 24:
            this.ServerRouterPort = input.ReadInt32();
            continue;
          case 32:
            this.ServerPublisherPort = input.ReadInt32();
            continue;
          case 42:
            this.SqlAddress = input.ReadString();
            continue;
          case 48:
            this.SqlPort = input.ReadInt32();
            continue;
          case 58:
            this.JournalAddress = input.ReadString();
            continue;
          case 64:
            this.JournalPort = input.ReadInt32();
            continue;
          case 74:
            this.FeedAddress = input.ReadString();
            continue;
          case 80:
            this.FeedPort = input.ReadInt32();
            continue;
          case 90:
            this.HedgingBridgeAddress = input.ReadString();
            continue;
          case 96:
            this.HedgingBridgePort = input.ReadInt32();
            continue;
          case 104:
            this.TimeZone = (PlatformTimeZoneProto) input.ReadEnum();
            continue;
          case 112:
            this.PlatformType = (PlatformTypeProto) input.ReadEnum();
            continue;
          case 122:
            if (this.protocolVersion_ == null)
              this.ProtocolVersion = new ProtocolVersionProto();
            input.ReadMessage((IMessage) this.ProtocolVersion);
            continue;
          case 128:
          case 130:
            this.aggregationAccountIds_.AddEntriesFrom(input, GetServerInfoNotificationProto._repeated_aggregationAccountIds_codec);
            continue;
          case 136:
            this.IsStpMode = input.ReadBool();
            continue;
          case 146:
            this.AbuseAlertAddress = input.ReadString();
            continue;
          case 152:
            this.AbuseAlertPort = input.ReadInt32();
            continue;
          case 162:
            this.PlatformId = input.ReadString();
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
