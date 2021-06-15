// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Proto.EntityMappings.MarketDataEventTagMapping
// Assembly: ATPlatform.Model.Proto, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: E6EBFA31-5E2E-466E-951D-D831D69BD6FA
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.Proto.dll

using ATPlatform.Common.Defaults;
using ATPlatform.IDL;
using ATPlatform.IDL.MarketDataEvents;
using ATPlatform.Model.Entities;
using ATPlatform.Model.Proto.Contracts;

namespace ATPlatform.Model.Proto.EntityMappings
{
  internal class MarketDataEventTagMapping : 
    IProtoMapper<MarketDataEventTagProto, MarketDataEventTag>
  {
    public MarketDataEventTag ModelFromProto(MarketDataEventTagProto proto) => new MarketDataEventTag()
    {
      Id = proto.Id,
      MarketDataEventId = proto.MarketDataEventId,
      Tag = (TagType) proto.Tag,
      Value = proto.Value
    };

    public MarketDataEventTagProto ProtoFromModel(MarketDataEventTag model) => new MarketDataEventTagProto()
    {
      Id = model.Id,
      MarketDataEventId = model.MarketDataEventId,
      Tag = (TagTypeProto) model.Tag,
      Value = model.Value
    };
  }
}
