// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.OrderTypeProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf.Reflection;

namespace ATPlatform.IDL
{
  public enum OrderTypeProto
  {
    [OriginalName("UNKNOWN")] Unknown = 0,
    [OriginalName("BUY")] Buy = 1,
    [OriginalName("SELL")] Sell = 2,
    [OriginalName("BUY_LIMIT")] BuyLimit = 4,
    [OriginalName("SELL_LIMIT")] SellLimit = 8,
    [OriginalName("BUY_STOP")] BuyStop = 16, // 0x00000010
    [OriginalName("SELL_STOP")] SellStop = 32, // 0x00000020
    [OriginalName("BALANCE")] Balance = 64, // 0x00000040
  }
}
