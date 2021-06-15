// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.MarketDataEvents.MarketDataEventTypeProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf.Reflection;

namespace ATPlatform.IDL.MarketDataEvents
{
  public enum MarketDataEventTypeProto
  {
    [OriginalName("UNDEFINED_MARKET_DATA_EVENT_TYPE")] UndefinedMarketDataEventType,
    [OriginalName("PRICE_RISE_PERCENTAGE_TYPE")] PriceRisePercentageType,
    [OriginalName("PRICE_FALLS_PERCENTAGE_TYPE")] PriceFallsPercentageType,
    [OriginalName("PRICE_HIGH_TRESHOLD_TYPE")] PriceHighTresholdType,
    [OriginalName("PRICE_LOW_TRESHOLD_TYPE")] PriceLowTresholdType,
    [OriginalName("RESISTANCE_LEVEL_TYPE")] ResistanceLevelType,
    [OriginalName("SUPPORT_LEVEL_TYPE")] SupportLevelType,
  }
}
