// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Proto.EntityMappings.MarketDataEventSettingsMapping
// Assembly: ATPlatform.Model.Proto, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: E6EBFA31-5E2E-466E-951D-D831D69BD6FA
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.Proto.dll

using ATPlatform.IDL.MarketDataEvents;
using ATPlatform.Model.Entities;
using ATPlatform.Model.Proto.Contracts;

namespace ATPlatform.Model.Proto.EntityMappings
{
  internal class MarketDataEventSettingsMapping : 
    IProtoMapper<MarketDataEventSettingsProto, MarketDataEventSettings>
  {
    public MarketDataEventSettings ModelFromProto(
      MarketDataEventSettingsProto proto)
    {
      return new MarketDataEventSettings()
      {
        Id = proto.Id,
        MarketDataEventId = proto.MarketDataEventId,
        Type = proto.Type,
        Key = proto.Key,
        Value = proto.Value,
        Description = proto.Description
      };
    }

    public MarketDataEventSettingsProto ProtoFromModel(
      MarketDataEventSettings model)
    {
      return new MarketDataEventSettingsProto()
      {
        Id = model.Id,
        MarketDataEventId = model.MarketDataEventId,
        Type = model.Type,
        Key = model.Key,
        Value = model.Value,
        Description = model.Description
      };
    }
  }
}
