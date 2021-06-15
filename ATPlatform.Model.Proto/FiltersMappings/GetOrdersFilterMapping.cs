// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Proto.FiltersMappings.GetOrdersFilterMapping
// Assembly: ATPlatform.Model.Proto, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: E6EBFA31-5E2E-466E-951D-D831D69BD6FA
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.Proto.dll

using ATPlatform.Common.ProtoConverters;
using ATPlatform.IDL;
using ATPlatform.Model.Enums.Order;
using ATPlatform.Model.Filters;
using ATPlatform.Model.Proto.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace ATPlatform.Model.Proto.FiltersMappings
{
  public class GetOrdersFilterMapping : IProtoMapper<GetOrdersFilterProto, GetOrdersFilter>
  {
    public GetOrdersFilter ModelFromProto(GetOrdersFilterProto proto) => new GetOrdersFilter()
    {
      OpenStartDate = ProtoNullableDateTimeConverter.GetFromProto(proto.OpenStartDate),
      OpenEndDate = ProtoNullableDateTimeConverter.GetFromProto(proto.OpenEndDate),
      CloseStartDate = ProtoNullableDateTimeConverter.GetFromProto(proto.CloseStartDate),
      CloseEndDate = ProtoNullableDateTimeConverter.GetFromProto(proto.CloseEndDate),
      MinLots = proto.MinLots,
      MaxLots = proto.MaxLots,
      AccountIds = proto.AccountIds.ToList<int>(),
      Symbols = proto.Symbols.ToList<string>(),
      OrderStates = proto.OrderCurrentStates.Cast<OrderState>().ToList<OrderState>()
    };

    public GetOrdersFilterProto ProtoFromModel(GetOrdersFilter model)
    {
      GetOrdersFilterProto ordersFilterProto = new GetOrdersFilterProto();
      ordersFilterProto.MinLots = model.MinLots;
      ordersFilterProto.MaxLots = model.MaxLots;
      ordersFilterProto.OpenStartDate = ProtoNullableDateTimeConverter.GetFromModel(model.OpenStartDate);
      ordersFilterProto.OpenEndDate = ProtoNullableDateTimeConverter.GetFromModel(model.OpenEndDate);
      ordersFilterProto.CloseStartDate = ProtoNullableDateTimeConverter.GetFromModel(model.CloseStartDate);
      ordersFilterProto.CloseEndDate = ProtoNullableDateTimeConverter.GetFromModel(model.CloseEndDate);
      ordersFilterProto.AccountIds.AddRange((IEnumerable<int>) model.AccountIds);
      ordersFilterProto.Symbols.AddRange((IEnumerable<string>) model.Symbols);
      ordersFilterProto.OrderCurrentStates.AddRange(model.OrderStates.Cast<OrderStateProto>());
      return ordersFilterProto;
    }
  }
}
