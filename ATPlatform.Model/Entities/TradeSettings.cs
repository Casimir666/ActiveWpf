// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Entities.TradeSettings
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

using ATPlatform.Common.Utils;
using ATPlatform.Model.Contracts;
using ATPlatform.Model.Enums.Symbol;

namespace ATPlatform.Model.Entities
{
  public class TradeSettings : 
    ISymbolOrGroupRelated,
    ICloneable<TradeSettings>,
    IUpdatable<TradeSettings>,
    IEquatable<TradeSettings>,
    IIdentify<string>
  {
    public int? SymbolGroupId { get; set; }

    public string SymbolId { get; set; }

    public double? MarginTiersMarginCoef { get; set; }

    public bool UseFixedMarginPercentage { get; set; }

    public double? MarginTiersLotsCoef { get; set; }

    public double? MaxLots { get; set; }

    public double? MinLots { get; set; }

    public double? Step { get; set; }

    public double? Level2Threshold { get; set; }

    public TradeType TradeType { get; set; }

    public bool ApplySwaps { get; set; }

    public double? MaxPositionNotionalValue { get; set; }

    public int? TagId { get; set; }

    public void Update(TradeSettings settings)
    {
      this.SymbolGroupId = settings.SymbolGroupId;
      this.SymbolId = settings.SymbolId;
      this.UseFixedMarginPercentage = settings.UseFixedMarginPercentage;
      this.MarginTiersMarginCoef = settings.MarginTiersMarginCoef;
      this.MarginTiersLotsCoef = settings.MarginTiersLotsCoef;
      this.MaxLots = settings.MaxLots;
      this.MinLots = settings.MinLots;
      this.Step = settings.Step;
      this.Level2Threshold = settings.Level2Threshold;
      this.TradeType = settings.TradeType;
      this.ApplySwaps = settings.ApplySwaps;
      this.TagId = settings.TagId;
      this.MaxPositionNotionalValue = settings.MaxPositionNotionalValue;
    }

    public TradeSettings Clone()
    {
      TradeSettings tradeSettings = new TradeSettings();
      tradeSettings.Update(this);
      return tradeSettings;
    }

    public bool Equals(TradeSettings other)
    {
      int? symbolGroupId1 = this.SymbolGroupId;
      int? symbolGroupId2 = other.SymbolGroupId;
      if (symbolGroupId1.GetValueOrDefault() == symbolGroupId2.GetValueOrDefault() & symbolGroupId1.HasValue == symbolGroupId2.HasValue && this.SymbolId == other.SymbolId && (this.UseFixedMarginPercentage == other.UseFixedMarginPercentage && DoubleComparer.AreEqual(this.MarginTiersMarginCoef, other.MarginTiersMarginCoef)) && (DoubleComparer.AreEqual(this.MarginTiersLotsCoef, other.MarginTiersLotsCoef) && DoubleComparer.AreEqual(this.MaxLots, other.MaxLots) && (DoubleComparer.AreEqual(this.MinLots, other.MinLots) && DoubleComparer.AreEqual(this.Step, other.Step))) && (DoubleComparer.AreEqual(this.Level2Threshold, other.Level2Threshold) && this.TradeType == other.TradeType && this.ApplySwaps == other.ApplySwaps))
      {
        int? tagId1 = this.TagId;
        int? tagId2 = other.TagId;
        if (tagId1.GetValueOrDefault() == tagId2.GetValueOrDefault() & tagId1.HasValue == tagId2.HasValue)
        {
          double? positionNotionalValue1 = this.MaxPositionNotionalValue;
          double? positionNotionalValue2 = other.MaxPositionNotionalValue;
          return positionNotionalValue1.GetValueOrDefault() == positionNotionalValue2.GetValueOrDefault() & positionNotionalValue1.HasValue == positionNotionalValue2.HasValue;
        }
      }
      return false;
    }

    public string GetKey()
    {
      int? symbolGroupId = this.SymbolGroupId;
      ref int? local = ref symbolGroupId;
      string str = local.HasValue ? local.GetValueOrDefault().ToString() : (string) null;
      if (str != null)
        return str;
      return !string.IsNullOrEmpty(this.SymbolId) ? this.SymbolId : (string) null;
    }
  }
}
