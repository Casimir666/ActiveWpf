// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Proto.EntityMappings.MarkupSettingsMapping
// Assembly: ATPlatform.Model.Proto, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: E6EBFA31-5E2E-466E-951D-D831D69BD6FA
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.Proto.dll

using ATPlatform.Common.ProtoConverters;
using ATPlatform.IDL;
using ATPlatform.Model.Entities;
using ATPlatform.Model.Proto.Contracts;

namespace ATPlatform.Model.Proto.EntityMappings
{
  internal class MarkupSettingsMapping : IProtoMapper<MarkupSettingsProto, MarkupSettings>
  {
    public MarkupSettings ModelFromProto(MarkupSettingsProto proto) => new MarkupSettings()
    {
      SymbolGroupId = ProtoNullableNumberConverter.GetFromProto(proto.SymbolGroupId),
      SymbolId = ProtoNullableStringConverter.GetFromProto(proto.SymbolId),
      TagId = ProtoNullableNumberConverter.GetFromProto(proto.TagId),
      AskMarkup = proto.AskMarkup,
      BidMarkup = proto.BidMarkup,
      ConversionRateMarkup = proto.ConversionRateMarkup
    };

    public MarkupSettingsProto ProtoFromModel(MarkupSettings model) => new MarkupSettingsProto()
    {
      SymbolGroupId = ProtoNullableNumberConverter.GetFromModel(model.SymbolGroupId),
      SymbolId = ProtoNullableStringConverter.GetFromModel(model.SymbolId),
      TagId = ProtoNullableNumberConverter.GetFromModel(model.TagId),
      AskMarkup = ProtoNullableNumberConverter.GetFromModel(new int?(model.AskMarkup)),
      BidMarkup = ProtoNullableNumberConverter.GetFromModel(new int?(model.BidMarkup)),
      ConversionRateMarkup = ProtoNullableNumberConverter.GetFromModel(new double?(model.ConversionRateMarkup))
    };
  }
}
