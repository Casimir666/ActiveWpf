// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Proto.EntityMappings.ClientMessageNotificationMapping
// Assembly: ATPlatform.Model.Proto, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: E6EBFA31-5E2E-466E-951D-D831D69BD6FA
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.Proto.dll

using ATPlatform.Common.ProtoConverters;
using ATPlatform.IDL;
using ATPlatform.Model.Enums.ClientMessage;
using ATPlatform.Model.Proto.Contracts;

namespace ATPlatform.Model.Proto.EntityMappings
{
  internal class ClientMessageNotificationMapping : 
    IProtoMapper<ClientMessageForAccountNotificationProto, ATPlatform.Model.Entities.ClientMessage>
  {
    public ATPlatform.Model.Entities.ClientMessage ModelFromProto(
      ClientMessageForAccountNotificationProto proto)
    {
      return new ATPlatform.Model.Entities.ClientMessage()
      {
        Id = proto.ClientMessage.Id,
        PlatformId = proto.ClientMessage.PlatformId,
        AccountId = proto.AccountId,
        Importance = (ClientMessageImportance) proto.ClientMessage.Importance,
        Category = (ClientMessageCategory) proto.ClientMessage.Category,
        State = (ClientMessageState) proto.ClientMessage.State,
        AccountState = ClientMessageAccountState.Undefined,
        Timestamp = ProtoDateTimeConverter.GetFromProto(proto.ClientMessage.Timestamp),
        Subject = proto.ClientMessage.Subject,
        Body = proto.ClientMessage.Body
      };
    }

    public ClientMessageForAccountNotificationProto ProtoFromModel(
      ATPlatform.Model.Entities.ClientMessage model)
    {
      return new ClientMessageForAccountNotificationProto()
      {
        AccountId = model.AccountId,
        PlatformId = model.PlatformId,
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
