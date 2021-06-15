// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.PlatformTimeZoneProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf.Reflection;

namespace ATPlatform.IDL
{
  public enum PlatformTimeZoneProto
  {
    [OriginalName("UNDEFINED_TIME_ZONE")] UndefinedTimeZone,
    [OriginalName("UTC")] Utc,
    [OriginalName("UTC_MINUS8_PACIFIC_TIME")] UtcMinus8PacificTime,
    [OriginalName("UTC_MINUS7_MOUNTAIN_TIME")] UtcMinus7MountainTime,
    [OriginalName("UTC_MINUS6_CENTRAL_TIME")] UtcMinus6CentralTime,
    [OriginalName("UTC_MINUS5_EASTERN_TIME")] UtcMinus5EasternTime,
    [OriginalName("UTC_PLUS0_LONDON")] UtcPlus0London,
    [OriginalName("UTC_PLUS1_AMSTERDAM")] UtcPlus1Amsterdam,
    [OriginalName("UTC_PLUS2_SOFIA")] UtcPlus2Sofia,
    [OriginalName("UTC_PLUS3_MOSCOW")] UtcPlus3Moscow,
    [OriginalName("UTC_PLUS8_BEIJING")] UtcPlus8Beijing,
    [OriginalName("UTC_PLUS9_TOKYO")] UtcPlus9Tokyo,
    [OriginalName("UTC_PLUS10_SYDNEY")] UtcPlus10Sydney,
  }
}
