// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.TradeTypeProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf.Reflection;

namespace ATPlatform.IDL
{
  public enum TradeTypeProto
  {
    [OriginalName("UNKNOWN_TRADE_TYPE")] UnknownTradeType = 0,
    [OriginalName("NOT_AVAILABLE")] NotAvailable = 1,
    [OriginalName("DISABLED")] Disabled = 2,
    [OriginalName("CLOSE_ONLY")] CloseOnly = 4,
    [OriginalName("LONG_ONLY")] LongOnly = 8,
    [OriginalName("SHORT_ONLY")] ShortOnly = 16, // 0x00000010
    [OriginalName("FULL_ACCESS")] FullAccess = 32, // 0x00000020
  }
}
