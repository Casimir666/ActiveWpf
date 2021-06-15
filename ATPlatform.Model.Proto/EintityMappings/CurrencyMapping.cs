// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Proto.EntityMappings.CurrencyMapping
// Assembly: ATPlatform.Model.Proto, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: E6EBFA31-5E2E-466E-951D-D831D69BD6FA
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.Proto.dll

using ATPlatform.IDL;
using ATPlatform.Model.Entities;
using ATPlatform.Model.Proto.Contracts;

namespace ATPlatform.Model.Proto.EntityMappings
{
  internal class CurrencyMapping : IProtoMapper<CurrencyProto, Currency>
  {
    public CurrencyProto ProtoFromModel(Currency model) => new CurrencyProto()
    {
      Prime = model.IsPrime,
      IsoCode = model.IsoCode
    };

    public Currency ModelFromProto(CurrencyProto proto) => new Currency()
    {
      IsPrime = proto.Prime,
      IsoCode = proto.IsoCode
    };
  }
}
