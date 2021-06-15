// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Enums.Order.OrderTransactionType
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

using System;

namespace ATPlatform.Model.Enums.Order
{
  [Flags]
  public enum OrderTransactionType
  {
    Unknown = 0,
    ClientOpen = 1,
    ClientClose = 2,
    ClientModify = 4,
    ClientCancel = 8,
    ClientPartialClose = 16, // 0x00000010
    ClientCloseHedged = 32, // 0x00000020
    ClientNet = 64, // 0x00000040
    AdminOpen = 128, // 0x00000080
    AdminClose = 256, // 0x00000100
    AdminModify = 512, // 0x00000200
    AdminCancel = 1024, // 0x00000400
    AdminActivate = 2048, // 0x00000800
    AdminPartialClose = 4096, // 0x00001000
    AdminNet = 8192, // 0x00002000
    TickActivateLimit = 32768, // 0x00008000
    TickActivateStop = 65536, // 0x00010000
    TickCancel = 131072, // 0x00020000
    TickTakeProfit = 262144, // 0x00040000
    TickStopLoss = 524288, // 0x00080000
    TickStopOut = 1048576, // 0x00100000
    ServerOpen = 2097152, // 0x00200000
    ServerClose = 4194304, // 0x00400000
    ServerSwap = 8388608, // 0x00800000
    ServerModify = 16777216, // 0x01000000
    ServerCloseHedged = 33554432, // 0x02000000
    AdminDelete = 268435456, // 0x10000000
    AdminReOpen = 536870912, // 0x20000000
  }
}
