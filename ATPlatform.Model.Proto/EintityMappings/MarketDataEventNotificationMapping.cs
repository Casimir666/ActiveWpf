// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Proto.EntityMappings.MarketDataEventNotificationMapping
// Assembly: ATPlatform.Model.Proto, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: E6EBFA31-5E2E-466E-951D-D831D69BD6FA
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.Proto.dll

using ATPlatform.Common.ProtoConverters;
using ATPlatform.IDL.MarketDataEvents;
using ATPlatform.Model.Enums.MarketDataEvent;
using ATPlatform.Model.Proto.Contracts;

namespace ATPlatform.Model.Proto.EntityMappings
{
  internal class MarketDataEventNotificationMapping : 
    IProtoMapper<MarketDataEventNotificationProto, ATPlatform.Model.Entities.MarketDataEvent>
  {
    public ATPlatform.Model.Entities.MarketDataEvent ModelFromProto(
      MarketDataEventNotificationProto proto)
    {
      return new ATPlatform.Model.Entities.MarketDataEvent()
      {
        Id = proto.MarketDataEvent.Id,
        Initiator = proto.MarketDataEvent.InitiatorId,
        Name = proto.MarketDataEvent.Name,
        Type = (MarketDataEventType) proto.MarketDataEvent.MarketDataEventType,
        State = (MarketDataEventState) proto.MarketDataEvent.State,
        Timestamp = ProtoDateTimeConverter.GetFromProto(proto.MarketDataEvent.Timestamp),
        Subject = proto.MarketDataEvent.Subject,
        Body = proto.MarketDataEvent.Body
      };
    }

    public MarketDataEventNotificationProto ProtoFromModel(
      ATPlatform.Model.Entities.MarketDataEvent model)
    {
      return new MarketDataEventNotificationProto()
      {
        MarketDataEvent = new MarketDataEventProto()
        {
          Id = model.Id,
          InitiatorId = model.Initiator,
          Name = model.Name,
          MarketDataEventType = (MarketDataEventTypeProto) model.Type,
          State = (MarketDataEventStateProto) model.State,
          Timestamp = ProtoDateTimeConverter.GetFromModel(model.Timestamp),
          Subject = model.Subject,
          Body = model.Body
        }
      };
    }
  }
}
