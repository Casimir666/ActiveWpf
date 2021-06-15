// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Proto.EntityMappings.SymbolTagsMapping
// Assembly: ATPlatform.Model.Proto, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: E6EBFA31-5E2E-466E-951D-D831D69BD6FA
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.Proto.dll

using ATPlatform.IDL;
using ATPlatform.Model.Entities;
using ATPlatform.Model.Proto.Contracts;
using System.Collections.Generic;

namespace ATPlatform.Model.Proto.EntityMappings
{
  internal class SymbolTagsMapping : IProtoMapper<SymbolTagsProto, SymbolTags>
  {
    public SymbolTags ModelFromProto(SymbolTagsProto proto) => new SymbolTags()
    {
      SymbolId = proto.SymbolId,
      TagIds = new List<int>((IEnumerable<int>) proto.TagIds)
    };

    public SymbolTagsProto ProtoFromModel(SymbolTags model)
    {
      SymbolTagsProto symbolTagsProto = new SymbolTagsProto();
      symbolTagsProto.SymbolId = model.SymbolId;
      symbolTagsProto.TagIds.AddRange((IEnumerable<int>) model.TagIds);
      return symbolTagsProto;
    }
  }
}
