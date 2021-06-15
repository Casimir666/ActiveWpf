// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Proto.EntityMappings.ServerInfoMapping
// Assembly: ATPlatform.Model.Proto, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: E6EBFA31-5E2E-466E-951D-D831D69BD6FA
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.Proto.dll

using ATPlatform.IDL;
using ATPlatform.Model.Entities;
using ATPlatform.Model.Enums;
using ATPlatform.Model.Proto.Contracts;
using System.Collections.Generic;

namespace ATPlatform.Model.Proto.EntityMappings
{
  internal class ServerInfoMapping : IProtoMapper<GetServerInfoNotificationProto, ServerInfo>
  {
    private readonly ProtocolVersionMapping _protocolVersionMapping = new ProtocolVersionMapping();

    public ServerInfo ModelFromProto(GetServerInfoNotificationProto proto)
    {
      ServerInfo serverInfo = new ServerInfo();
      serverInfo.JournalAddress = proto.JournalAddress;
      serverInfo.FeedAddress = proto.FeedAddress;
      serverInfo.JournalPort = proto.JournalPort;
      serverInfo.FeedPort = proto.FeedPort;
      serverInfo.AggregationAccountIds = (IList<int>) proto.AggregationAccountIds;
      serverInfo.HedgingBridgePort = proto.HedgingBridgePort;
      serverInfo.PlatformTimeZone = (ATPlatform.Common.Defaults.Enums.PlatformTimeZone) proto.TimeZone;
      serverInfo.PlatformType = (PlatformType) proto.PlatformType;
      serverInfo.ProtocolVersion = this._protocolVersionMapping.ModelFromProto(proto.ProtocolVersion);
      serverInfo.IsStpMode = proto.IsStpMode;
      serverInfo.SqlPort = proto.SqlPort;
      serverInfo.HedgingBridgeAddress = proto.HedgingBridgeAddress;
      serverInfo.SqlAddress = proto.SqlAddress;
      serverInfo.AbuseAlertPort = proto.AbuseAlertPort;
      serverInfo.ServerRouterPort = proto.ServerRouterPort;
      serverInfo.ServerHostName = proto.ServerHostName;
      serverInfo.ServerName = proto.ServerName;
      serverInfo.AbuseAlertAddress = proto.AbuseAlertAddress;
      serverInfo.ServerPublisherPort = proto.ServerPublisherPort;
      serverInfo.PlatformId = proto.PlatformId;
      return serverInfo;
    }

    public GetServerInfoNotificationProto ProtoFromModel(
      ServerInfo model)
    {
      GetServerInfoNotificationProto notificationProto = new GetServerInfoNotificationProto();
      notificationProto.JournalAddress = model.JournalAddress;
      notificationProto.FeedAddress = model.FeedAddress;
      notificationProto.JournalPort = model.JournalPort;
      notificationProto.FeedPort = model.FeedPort;
      notificationProto.HedgingBridgePort = model.HedgingBridgePort;
      notificationProto.TimeZone = (PlatformTimeZoneProto) model.PlatformTimeZone;
      notificationProto.PlatformType = (PlatformTypeProto) model.PlatformType;
      notificationProto.ProtocolVersion = this._protocolVersionMapping.ProtoFromModel(model.ProtocolVersion);
      notificationProto.IsStpMode = model.IsStpMode;
      notificationProto.SqlPort = model.SqlPort;
      notificationProto.HedgingBridgeAddress = model.HedgingBridgeAddress;
      notificationProto.SqlAddress = model.SqlAddress;
      notificationProto.AbuseAlertPort = model.AbuseAlertPort;
      notificationProto.ServerRouterPort = model.ServerRouterPort;
      notificationProto.ServerHostName = model.ServerHostName;
      notificationProto.ServerName = model.ServerName;
      notificationProto.AbuseAlertAddress = model.AbuseAlertAddress;
      notificationProto.ServerPublisherPort = model.ServerPublisherPort;
      notificationProto.PlatformId = model.PlatformId;
      notificationProto.AggregationAccountIds.AddRange((IEnumerable<int>) model.AggregationAccountIds);
      return notificationProto;
    }
  }
}
