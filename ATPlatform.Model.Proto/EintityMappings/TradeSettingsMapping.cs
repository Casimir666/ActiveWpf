// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Proto.EntityMappings.TradeSettingsMapping
// Assembly: ATPlatform.Model.Proto, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: E6EBFA31-5E2E-466E-951D-D831D69BD6FA
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.Proto.dll

using ATPlatform.Common.ProtoConverters;
using ATPlatform.IDL;
using ATPlatform.Model.Entities;
using ATPlatform.Model.Enums.Symbol;
using ATPlatform.Model.Proto.Contracts;

namespace ATPlatform.Model.Proto.EntityMappings
{
  internal class TradeSettingsMapping : IProtoMapper<TradeSettingsProto, TradeSettings>
  {
    public TradeSettings ModelFromProto(TradeSettingsProto proto) => new TradeSettings()
    {
      SymbolGroupId = ProtoNullableNumberConverter.GetFromProto(proto.SymbolGroupId),
      SymbolId = ProtoNullableStringConverter.GetFromProto(proto.SymbolId),
      UseFixedMarginPercentage = proto.UseFixedMarginPercentage,
      MarginTiersMarginCoef = ProtoNullableNumberConverter.GetFromProto(proto.MarginTiersMarginCoef),
      MarginTiersLotsCoef = ProtoNullableNumberConverter.GetFromProto(proto.MarginTiersLotsCoef),
      MaxLots = ProtoNullableNumberConverter.GetFromProto(proto.MaxLots),
      MinLots = ProtoNullableNumberConverter.GetFromProto(proto.MinLots),
      Step = ProtoNullableNumberConverter.GetFromProto(proto.Step),
      Level2Threshold = ProtoNullableNumberConverter.GetFromProto(proto.Level2Threshold),
      TradeType = (TradeType) proto.TradeType,
      ApplySwaps = proto.ApplySwaps,
      TagId = ProtoNullableNumberConverter.GetFromProto(proto.TagId),
      MaxPositionNotionalValue = new double?(proto.MaxPositionNotionalValue)
    };

    public TradeSettingsProto ProtoFromModel(TradeSettings model) => new TradeSettingsProto()
    {
      SymbolGroupId = ProtoNullableNumberConverter.GetFromModel(model.SymbolGroupId),
      SymbolId = ProtoNullableStringConverter.GetFromModel(model.SymbolId),
      UseFixedMarginPercentage = model.UseFixedMarginPercentage,
      MarginTiersMarginCoef = ProtoNullableNumberConverter.GetFromModel(model.MarginTiersMarginCoef),
      MarginTiersLotsCoef = ProtoNullableNumberConverter.GetFromModel(model.MarginTiersLotsCoef),
      MaxLots = ProtoNullableNumberConverter.GetFromModel(model.MaxLots),
      MinLots = ProtoNullableNumberConverter.GetFromModel(model.MinLots),
      Step = ProtoNullableNumberConverter.GetFromModel(model.Step),
      Level2Threshold = ProtoNullableNumberConverter.GetFromModel(model.Level2Threshold),
      TradeType = (TradeTypeProto) model.TradeType,
      ApplySwaps = model.ApplySwaps,
      TagId = ProtoNullableNumberConverter.GetFromModel(model.TagId),
      MaxPositionNotionalValue = ProtoNullableNumberConverter.GetFromModel(model.MaxPositionNotionalValue)
    };
  }
}
