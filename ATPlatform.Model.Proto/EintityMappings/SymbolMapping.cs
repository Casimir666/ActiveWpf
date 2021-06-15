// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Proto.EntityMappings.SymbolMapping
// Assembly: ATPlatform.Model.Proto, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: E6EBFA31-5E2E-466E-951D-D831D69BD6FA
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.Proto.dll

using ATPlatform.Common.ProtoConverters;
using ATPlatform.IDL;
using ATPlatform.Model.Enums.Symbol;
using ATPlatform.Model.Proto.Contracts;

namespace ATPlatform.Model.Proto.EntityMappings
{
  internal class SymbolMapping : IProtoMapper<SymbolProto, ATPlatform.Model.Entities.Symbol>
  {
    public ATPlatform.Model.Entities.Symbol ModelFromProto(SymbolProto proto) => new ATPlatform.Model.Entities.Symbol()
    {
      Id = proto.SymbolId,
      GroupId = proto.SymbolGroupId,
      CommissionGroupId = proto.CommissionGroupId,
      Description = proto.Description,
      Digits = (byte) proto.Digits,
      TradeType = (TradeType) proto.TradeType,
      BaseCurrencyIsoCode = proto.BaseCurrencyIsoCode,
      ProfitCurrencyIsoCode = proto.ProfitCurrencyIsoCode,
      MinLots = proto.MinLots,
      MaxLots = proto.MaxLots,
      Step = proto.Step,
      OffQuotesThresholdSeconds = proto.OffQuotesThresholdSeconds,
      AvailableOnBridge = proto.AvailableOnBridge,
      ContractSize = proto.ContractSize,
      ContractSizeDenominator = proto.ContractSizeDenominator,
      TickSize = proto.TickSize,
      HedgedMarginPercentage = proto.HedgedMarginPercentage,
      Category = (SymbolCategoryType) proto.CategoryType,
      TrailingStopMaxRange = proto.TrailingStopMaxRange,
      TickSizeMultiplier = proto.TickSizeMultiplier,
      PriceUnitType = (PriceUnitType) proto.PriceUnitType,
      SwapType = (SwapAmountType) proto.SwapType,
      LongPositionsSwap = proto.LongPositionsSwap,
      ShortPositionsSwap = proto.ShortPositionsSwap,
      ExpirationDate = ProtoNullableDateTimeConverter.GetFromProto(proto.ExpirationDate),
      TargetSpread = proto.TargetSpread,
      AverageSpread = proto.AverageSpread,
      TickPrice = proto.TickPrice,
      ThreeDaySwap = proto.ThreeDaySwap,
      Level2Threshold = proto.Level2Threshold
    };

    public SymbolProto ProtoFromModel(ATPlatform.Model.Entities.Symbol model) => new SymbolProto()
    {
      SymbolId = model.Id,
      SymbolGroupId = model.GroupId,
      CommissionGroupId = model.CommissionGroupId,
      Description = model.Description,
      Digits = (int) model.Digits,
      TradeType = (TradeTypeProto) model.TradeType,
      BaseCurrencyIsoCode = model.BaseCurrencyIsoCode,
      ProfitCurrencyIsoCode = model.ProfitCurrencyIsoCode,
      MinLots = model.MinLots,
      MaxLots = model.MaxLots,
      Step = model.Step,
      OffQuotesThresholdSeconds = model.OffQuotesThresholdSeconds,
      AvailableOnBridge = model.AvailableOnBridge,
      ContractSize = model.ContractSize,
      ContractSizeDenominator = model.ContractSizeDenominator,
      TickSize = model.TickSize,
      HedgedMarginPercentage = model.HedgedMarginPercentage,
      CategoryType = (CategoryTypeProto) model.Category,
      TrailingStopMaxRange = model.TrailingStopMaxRange,
      TickSizeMultiplier = model.TickSizeMultiplier,
      PriceUnitType = (PriceUnitTypeProto) model.PriceUnitType,
      SwapType = (SwapAmountTypeProto) model.SwapType,
      LongPositionsSwap = model.LongPositionsSwap,
      ShortPositionsSwap = model.ShortPositionsSwap,
      ExpirationDate = ProtoNullableDateTimeConverter.GetFromModel(model.ExpirationDate),
      TargetSpread = model.TargetSpread,
      AverageSpread = model.AverageSpread,
      TickPrice = model.TickPrice,
      ThreeDaySwap = model.ThreeDaySwap,
      Level2Threshold = model.Level2Threshold
    };
  }
}
