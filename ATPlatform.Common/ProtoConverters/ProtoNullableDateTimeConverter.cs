// Decompiled with JetBrains decompiler
// Type: ATPlatform.Common.ProtoConverters.ProtoNullableDateTimeConverter
// Assembly: ATPlatform.Common, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 8510DEE7-1F48-4C8D-BDF8-D15D1FBC6558
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Common.dll

using ATPlatform.Common.Utils;
using System;

namespace ATPlatform.Common.ProtoConverters
{
  public static class ProtoNullableDateTimeConverter
  {
    public static TimeZoneInfo TimeZoneInfo { get; set; } = TimeZoneInfo.Utc;

    public static DateTime? GetFromProto(long epox) => epox <= 0L ? new DateTime?() : new DateTime?(DateTimeOperations.GetTimeZoneSpecificDateTimeFromUnixMilliseconds(epox, ProtoNullableDateTimeConverter.TimeZoneInfo));

    public static long GetFromModel(DateTime? date) => !date.HasValue ? 0L : DateTimeOperations.GetUtcUnixMillisecondsFromTimeZoneSpecificMoment(date.Value, ProtoNullableDateTimeConverter.TimeZoneInfo);
  }
}
