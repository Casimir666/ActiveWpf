// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Proto.EntityMappings.TradeSettingsSetMapping
// Assembly: ATPlatform.Model.Proto, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: E6EBFA31-5E2E-466E-951D-D831D69BD6FA
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.Proto.dll

using ATPlatform.Common.ProtoConverters;
using ATPlatform.IDL;
using ATPlatform.Model.Entities;
using ATPlatform.Model.Proto.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ATPlatform.Model.Proto.EntityMappings
{
  internal class TradeSettingsSetMapping : IProtoMapper<TradeSettingsSetProto, TradeSettingsSet>
  {
    private readonly TradeSettingsMapping _tradeSettingsMapper = new TradeSettingsMapping();

    public TradeSettingsSet ModelFromProto(TradeSettingsSetProto proto) => new TradeSettingsSet()
    {
      Id = proto.Id,
      Name = ProtoNullableStringConverter.GetFromProto(proto.Name),
      IsTemplate = proto.IsTemplate,
      TradeSettings = (IList<TradeSettings>) proto.TradeSettings.Select<TradeSettingsProto, TradeSettings>((Func<TradeSettingsProto, TradeSettings>) (ts => this._tradeSettingsMapper.ModelFromProto(ts))).ToList<TradeSettings>()
    };

    public TradeSettingsSetProto ProtoFromModel(TradeSettingsSet model)
    {
      TradeSettingsSetProto settingsSetProto = new TradeSettingsSetProto();
      settingsSetProto.Id = model.Id;
      settingsSetProto.Name = ProtoNullableStringConverter.GetFromModel(model.Name);
      settingsSetProto.IsTemplate = model.IsTemplate;
      settingsSetProto.TradeSettings.AddRange((IEnumerable<TradeSettingsProto>) model.TradeSettings.Select<TradeSettings, TradeSettingsProto>((Func<TradeSettings, TradeSettingsProto>) (ts => this._tradeSettingsMapper.ProtoFromModel(ts))).ToList<TradeSettingsProto>());
      return settingsSetProto;
    }
  }
}
