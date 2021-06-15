// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Proto.EntityMappings.ClientMessageMapping
// Assembly: ATPlatform.Model.Proto, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: E6EBFA31-5E2E-466E-951D-D831D69BD6FA
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.Proto.dll

using ATPlatform.Common.ProtoConverters;
using ATPlatform.IDL;
using ATPlatform.Model.Enums.ClientMessage;
using ATPlatform.Model.Proto.Contracts;

namespace ATPlatform.Model.Proto.EntityMappings
{
  internal class ClientMessageMapping : IProtoMapper<ClientMessageForAccountProto, ATPlatform.Model.Entities.ClientMessage>
  {
    public ATPlatform.Model.Entities.ClientMessage ModelFromProto(
      ClientMessageForAccountProto proto)
    {
      return new ATPlatform.Model.Entities.ClientMessage()
      {
        Id = proto.ClientMessage.Id,
        PlatformId = proto.ClientMessage.PlatformId,
        AccountId = proto.Account.Id,
        Importance = (ClientMessageImportance) proto.ClientMessage.Importance,
        Category = (ClientMessageCategory) proto.ClientMessage.Category,
        State = (ClientMessageState) proto.ClientMessage.State,
        AccountState = (ClientMessageAccountState) proto.Account.State,
        Timestamp = ProtoDateTimeConverter.GetFromProto(proto.ClientMessage.Timestamp),
        Subject = proto.ClientMessage.Subject,
        Body = proto.ClientMessage.Body
      };
    }

    public ClientMessageForAccountProto ProtoFromModel(
      ATPlatform.Model.Entities.ClientMessage model)
    {
      return new ClientMessageForAccountProto()
      {
        Account = new ClientMessageAccountProto()
        {
          AccountId = model.AccountId,
          MessageId = model.Id,
          State = (ClientMessageAccountStateProto) model.AccountState,
          Timestamp = ProtoDateTimeConverter.GetFromModel(model.Timestamp)
        },
        ClientMessage = new ClientMessageProto()
        {
          Id = model.Id,
          PlatformId = model.PlatformId,
          Importance = (ClientMessageImportanceProto) model.Importance,
          Category = (ClientMessageCategoryProto) model.Category,
          State = (ClientMessageStateProto) model.State,
          Timestamp = ProtoDateTimeConverter.GetFromModel(model.Timestamp),
          Subject = model.Subject,
          Body = model.Body
        }
      };
    }
  }
}
