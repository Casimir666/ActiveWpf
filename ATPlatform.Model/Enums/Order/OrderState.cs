// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Enums.Order.OrderState
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

using System;

namespace ATPlatform.Model.Enums.Order
{
  [Flags]
  public enum OrderState
  {
    Unknown = 0,
    Pending = 1,
    Open = 2,
    Closed = 4,
    Deleted = 8,
    Canceled = 16, // 0x00000010
    Rejected = 32, // 0x00000020
  }
}
