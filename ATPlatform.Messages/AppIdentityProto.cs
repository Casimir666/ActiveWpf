// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.AppIdentityProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf.Reflection;

namespace ATPlatform.IDL
{
  public enum AppIdentityProto
  {
    [OriginalName("UNDEFINED_APP")] UndefinedApp = 0,
    [OriginalName("AT_SERVER")] AtServer = 1,
    [OriginalName("LIGHT_STREAMER")] LightStreamer = 10, // 0x0000000A
    [OriginalName("SQL_PROXY")] SqlProxy = 20, // 0x00000014
    [OriginalName("JOURNAL")] Journal = 30, // 0x0000001E
    [OriginalName("HEDGING_BRIDGE")] HedgingBridge = 40, // 0x00000028
    [OriginalName("LEVEL2_PRICE_CALCULATOR")] Level2PriceCalculator = 49, // 0x00000031
    [OriginalName("BOATS")] Boats = 50, // 0x00000032
    [OriginalName("EXTERNAL_SERVICES")] ExternalServices = 60, // 0x0000003C
    [OriginalName("CLIENT_MESSAGES")] ClientMessages = 70, // 0x00000046
    [OriginalName("MARKET_DATA_EVENTS")] MarketDataEvents = 72, // 0x00000048
    [OriginalName("MARKET_DATA_EVENTS_CLIENTS")] MarketDataEventsClients = 74, // 0x0000004A
    [OriginalName("EXPERT_ADVISORS")] ExpertAdvisors = 80, // 0x00000050
    [OriginalName("AT_ADMIN")] AtAdmin = 100, // 0x00000064
  }
}
