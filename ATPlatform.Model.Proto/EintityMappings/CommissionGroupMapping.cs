// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Proto.EntityMappings.CommissionGroupMapping
// Assembly: ATPlatform.Model.Proto, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: E6EBFA31-5E2E-466E-951D-D831D69BD6FA
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.Proto.dll

using ATPlatform.Common.ProtoConverters;
using ATPlatform.IDL;
using ATPlatform.Model.Entities;
using ATPlatform.Model.Proto.Contracts;

namespace ATPlatform.Model.Proto.EntityMappings
{
  internal class CommissionGroupMapping : IProtoMapper<CommissionGroupProto, CommissionGroup>
  {
    public CommissionGroup ModelFromProto(CommissionGroupProto proto) => new CommissionGroup()
    {
      Id = proto.Id,
      Name = ProtoNullableStringConverter.GetFromProto(proto.Name)
    };

    public CommissionGroupProto ProtoFromModel(CommissionGroup model) => new CommissionGroupProto()
    {
      Id = model.Id,
      Name = ProtoNullableStringConverter.GetFromModel(model.Name)
    };
  }
}
