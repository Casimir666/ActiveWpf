// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.PlatformTypeProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf.Reflection;

namespace ATPlatform.IDL
{
  public enum PlatformTypeProto
  {
    [OriginalName("UNDEFINED_TRADING_PLATFORM")] UndefinedTradingPlatform,
    [OriginalName("AT_PLATFORM")] AtPlatform,
    [OriginalName("MT4")] Mt4,
  }
}
