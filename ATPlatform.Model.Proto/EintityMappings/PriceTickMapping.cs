// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Proto.EntityMappings.PriceTickMapping
// Assembly: ATPlatform.Model.Proto, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: E6EBFA31-5E2E-466E-951D-D831D69BD6FA
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.Proto.dll

using ATPlatform.Common.ProtoConverters;
using ATPlatform.IDL;
using ATPlatform.Model.Entities;
using ATPlatform.Model.Proto.Contracts;
using System;

namespace ATPlatform.Model.Proto.EntityMappings
{
  internal class PriceTickMapping : IProtoMapper<TickProto, Tick>
  {
    public Tick ModelFromProto(TickProto proto) => new Tick()
    {
      Ask = (double) proto.Ask / Math.Pow(10.0, (double) proto.Digits),
      Bid = (double) proto.Bid / Math.Pow(10.0, (double) proto.Digits),
      SymbolId = proto.Symbol,
      Digits = proto.Digits,
      TimeStamp = ProtoDateTimeConverter.GetFromProto(proto.Timestamp)
    };

    public TickProto ProtoFromModel(Tick model) => new TickProto()
    {
      Ask = (int) Math.Round(model.Ask * Math.Pow(10.0, (double) model.Digits), MidpointRounding.AwayFromZero),
      Bid = (int) Math.Round(model.Bid * Math.Pow(10.0, (double) model.Digits), MidpointRounding.AwayFromZero),
      Symbol = model.SymbolId,
      Digits = model.Digits,
      Timestamp = ProtoDateTimeConverter.GetFromModel(model.TimeStamp)
    };
  }
}
