// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.OrderStateProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf.Reflection;

namespace ATPlatform.IDL
{
  public enum OrderStateProto
  {
    [OriginalName("UNKNOWN_STATE")] UnknownState = 0,
    [OriginalName("PENDING")] Pending = 1,
    [OriginalName("OPEN")] Open = 2,
    [OriginalName("CLOSED")] Closed = 4,
    [OriginalName("DELETED")] Deleted = 8,
    [OriginalName("CANCELED")] Canceled = 16, // 0x00000010
    [OriginalName("REJECTED")] Rejected = 32, // 0x00000020
  }
}
