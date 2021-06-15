// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Proto.FiltersMappings.GetAccountsFilterMapping
// Assembly: ATPlatform.Model.Proto, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: E6EBFA31-5E2E-466E-951D-D831D69BD6FA
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.Proto.dll

using ATPlatform.Common.ProtoConverters;
using ATPlatform.IDL;
using ATPlatform.Model.Filters;
using ATPlatform.Model.Proto.Contracts;

namespace ATPlatform.Model.Proto.FiltersMappings
{
  internal class GetAccountsFilterMapping : IProtoMapper<GetAccountsFilterProto, GetAccountsFilter>
  {
    public GetAccountsFilter ModelFromProto(GetAccountsFilterProto proto) => new GetAccountsFilter()
    {
      AccountId = proto.AccountId,
      CustomerEmail = ProtoNullableStringConverter.GetFromProto(proto.CustomerEmail),
      FromRegistrationDate = ProtoNullableDateTimeConverter.GetFromProto(proto.FromRegistrationDate),
      ToRegistrationDate = ProtoNullableDateTimeConverter.GetFromProto(proto.ToRegistrationDate),
      IncludeClosed = proto.IncludeClosed
    };

    public GetAccountsFilterProto ProtoFromModel(GetAccountsFilter model) => new GetAccountsFilterProto()
    {
      AccountId = model.AccountId,
      CustomerEmail = ProtoNullableStringConverter.GetFromModel(model.CustomerEmail),
      FromRegistrationDate = ProtoNullableDateTimeConverter.GetFromModel(model.FromRegistrationDate),
      ToRegistrationDate = ProtoNullableDateTimeConverter.GetFromModel(model.ToRegistrationDate),
      IncludeClosed = model.IncludeClosed
    };
  }
}
