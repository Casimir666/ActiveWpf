// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Entities.ServerInfo
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

using ATPlatform.Model.Contracts;
using ATPlatform.Model.Enums;
using System.Collections.Generic;
using System.Linq;

namespace ATPlatform.Model.Entities
{
  public class ServerInfo : 
    ServerPublicInfo,
    ICloneable<ServerInfo>,
    IUpdatable<ServerInfo>,
    IEquatable<ServerInfo>
  {
    public string JournalAddress { get; set; }

    public string FeedAddress { get; set; }

    public int JournalPort { get; set; }

    public int FeedPort { get; set; }

    public IList<int> AggregationAccountIds { get; set; }

    public int HedgingBridgePort { get; set; }

    public override ATPlatform.Common.Defaults.Enums.PlatformTimeZone PlatformTimeZone { get; set; }

    public override PlatformType PlatformType { get; set; }

    public override ProtocolVersion ProtocolVersion { get; set; }

    public bool IsStpMode { get; set; }

    public int SqlPort { get; set; }

    public string HedgingBridgeAddress { get; set; }

    public string SqlAddress { get; set; }

    public int AbuseAlertPort { get; set; }

    public int ServerRouterPort { get; set; }

    public string ServerHostName { get; set; }

    public string ServerName { get; set; }

    public string AbuseAlertAddress { get; set; }

    public int ServerPublisherPort { get; set; }

    public string PlatformId { get; set; }

    public ServerInfo Clone()
    {
      ServerInfo serverInfo = new ServerInfo();
      serverInfo.Update(this);
      return serverInfo;
    }

    public void Update(ServerInfo other)
    {
      this.JournalAddress = other.JournalAddress;
      this.FeedAddress = other.FeedAddress;
      this.JournalPort = other.JournalPort;
      this.FeedPort = other.FeedPort;
      this.AggregationAccountIds = other.AggregationAccountIds;
      this.HedgingBridgePort = other.HedgingBridgePort;
      this.PlatformTimeZone = other.PlatformTimeZone;
      this.PlatformType = other.PlatformType;
      this.ProtocolVersion = other.ProtocolVersion;
      this.IsStpMode = other.IsStpMode;
      this.SqlPort = other.SqlPort;
      this.HedgingBridgeAddress = other.HedgingBridgeAddress;
      this.SqlAddress = other.SqlAddress;
      this.AbuseAlertPort = other.AbuseAlertPort;
      this.ServerRouterPort = other.ServerRouterPort;
      this.ServerHostName = other.ServerHostName;
      this.ServerName = other.ServerName;
      this.AbuseAlertAddress = other.AbuseAlertAddress;
      this.ServerPublisherPort = other.ServerPublisherPort;
      this.PlatformId = other.PlatformId;
    }

    public bool Equals(ServerInfo other) => this.JournalAddress == other.JournalAddress && this.FeedAddress == other.FeedAddress && (this.JournalPort == other.JournalPort && this.FeedPort == other.FeedPort) && (!this.AggregationAccountIds.Except<int>((IEnumerable<int>) other.AggregationAccountIds).Any<int>() && this.HedgingBridgePort == other.HedgingBridgePort && (this.PlatformTimeZone == other.PlatformTimeZone && this.PlatformType == other.PlatformType)) && (this.ProtocolVersion.Equals(other.ProtocolVersion) && this.IsStpMode == other.IsStpMode && (this.SqlPort == other.SqlPort && this.HedgingBridgeAddress == other.HedgingBridgeAddress) && (this.SqlAddress == other.SqlAddress && this.AbuseAlertPort == other.AbuseAlertPort && (this.ServerRouterPort == other.ServerRouterPort && this.ServerHostName == other.ServerHostName))) && (this.ServerName == other.ServerName && this.AbuseAlertAddress == other.AbuseAlertAddress && this.ServerPublisherPort == other.ServerPublisherPort) && this.PlatformId == other.PlatformId;
  }
}
