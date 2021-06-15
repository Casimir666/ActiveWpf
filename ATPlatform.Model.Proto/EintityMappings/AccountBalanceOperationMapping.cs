// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Proto.EntityMappings.AccountBalanceOperationMapping
// Assembly: ATPlatform.Model.Proto, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: E6EBFA31-5E2E-466E-951D-D831D69BD6FA
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.Proto.dll

using ATPlatform.Common.ProtoConverters;
using ATPlatform.IDL;
using ATPlatform.Model.Entities;
using ATPlatform.Model.Enums;
using ATPlatform.Model.Proto.Contracts;

namespace ATPlatform.Model.Proto.EntityMappings
{
  internal class AccountBalanceOperationMapping : 
    IProtoMapper<AccountBalanceOperationProto, AccountBalanceOperation>
  {
    public AccountBalanceOperation ModelFromProto(
      AccountBalanceOperationProto proto)
    {
      return new AccountBalanceOperation()
      {
        Id = proto.Id,
        AccountId = proto.AccountId,
        Amount = proto.Amount,
        Comment = proto.Comment,
        ExternalOperationId = ProtoNullableNumberConverter.GetFromProto(proto.ExternalOperationId),
        InverseOperationId = ProtoNullableNumberConverter.GetFromProto(proto.InverseOperationId),
        Timestamp = ProtoDateTimeConverter.GetFromProto(proto.Timestamp),
        BalanceChangeType = (BalanceChangeType) proto.BalanceChangeType
      };
    }

    public AccountBalanceOperationProto ProtoFromModel(
      AccountBalanceOperation model)
    {
      return new AccountBalanceOperationProto()
      {
        Id = model.Id,
        AccountId = model.AccountId,
        Amount = model.Amount,
        Comment = model.Comment,
        ExternalOperationId = ProtoNullableNumberConverter.GetFromModel(model.ExternalOperationId),
        InverseOperationId = ProtoNullableNumberConverter.GetFromModel(model.InverseOperationId),
        Timestamp = ProtoDateTimeConverter.GetFromModel(model.Timestamp),
        BalanceChangeType = (BalanceChangeTypeProto) model.BalanceChangeType
      };
    }
  }
}
