// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Proto.EntityMappings.ProtocolVersionMapping
// Assembly: ATPlatform.Model.Proto, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: E6EBFA31-5E2E-466E-951D-D831D69BD6FA
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.Proto.dll

using ATPlatform.IDL;
using ATPlatform.Model.Entities;
using ATPlatform.Model.Proto.Contracts;

namespace ATPlatform.Model.Proto.EntityMappings
{
  internal class ProtocolVersionMapping : IProtoMapper<ProtocolVersionProto, ProtocolVersion>
  {
    public ProtocolVersion ModelFromProto(ProtocolVersionProto proto) => new ProtocolVersion()
    {
      Major = proto.Major,
      Minor = proto.Minor,
      Patch = proto.Patch
    };

    public ProtocolVersionProto ProtoFromModel(ProtocolVersion model) => new ProtocolVersionProto()
    {
      Major = model.Major,
      Minor = model.Minor,
      Patch = model.Patch
    };
  }
}
