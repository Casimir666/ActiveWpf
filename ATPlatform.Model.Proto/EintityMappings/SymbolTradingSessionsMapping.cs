// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Proto.EntityMappings.SymbolTradingSessionsMapping
// Assembly: ATPlatform.Model.Proto, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: E6EBFA31-5E2E-466E-951D-D831D69BD6FA
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.Proto.dll

using ATPlatform.Common.ProtoConverters;
using ATPlatform.IDL;
using ATPlatform.Model.Entities;
using ATPlatform.Model.Proto.Contracts;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ATPlatform.Model.Proto.EntityMappings
{
  internal class SymbolTradingSessionsMapping : 
    IProtoMapper<SymbolTradingSessionsProto, SymbolTradingSessions>
  {
    public SymbolTradingSessionsProto ProtoFromModel(
      SymbolTradingSessions model)
    {
      SymbolTradingSessionsProto tradingSessionsProto = new SymbolTradingSessionsProto();
      tradingSessionsProto.SymbolId = ProtoNullableStringConverter.GetFromModel(model.SymbolId);
      if (model.Sessions != null)
      {
        foreach (TradingSession session in (IEnumerable<TradingSession>) model.Sessions)
        {
          TradingSessionProto tradingSessionProto = session.ProtoFromModel<TradingSessionProto, TradingSession>();
          tradingSessionsProto.TradingSession.Add(tradingSessionProto);
        }
      }
      return tradingSessionsProto;
    }

    public SymbolTradingSessions ModelFromProto(
      SymbolTradingSessionsProto proto)
    {
      SymbolTradingSessions symbolTradingSessions = new SymbolTradingSessions(proto.SymbolId, ProtoDateTimeConverter.TimeZoneInfo);
      symbolTradingSessions.AddTradingSessions((IReadOnlyCollection<TradingSession>) new ReadOnlyCollection<TradingSession>((IList<TradingSession>) proto.TradingSession.ModelFromProto<TradingSessionProto, TradingSession>().ToList<TradingSession>()));
      return symbolTradingSessions;
    }
  }
}
