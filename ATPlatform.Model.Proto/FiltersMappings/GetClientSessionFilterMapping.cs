// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Proto.FiltersMappings.GetClientSessionFilterMapping
// Assembly: ATPlatform.Model.Proto, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: E6EBFA31-5E2E-466E-951D-D831D69BD6FA
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.Proto.dll

using ATPlatform.Common.ProtoConverters;
using ATPlatform.IDL;
using ATPlatform.Model.Filters;
using ATPlatform.Model.Proto.Contracts;

namespace ATPlatform.Model.Proto.FiltersMappings
{
  internal class GetClientSessionFilterMapping : 
    IProtoMapper<GetClientSessionFilterProto, GetClientSessionFilter>
  {
    public GetClientSessionFilter ModelFromProto(
      GetClientSessionFilterProto proto)
    {
      return new GetClientSessionFilter()
      {
        AccountId = proto.AccountId,
        From = ProtoNullableDateTimeConverter.GetFromProto(proto.From),
        To = ProtoNullableDateTimeConverter.GetFromProto(proto.To),
        UniqueOnly = proto.UniqueOnly
      };
    }

    public GetClientSessionFilterProto ProtoFromModel(
      GetClientSessionFilter model)
    {
      return new GetClientSessionFilterProto()
      {
        AccountId = model.AccountId,
        From = ProtoNullableDateTimeConverter.GetFromModel(model.From),
        To = ProtoNullableDateTimeConverter.GetFromModel(model.To),
        UniqueOnly = model.UniqueOnly
      };
    }
  }
}
