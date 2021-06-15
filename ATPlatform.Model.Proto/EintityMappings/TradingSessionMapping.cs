// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Proto.EntityMappings.TradingSessionMapping
// Assembly: ATPlatform.Model.Proto, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: E6EBFA31-5E2E-466E-951D-D831D69BD6FA
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.Proto.dll

using ATPlatform.IDL;
using ATPlatform.Model.Entities;
using ATPlatform.Model.Proto.Contracts;
using System;

namespace ATPlatform.Model.Proto.EntityMappings
{
  internal class TradingSessionMapping : IProtoMapper<TradingSessionProto, TradingSession>
  {
    public TradingSessionProto ProtoFromModel(TradingSession model) => new TradingSessionProto()
    {
      DayOfWeek = TradingSessionMapping.DayOfWeekMapper.ProtoFromModel(model.DayOfWeek),
      StartHour = model.StartHour,
      StartMinute = model.StartMinute,
      EndHour = model.EndHour,
      EndMinute = model.EndMinute
    };

    public TradingSession ModelFromProto(TradingSessionProto proto) => new TradingSession()
    {
      DayOfWeek = TradingSessionMapping.DayOfWeekMapper.ModelFromProto(proto.DayOfWeek),
      StartHour = proto.StartHour,
      StartMinute = proto.StartMinute,
      EndHour = proto.EndHour,
      EndMinute = proto.EndMinute,
      StartFrame = proto.StartHour * 60 + proto.StartMinute,
      EndFrame = proto.EndHour < 24 ? proto.EndHour * 60 + proto.EndMinute : 1440
    };

    private static class DayOfWeekMapper
    {
      public static DayOfWeek ModelFromProto(int proto)
      {
        switch (proto)
        {
          case 0:
            return DayOfWeek.Sunday;
          case 1:
            return DayOfWeek.Monday;
          case 2:
            return DayOfWeek.Tuesday;
          case 3:
            return DayOfWeek.Wednesday;
          case 4:
            return DayOfWeek.Thursday;
          case 5:
            return DayOfWeek.Friday;
          case 6:
            return DayOfWeek.Saturday;
          default:
            throw new NotSupportedException(string.Format("Unsupported day of the week {0}.", (object) proto));
        }
      }

      public static int ProtoFromModel(DayOfWeek model)
      {
        switch (model)
        {
          case DayOfWeek.Sunday:
            return 0;
          case DayOfWeek.Monday:
            return 1;
          case DayOfWeek.Tuesday:
            return 2;
          case DayOfWeek.Wednesday:
            return 3;
          case DayOfWeek.Thursday:
            return 4;
          case DayOfWeek.Friday:
            return 5;
          case DayOfWeek.Saturday:
            return 6;
          default:
            throw new NotSupportedException(model.ToString());
        }
      }
    }
  }
}
