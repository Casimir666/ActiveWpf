// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Proto.EntityMappings.SymbolGroupMapping
// Assembly: ATPlatform.Model.Proto, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: E6EBFA31-5E2E-466E-951D-D831D69BD6FA
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.Proto.dll

using ATPlatform.Common.ProtoConverters;
using ATPlatform.IDL;
using ATPlatform.Model.Entities;
using ATPlatform.Model.Proto.Contracts;

namespace ATPlatform.Model.Proto.EntityMappings
{
  internal class SymbolGroupMapping : IProtoMapper<SymbolGroupProto, SymbolGroup>
  {
    public SymbolGroup ModelFromProto(SymbolGroupProto proto) => new SymbolGroup()
    {
      Id = proto.Id,
      ParentId = proto.ParentId,
      Name = ProtoNullableStringConverter.GetFromProto(proto.Name),
      Rank = proto.Rank,
      ColorHex = ProtoNullableStringConverter.GetFromProto(proto.ColorHex),
      IsVirtual = proto.IsVirtual
    };

    public SymbolGroupProto ProtoFromModel(SymbolGroup model) => new SymbolGroupProto()
    {
      Id = model.Id,
      ParentId = model.ParentId,
      Name = ProtoNullableStringConverter.GetFromModel(model.Name),
      Rank = model.Rank,
      ColorHex = ProtoNullableStringConverter.GetFromModel(model.ColorHex),
      IsVirtual = model.IsVirtual
    };
  }
}
