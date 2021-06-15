// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Proto.MappingExtensions
// Assembly: ATPlatform.Model.Proto, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: E6EBFA31-5E2E-466E-951D-D831D69BD6FA
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.Proto.dll

using ATPlatform.Common.ProtoConverters;
using ATPlatform.IDL;
using ATPlatform.Model.Entities;
using ATPlatform.Model.Enums;
using ATPlatform.Model.Proto.Contracts;
using ATPlatform.Model.Proto.Providers;
using Google.Protobuf;
using Google.Protobuf.Collections;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ATPlatform.Model.Proto
{
  public static class MappingExtensions
  {
    private static readonly IProtoMapperProvider _mappingProvider = ModelProtoPapaProvider.GetInstance().GetProtoMapperProvider();
    private static readonly IProtoMapper<OrderRequestProto, OrderRequest> _orderRequestMapping = MappingExtensions._mappingProvider.GetMapper<OrderRequestProto, OrderRequest>();
    private static TimeZoneInfo _timeZoneInfo = TimeZoneInfo.Utc;

    public static void SetTimeZone(TimeZoneInfo timeZoneInfo)
    {
      MappingExtensions._timeZoneInfo = timeZoneInfo;
      ProtoDateTimeConverter.TimeZoneInfo = MappingExtensions._timeZoneInfo;
      ProtoNullableDateTimeConverter.TimeZoneInfo = MappingExtensions._timeZoneInfo;
    }

    public static MessageType ModelFromProto(this MessageTypeProto messageTypeProto) => MessageTypeMapper.GetMessageType(new MessageTypeProto?(messageTypeProto));

    public static TModel ModelFromProto<TProto, TModel>(this TProto proto) where TProto : IMessage, IMessage<TProto> => MappingExtensions._mappingProvider.GetMapper<TProto, TModel>().ModelFromProto(proto);

    public static IList<TModel> ModelFromProto<TProto, TModel>(
      this RepeatedField<TProto> protos)
      where TProto : IMessage, IMessage<TProto>
    {
      List<TModel> modelList = new List<TModel>(protos.Count);
      foreach (TProto proto in protos)
        modelList.Add(proto.ModelFromProto<TProto, TModel>());
      return (IList<TModel>) modelList;
    }

    public static TProto ProtoFromModel<TProto, TModel>(this TModel model) where TProto : IMessage, IMessage<TProto> => MappingExtensions._mappingProvider.GetMapper<TProto, TModel>().ProtoFromModel(model);

    public static IList<TProto> ProtoFromModel<TProto, TModel>(this IList<TModel> models) where TProto : IMessage, IMessage<TProto>
    {
        IList<TProto> ReturnResult(List<TModel> modelList)
        {
            var result = new List<TProto>(modelList.Count);
            modelList.ForEach(m => result.Add(m.ProtoFromModel<TProto, TModel>()));
            return result;
        }
        
        switch (models)
        {
            case List<TModel> list:
                return ReturnResult(list);
            case TModel[] array:
                return ReturnResult (array.ToList());
            default:
                return ReturnResult (models.ToList<TModel>());
        }

            /*
                  switch (models)
                  {
                    case List<TModel> list:
            label_3:
                      List<TProto> result = new List<TProto>(list.Count);
                      list.ForEach((Action<TModel>) (m => result.Add(m.ProtoFromModel<TProto, TModel>())));
                      return (IList<TProto>) result;
                    case TModel[] array:
            label_2:
                      list = ((IEnumerable<TModel>) array).ToList<TModel>();
                      goto label_3;
                    default:
                      array = models.ToArray<TModel>();
                      goto label_2;
                  }
            */
        }

        public static OrderRequest ModelFromProto(this OrderRequestProto proto) => MappingExtensions._orderRequestMapping.ModelFromProto(proto);

    public static OrderRequestProto ProtoFromModel(this OrderRequest model) => MappingExtensions._orderRequestMapping.ProtoFromModel(model);
  }
}
