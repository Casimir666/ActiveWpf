// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Proto.EntityMappings.ServerPublicInfoMapping
// Assembly: ATPlatform.Model.Proto, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: E6EBFA31-5E2E-466E-951D-D831D69BD6FA
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.Proto.dll

using ATPlatform.IDL;
using ATPlatform.Model.Entities;
using ATPlatform.Model.Enums;
using ATPlatform.Model.Proto.Contracts;

namespace ATPlatform.Model.Proto.EntityMappings
{
  internal class ServerPublicInfoMapping : 
    IProtoMapper<GetServerPublicInfoNotificationProto, ServerPublicInfo>
  {
    private readonly ProtocolVersionMapping _protocolVersionMapping = new ProtocolVersionMapping();

    public ServerPublicInfo ModelFromProto(
      GetServerPublicInfoNotificationProto proto)
    {
      return new ServerPublicInfo()
      {
        PlatformTimeZone = (ATPlatform.Common.Defaults.Enums.PlatformTimeZone) proto.TimeZone,
        PlatformType = (PlatformType) proto.PlatformType,
        ProtocolVersion = this._protocolVersionMapping.ModelFromProto(proto.ProtocolVersion)
      };
    }

    public GetServerPublicInfoNotificationProto ProtoFromModel(
      ServerPublicInfo model)
    {
      return new GetServerPublicInfoNotificationProto()
      {
        TimeZone = (PlatformTimeZoneProto) model.PlatformTimeZone,
        PlatformType = (PlatformTypeProto) model.PlatformType,
        ProtocolVersion = this._protocolVersionMapping.ProtoFromModel(model.ProtocolVersion)
      };
    }
  }
}
