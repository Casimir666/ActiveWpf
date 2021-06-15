// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Proto.EntityMappings.OrderMapping
// Assembly: ATPlatform.Model.Proto, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: E6EBFA31-5E2E-466E-951D-D831D69BD6FA
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.Proto.dll

using ATPlatform.Common.ProtoConverters;
using ATPlatform.IDL;
using ATPlatform.Model.Enums.Order;
using ATPlatform.Model.Proto.Contracts;

namespace ATPlatform.Model.Proto.EntityMappings
{
  internal class OrderMapping : IProtoMapper<OrderProto, ATPlatform.Model.Entities.Order>
  {
    public ATPlatform.Model.Entities.Order ModelFromProto(OrderProto proto) => new ATPlatform.Model.Entities.Order()
    {
      Id = proto.Id,
      OrderExecutionId = proto.OrderExecutionId,
      ParentOrderId = ProtoNullableNumberConverter.GetFromProto(proto.ParentOrderId),
      AccountId = proto.AccountId,
      CloseHedgedOrderId = ProtoNullableNumberConverter.GetFromProto(proto.CloseHedgedOrderId),
      Symbol = proto.Symbol,
      OrderType = (OrderType) proto.OrderType,
      Lots = proto.Lots,
      OpenTime = ProtoDateTimeConverter.GetFromProto(proto.OpenTime),
      CloseTime = ProtoNullableDateTimeConverter.GetFromProto(proto.CloseTime),
      LastExecutionTime = ProtoDateTimeConverter.GetFromProto(proto.LastExecutionTime),
      State = (OrderState) proto.State,
      OrderTransactionType = (OrderTransactionType) proto.OrderTransactionType,
      MarginConversionRate = proto.MarginConversionRate,
      OpenPrice = proto.OpenPrice,
      ProfitConversionRate = proto.ProfitConversionRate,
      ClosePrice = proto.ClosePrice,
      TrailingStopTier1 = ProtoNullableNumberConverter.GetFromProto(proto.TrailingStopTier1),
      TrailingStopTier1Threshold = ProtoNullableNumberConverter.GetFromProto(proto.TrailingStopTier1Threshold),
      TrailingStopTier2 = ProtoNullableNumberConverter.GetFromProto(proto.TrailingStopTier2),
      TrailingStopTier2Threshold = ProtoNullableNumberConverter.GetFromProto(proto.TrailingStopTier2Threshold),
      TrailingStopTier3 = ProtoNullableNumberConverter.GetFromProto(proto.TrailingStopTier3),
      TrailingStopTier3Threshold = ProtoNullableNumberConverter.GetFromProto(proto.TrailingStopTier3Threshold),
      StopLoss = ProtoNullableNumberConverter.GetFromProto(proto.StopLoss),
      GuaranteedStopLoss = ProtoNullableNumberConverter.GetFromProto(proto.GuaranteedStopLoss),
      TakeProfit = ProtoNullableNumberConverter.GetFromProto(proto.TakeProfit),
      Expiration = ProtoNullableDateTimeConverter.GetFromProto(proto.Expiration),
      Commission = proto.Commission,
      Swap = proto.Swap,
      Profit = proto.Profit,
      StopOutEquity = ProtoNullableNumberConverter.GetFromProto(proto.StopOutEquity),
      StopOutMargin = ProtoNullableNumberConverter.GetFromProto(proto.StopOutMargin),
      PullbackTrailingStopTier1 = ProtoNullableNumberConverter.GetFromProto(proto.PullbackTrailingStopTier1),
      PullbackTrailingStopTier1Threshold = ProtoNullableNumberConverter.GetFromProto(proto.PullbackTrailingStopTier1Threshold),
      PullbackTrailingStopTier2 = ProtoNullableNumberConverter.GetFromProto(proto.PullbackTrailingStopTier2),
      PullbackTrailingStopTier2Threshold = ProtoNullableNumberConverter.GetFromProto(proto.PullbackTrailingStopTier2Threshold),
      PullbackTrailingStopTier3 = ProtoNullableNumberConverter.GetFromProto(proto.PullbackTrailingStopTier3),
      PullbackTrailingStopTier3Threshold = ProtoNullableNumberConverter.GetFromProto(proto.PullbackTrailingStopTier3Threshold)
    };

    public OrderProto ProtoFromModel(ATPlatform.Model.Entities.Order model) => new OrderProto()
    {
      Id = model.Id,
      OrderExecutionId = model.OrderExecutionId,
      ParentOrderId = ProtoNullableNumberConverter.GetFromModel(model.ParentOrderId),
      AccountId = model.AccountId,
      CloseHedgedOrderId = ProtoNullableNumberConverter.GetFromModel(model.CloseHedgedOrderId),
      Symbol = model.Symbol,
      OrderType = (OrderTypeProto) model.OrderType,
      Lots = model.Lots,
      OpenTime = ProtoDateTimeConverter.GetFromModel(model.OpenTime),
      CloseTime = ProtoNullableDateTimeConverter.GetFromModel(model.CloseTime),
      LastExecutionTime = ProtoDateTimeConverter.GetFromModel(model.LastExecutionTime),
      State = (OrderStateProto) model.State,
      OrderTransactionType = (OrderTransactionTypeProto) model.OrderTransactionType,
      MarginConversionRate = model.MarginConversionRate,
      OpenPrice = model.OpenPrice,
      ProfitConversionRate = model.ProfitConversionRate,
      ClosePrice = model.ClosePrice,
      TrailingStopTier1 = ProtoNullableNumberConverter.GetFromModel(model.TrailingStopTier1),
      TrailingStopTier1Threshold = ProtoNullableNumberConverter.GetFromModel(model.TrailingStopTier1Threshold),
      TrailingStopTier2 = ProtoNullableNumberConverter.GetFromModel(model.TrailingStopTier2),
      TrailingStopTier2Threshold = ProtoNullableNumberConverter.GetFromModel(model.TrailingStopTier2Threshold),
      TrailingStopTier3 = ProtoNullableNumberConverter.GetFromModel(model.TrailingStopTier3),
      TrailingStopTier3Threshold = ProtoNullableNumberConverter.GetFromModel(model.TrailingStopTier3Threshold),
      StopLoss = ProtoNullableNumberConverter.GetFromModel(new double?(model.StopLoss.Value)),
      GuaranteedStopLoss = ProtoNullableNumberConverter.GetFromModel(model.GuaranteedStopLoss),
      TakeProfit = ProtoNullableNumberConverter.GetFromModel(model.TakeProfit),
      Expiration = ProtoNullableDateTimeConverter.GetFromModel(model.Expiration),
      Commission = model.Commission,
      Swap = model.Swap,
      Profit = model.Profit,
      StopOutEquity = ProtoNullableNumberConverter.GetFromModel(model.StopOutEquity),
      StopOutMargin = ProtoNullableNumberConverter.GetFromModel(model.StopOutMargin),
      PullbackTrailingStopTier1 = ProtoNullableNumberConverter.GetFromModel(model.PullbackTrailingStopTier1),
      PullbackTrailingStopTier1Threshold = ProtoNullableNumberConverter.GetFromModel(model.PullbackTrailingStopTier1Threshold),
      PullbackTrailingStopTier2 = ProtoNullableNumberConverter.GetFromModel(model.PullbackTrailingStopTier2),
      PullbackTrailingStopTier2Threshold = ProtoNullableNumberConverter.GetFromModel(model.PullbackTrailingStopTier2Threshold),
      PullbackTrailingStopTier3 = ProtoNullableNumberConverter.GetFromModel(model.PullbackTrailingStopTier3),
      PullbackTrailingStopTier3Threshold = ProtoNullableNumberConverter.GetFromModel(model.PullbackTrailingStopTier3Threshold)
    };
  }
}
