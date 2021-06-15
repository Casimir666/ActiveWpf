// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Proto.FiltersMappings.GetAccountBalanceOperationsFilterMapping
// Assembly: ATPlatform.Model.Proto, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: E6EBFA31-5E2E-466E-951D-D831D69BD6FA
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.Proto.dll

using ATPlatform.Common.ProtoConverters;
using ATPlatform.IDL;
using ATPlatform.Model.Enums;
using ATPlatform.Model.Filters;
using ATPlatform.Model.Proto.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace ATPlatform.Model.Proto.FiltersMappings
{
  public class GetAccountBalanceOperationsFilterMapping : 
    IProtoMapper<GetAccountBalanceOperationsFilterProto, GetAccountBalanceOperationsFilter>
  {
    public GetAccountBalanceOperationsFilter ModelFromProto(
      GetAccountBalanceOperationsFilterProto proto)
    {
      return new GetAccountBalanceOperationsFilter()
      {
        AccountIds = proto.AccountIds.ToList<int>(),
        BalanceIds = proto.BalanceIds.ToList<long>(),
        Types = proto.Types_.Cast<BalanceChangeType>().ToList<BalanceChangeType>(),
        Comment = ProtoNullableStringConverter.GetFromProto(proto.Comment),
        StartDate = ProtoNullableDateTimeConverter.GetFromProto(proto.StartDate),
        EndDate = ProtoNullableDateTimeConverter.GetFromProto(proto.EndDate)
      };
    }

    public GetAccountBalanceOperationsFilterProto ProtoFromModel(
      GetAccountBalanceOperationsFilter model)
    {
      GetAccountBalanceOperationsFilterProto operationsFilterProto = new GetAccountBalanceOperationsFilterProto();
      operationsFilterProto.Comment = ProtoNullableStringConverter.GetFromModel(model.Comment);
      operationsFilterProto.StartDate = ProtoNullableDateTimeConverter.GetFromModel(model.StartDate);
      operationsFilterProto.EndDate = ProtoNullableDateTimeConverter.GetFromModel(model.EndDate);
      operationsFilterProto.AccountIds.AddRange((IEnumerable<int>) model.AccountIds);
      operationsFilterProto.BalanceIds.AddRange((IEnumerable<long>) model.BalanceIds);
      operationsFilterProto.Types_.AddRange(model.Types.Cast<BalanceChangeTypeProto>());
      return operationsFilterProto;
    }
  }
}
