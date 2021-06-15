// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Proto.EntityMappings.MarketDataEventTranslationMapping
// Assembly: ATPlatform.Model.Proto, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: E6EBFA31-5E2E-466E-951D-D831D69BD6FA
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.Proto.dll

using ATPlatform.IDL.MarketDataEvents;
using ATPlatform.Model.Entities;
using ATPlatform.Model.Proto.Contracts;

namespace ATPlatform.Model.Proto.EntityMappings
{
  internal class MarketDataEventTranslationMapping : 
    IProtoMapper<MarketDataEventTranslationProto, MarketDataEventTranslation>
  {
    public MarketDataEventTranslation ModelFromProto(
      MarketDataEventTranslationProto proto)
    {
      return new MarketDataEventTranslation()
      {
        Id = proto.Id,
        MarketDataEventId = proto.MarketDataEventId,
        Language = proto.Language,
        Subject = proto.Subject,
        Body = proto.Body
      };
    }

    public MarketDataEventTranslationProto ProtoFromModel(
      MarketDataEventTranslation model)
    {
      return new MarketDataEventTranslationProto()
      {
        Id = model.Id,
        MarketDataEventId = model.MarketDataEventId,
        Language = model.Language,
        Subject = model.Subject,
        Body = model.Body
      };
    }
  }
}
