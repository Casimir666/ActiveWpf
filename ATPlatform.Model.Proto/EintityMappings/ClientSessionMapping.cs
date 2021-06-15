// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Proto.EntityMappings.ClientSessionMapping
// Assembly: ATPlatform.Model.Proto, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: E6EBFA31-5E2E-466E-951D-D831D69BD6FA
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.Proto.dll

using ATPlatform.Common.ProtoConverters;
using ATPlatform.IDL;
using ATPlatform.Model.Entities;
using ATPlatform.Model.Enums;
using ATPlatform.Model.Enums.Symbol;
using ATPlatform.Model.Proto.Contracts;

namespace ATPlatform.Model.Proto.EntityMappings
{
  internal class ClientSessionMapping : IProtoMapper<ClientSessionProto, ClientSession>
  {
    public ClientSession ModelFromProto(ClientSessionProto proto) => new ClientSession()
    {
      AccountId = proto.AccountId,
      SessionActionType = (SessionActionType) proto.SessionActionType,
      Timestamp = ProtoDateTimeConverter.GetFromProto(proto.Timestamp),
      SessionIdHash = proto.SessionIdHash,
      IpAddress = proto.IpAddress,
      ProtocolVersionMajor = proto.ProtocolVersion.Major,
      ProtocolVersionMinor = proto.ProtocolVersion.Minor,
      ProtocolVersionPatch = proto.ProtocolVersion.Patch,
      ClientApplicationType = (ClientApplicationType) proto.ClientAppType
    };

    public ClientSessionProto ProtoFromModel(ClientSession model) => new ClientSessionProto()
    {
      AccountId = model.AccountId,
      SessionActionType = (SessionActionTypeProto) model.SessionActionType,
      Timestamp = ProtoDateTimeConverter.GetFromModel(model.Timestamp),
      SessionIdHash = model.SessionIdHash,
      IpAddress = model.IpAddress,
      ProtocolVersion = new ProtocolVersionProto()
      {
        Major = model.ProtocolVersionMajor,
        Minor = model.ProtocolVersionMinor,
        Patch = model.ProtocolVersionPatch
      },
      ClientAppType = (ClientAppTypeProto) model.ClientApplicationType
    };
  }
}
