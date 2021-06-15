// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Proto.EntityMappings.MarkupSettingsSetMapping
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
  internal class MarkupSettingsSetMapping : IProtoMapper<MarkupSettingsSetProto, MarkupSettingsSet>
  {
    private readonly MarkupSettingsMapping _markupSettingsMapper = new MarkupSettingsMapping();

    public MarkupSettingsSet ModelFromProto(MarkupSettingsSetProto proto) => new MarkupSettingsSet()
    {
      Id = proto.Id,
      Name = ProtoNullableStringConverter.GetFromProto(proto.Name),
      IsTemplate = proto.IsTemplate,
      MarkupSettings = (IList<MarkupSettings>) proto.MarkupSettings.Select<MarkupSettingsProto, MarkupSettings>((Func<MarkupSettingsProto, MarkupSettings>) (ms => this._markupSettingsMapper.ModelFromProto(ms))).ToList<MarkupSettings>()
    };

    public MarkupSettingsSetProto ProtoFromModel(MarkupSettingsSet model)
    {
      MarkupSettingsSetProto settingsSetProto = new MarkupSettingsSetProto();
      settingsSetProto.Id = model.Id;
      settingsSetProto.Name = ProtoNullableStringConverter.GetFromModel(model.Name);
      settingsSetProto.IsTemplate = model.IsTemplate;
      settingsSetProto.MarkupSettings.AddRange((IEnumerable<MarkupSettingsProto>) model.MarkupSettings.Select<MarkupSettings, MarkupSettingsProto>((Func<MarkupSettings, MarkupSettingsProto>) (ts => this._markupSettingsMapper.ProtoFromModel(ts))).ToList<MarkupSettingsProto>());
      return settingsSetProto;
    }
  }
}
