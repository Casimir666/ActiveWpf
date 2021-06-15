// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Enums.Order.OrderType
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

namespace ATPlatform.Model.Enums.Order
{
  public enum OrderType
  {
    Unknown = 0,
    Buy = 1,
    Sell = 2,
    BuyLimit = 4,
    SellLimit = 8,
    BuyStop = 16, // 0x00000010
    SellStop = 32, // 0x00000020
    Balance = 64, // 0x00000040
    Credit = 128, // 0x00000080
  }
}
