// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Proto.EntityMappings.OrderRequestMapping
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
  internal class OrderRequestMapping : IProtoMapper<OrderRequestProto, OrderRequest>
  {
    public OrderRequest ModelFromProto(OrderRequestProto proto) => throw new NotImplementedException();

    public OrderRequestProto ProtoFromModel(OrderRequest model) => new OrderRequestProto()
    {
      OrderId = model.OrderId,
      AccountId = model.AccountId,
      Symbol = ProtoNullableStringConverter.GetFromModel(model.Symbol),
      Type = (OrderTypeProto) model.OrderType,
      Lots = model.Lots,
      Price = model.Price,
      StopLoss = ProtoNullableNumberConverter.GetFromModel(new double?(model.StopLoss)),
      TakeProfit = ProtoNullableNumberConverter.GetFromModel(new double?(model.TakeProfit)),
      Expiration = ProtoNullableDateTimeConverter.GetFromModel(model.Expiration),
      TrailingStopTier1Threshold = model.TrailingStopTier1Threshold,
      TrailingStopTier1 = model.TrailingStopTier1,
      TrailingStopTier2Threshold = model.TrailingStopTier2Threshold,
      TrailingStopTier2 = model.TrailingStopTier2,
      TrailingStopTier3Threshold = model.TrailingStopTier3Threshold,
      TrailingStopTier3 = model.TrailingStopTier3
    };
  }
}
