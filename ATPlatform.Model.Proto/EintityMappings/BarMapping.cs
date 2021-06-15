// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Proto.EntityMappings.BarMapping
// Assembly: ATPlatform.Model.Proto, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: E6EBFA31-5E2E-466E-951D-D831D69BD6FA
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.Proto.dll

using ATPlatform.Common.ProtoConverters;
using ATPlatform.IDL;
using ATPlatform.Model.Entities;
using ATPlatform.Model.Proto.Contracts;

namespace ATPlatform.Model.Proto.EntityMappings
{
  internal class BarMapping : IProtoMapper<HistoryQuoteProto, Bar>
  {
    public Bar ModelFromProto(HistoryQuoteProto proto) => new Bar()
    {
      MinPrice = proto.Low,
      MaxPrice = proto.High,
      StartPrice = proto.Open,
      EndPrice = proto.Close,
      EndAskPrice = proto.CloseAsk,
      CountTicks = proto.Volume,
      Time = ProtoDateTimeConverter.GetFromProto(proto.StartTimestamp),
      Timestamp = proto.StartTimestamp
    };

    public HistoryQuoteProto ProtoFromModel(Bar model) => new HistoryQuoteProto()
    {
      Low = model.MinPrice,
      High = model.MaxPrice,
      Open = model.StartPrice,
      Close = model.EndPrice,
      CloseAsk = model.EndAskPrice,
      Volume = model.CountTicks,
      StartTimestamp = model.Timestamp
    };
  }
}
