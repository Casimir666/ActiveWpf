// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Enums.Symbol.TradeType
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

namespace ATPlatform.Model.Enums.Symbol
{
  public enum TradeType
  {
    Unknown = 0,
    NotAvailable = 1,
    Disabled = 2,
    CloseOnly = 4,
    LongOnly = 8,
    ShortOnly = 16, // 0x00000010
    FullAccess = 32, // 0x00000020
  }
}
