// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Entities.Symbol
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

using ATPlatform.Common.ExchangeRates;
using ATPlatform.Common.Utils;
using ATPlatform.Model.Contracts;
using ATPlatform.Model.Enums.Symbol;
using System;

namespace ATPlatform.Model.Entities
{
  public class Symbol : 
    IModel<ATPlatform.Model.Entities.Symbol, string>,
    ICloneable<ATPlatform.Model.Entities.Symbol>,
    IUpdatable<ATPlatform.Model.Entities.Symbol>,
    Contracts.IEquatable<ATPlatform.Model.Entities.Symbol>,
    IIdentify<string>,
    IModel,
    IExchangeRateSymbol
  {
    protected bool? _affectsConversionRates;
    protected double? _maxEntrySize;
    private const int ForexSymbolLength = 6;

    public string Id { get; set; }

    public int GroupId { get; set; }

    public int CommissionGroupId { get; set; }

    public string Description { get; set; }

    public byte Digits { get; set; }

    public TradeType TradeType { get; set; }

    public string BaseCurrencyIsoCode { get; set; }

    public string ProfitCurrencyIsoCode { get; set; }

    public double MinLots { get; set; }

    public double MaxLots { get; set; }

    public double Step { get; set; }

    public int OffQuotesThresholdSeconds { get; set; }

    public bool AvailableOnBridge { get; set; }

    public double Level2Threshold { get; set; }

    public bool AffectsExchangeRates
    {
      get
      {
        if (!this._affectsConversionRates.HasValue)
        {
          string id = this.Id;
          this._affectsConversionRates = new bool?((id != null ? (id.Length == 6 ? 1 : 0) : 0) != 0 && this.BaseCurrencyIsoCode != this.ProfitCurrencyIsoCode && (!string.IsNullOrEmpty(this.BaseCurrencyIsoCode) && !string.IsNullOrEmpty(this.ProfitCurrencyIsoCode)) && this.BaseCurrencyIsoCode + this.ProfitCurrencyIsoCode == this.Id);
        }
        return this._affectsConversionRates.Value;
      }
    }

    public int ContractSize { get; set; }

    public int ContractSizeDenominator { get; set; }

    public double TickSize { get; set; }

    public int HedgedMarginPercentage { get; set; }

    public SymbolCategoryType Category { get; set; }

    public double TrailingStopMaxRange { get; set; }

    public int TickSizeMultiplier { get; set; }

    public PriceUnitType PriceUnitType { get; set; }

    public SwapAmountType SwapType { get; set; }

    public double LongPositionsSwap { get; set; }

    public double ShortPositionsSwap { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public double TargetSpread { get; set; }

    public double AverageSpread { get; set; }

    public double TickPrice { get; set; }

    public int ThreeDaySwap { get; set; }

    public void Update(ATPlatform.Model.Entities.Symbol other)
    {
      this.Id = other.Id;
      this.GroupId = other.GroupId;
      this.CommissionGroupId = other.CommissionGroupId;
      this.Description = other.Description;
      this.Digits = other.Digits;
      this.TradeType = other.TradeType;
      this.BaseCurrencyIsoCode = other.BaseCurrencyIsoCode;
      this.ProfitCurrencyIsoCode = other.ProfitCurrencyIsoCode;
      this.MinLots = other.MinLots;
      this.MaxLots = other.MaxLots;
      this.Step = other.Step;
      this.OffQuotesThresholdSeconds = other.OffQuotesThresholdSeconds;
      this.AvailableOnBridge = other.AvailableOnBridge;
      this.TickSize = other.TickSize;
      this.ContractSize = other.ContractSize;
      this.ContractSizeDenominator = other.ContractSizeDenominator;
      this.HedgedMarginPercentage = other.HedgedMarginPercentage;
      this.Category = other.Category;
      this.TrailingStopMaxRange = other.TrailingStopMaxRange;
      this.TickSizeMultiplier = other.TickSizeMultiplier;
      this.PriceUnitType = other.PriceUnitType;
      this.SwapType = other.SwapType;
      this.LongPositionsSwap = other.LongPositionsSwap;
      this.ShortPositionsSwap = other.ShortPositionsSwap;
      this.ExpirationDate = other.ExpirationDate;
      this.TargetSpread = other.TargetSpread;
      this.AverageSpread = other.AverageSpread;
      this.TickPrice = other.TickPrice;
      this.ThreeDaySwap = other.ThreeDaySwap;
      this._affectsConversionRates = new bool?();
      this.Level2Threshold = other.Level2Threshold;
      this._maxEntrySize = new double?();
    }

    public ATPlatform.Model.Entities.Symbol Clone()
    {
      ATPlatform.Model.Entities.Symbol symbol = new ATPlatform.Model.Entities.Symbol();
      symbol.Update(this);
      return symbol;
    }

    public bool Equals(ATPlatform.Model.Entities.Symbol other)
    {
      if (this.Id == other.Id && this.AffectsExchangeRates == other.AffectsExchangeRates && (this.GroupId == other.GroupId && this.CommissionGroupId == other.CommissionGroupId) && (this.Description == other.Description && (int) this.Digits == (int) other.Digits && (this.TradeType == other.TradeType && this.BaseCurrencyIsoCode == other.BaseCurrencyIsoCode)) && (this.ProfitCurrencyIsoCode == other.ProfitCurrencyIsoCode && DoubleComparer.AreEqual(this.MinLots, other.MinLots) && (DoubleComparer.AreEqual(this.MaxLots, other.MaxLots) && DoubleComparer.AreEqual(this.Step, other.Step)) && (this.OffQuotesThresholdSeconds == other.OffQuotesThresholdSeconds && this.AvailableOnBridge == other.AvailableOnBridge && (DoubleComparer.AreEqual(this.TickSize, other.TickSize) && this.ContractSize == other.ContractSize))) && (this.ContractSizeDenominator == other.ContractSizeDenominator && this.HedgedMarginPercentage == other.HedgedMarginPercentage && (this.Category == other.Category && DoubleComparer.AreEqual(this.TrailingStopMaxRange, other.TrailingStopMaxRange)) && (this.TickSizeMultiplier == other.TickSizeMultiplier && this.PriceUnitType == other.PriceUnitType && (this.SwapType == other.SwapType && DoubleComparer.AreEqual(this.LongPositionsSwap, other.LongPositionsSwap))) && DoubleComparer.AreEqual(this.ShortPositionsSwap, other.ShortPositionsSwap)))
      {
        DateTime? expirationDate1 = this.ExpirationDate;
        DateTime? expirationDate2 = other.ExpirationDate;
        if ((expirationDate1.HasValue == expirationDate2.HasValue ? (expirationDate1.HasValue ? (expirationDate1.GetValueOrDefault() == expirationDate2.GetValueOrDefault() ? 1 : 0) : 1) : 0) != 0 && DoubleComparer.AreEqual(this.TargetSpread, other.TargetSpread) && (DoubleComparer.AreEqual(this.AverageSpread, other.AverageSpread) && DoubleComparer.AreEqual(this.TickPrice, other.TickPrice)) && this.ThreeDaySwap == other.ThreeDaySwap)
          return DoubleComparer.AreEqual(this.Level2Threshold, other.Level2Threshold);
      }
      return false;
    }

    public string GetKey() => this.Id;

    public double GetMaxEntrySize()
    {
      if (!this._maxEntrySize.HasValue)
      {
        this._maxEntrySize = new double?(this.Level2Threshold * (double) this.ContractSize);
        if (this.ContractSizeDenominator > 0)
        {
          double? maxEntrySize = this._maxEntrySize;
          double contractSizeDenominator = (double) this.ContractSizeDenominator;
          this._maxEntrySize = maxEntrySize.HasValue ? new double?(maxEntrySize.GetValueOrDefault() / contractSizeDenominator) : new double?();
        }
      }
      return this._maxEntrySize.Value;
    }
  }
}
