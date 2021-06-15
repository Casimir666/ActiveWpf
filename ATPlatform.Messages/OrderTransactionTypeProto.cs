// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.OrderTransactionTypeProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf.Reflection;

namespace ATPlatform.IDL
{
  public enum OrderTransactionTypeProto
  {
    [OriginalName("UNKNOWN_ORDER_TRANSACTION_TYPE")] UnknownOrderTransactionType = 0,
    [OriginalName("CLIENT_OPEN")] ClientOpen = 1,
    [OriginalName("CLIENT_CLOSE")] ClientClose = 2,
    [OriginalName("CLIENT_MODIFY")] ClientModify = 4,
    [OriginalName("CLIENT_CANCEL")] ClientCancel = 8,
    [OriginalName("CLIENT_PARTIAL_CLOSE")] ClientPartialClose = 16, // 0x00000010
    [OriginalName("CLIENT_CLOSE_HEDGED")] ClientCloseHedged = 32, // 0x00000020
    [OriginalName("CLIENT_NET")] ClientNet = 64, // 0x00000040
    [OriginalName("ADMIN_OPEN")] AdminOpen = 128, // 0x00000080
    [OriginalName("ADMIN_CLOSE")] AdminClose = 256, // 0x00000100
    [OriginalName("ADMIN_MODIFY")] AdminModify = 512, // 0x00000200
    [OriginalName("ADMIN_CANCEL")] AdminCancel = 1024, // 0x00000400
    [OriginalName("ADMIN_ACTIVATE")] AdminActivate = 2048, // 0x00000800
    [OriginalName("ADMIN_PARTIAL_CLOSE")] AdminPartialClose = 4096, // 0x00001000
    [OriginalName("ADMIN_NET")] AdminNet = 8192, // 0x00002000
    [OriginalName("TICK_ACTIVATE_LIMIT")] TickActivateLimit = 32768, // 0x00008000
    [OriginalName("TICK_ACTIVATE_STOP")] TickActivateStop = 65536, // 0x00010000
    [OriginalName("TICK_CANCEL")] TickCancel = 131072, // 0x00020000
    [OriginalName("TICK_TAKE_PROFIT")] TickTakeProfit = 262144, // 0x00040000
    [OriginalName("TICK_STOP_LOSS")] TickStopLoss = 524288, // 0x00080000
    [OriginalName("TICK_STOP_OUT")] TickStopOut = 1048576, // 0x00100000
    [OriginalName("SERVER_OPEN")] ServerOpen = 2097152, // 0x00200000
    [OriginalName("SERVER_CLOSE")] ServerClose = 4194304, // 0x00400000
    [OriginalName("SERVER_SWAP")] ServerSwap = 8388608, // 0x00800000
    [OriginalName("SERVER_MODIFY")] ServerModify = 16777216, // 0x01000000
    [OriginalName("SERVER_CLOSE_HEDGED")] ServerCloseHedged = 33554432, // 0x02000000
    [OriginalName("ADMIN_DELETE")] AdminDelete = 268435456, // 0x10000000
    [OriginalName("ADMIN_RE_OPEN")] AdminReOpen = 536870912, // 0x20000000
  }
}
