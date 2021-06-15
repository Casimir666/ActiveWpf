// Decompiled with JetBrains decompiler
// Type: ATPlatform.Common.Utils.DateTimeOperations
// Assembly: ATPlatform.Common, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 8510DEE7-1F48-4C8D-BDF8-D15D1FBC6558
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Common.dll

using System;

namespace ATPlatform.Common.Utils
{
  public class DateTimeOperations
  {
    private static readonly DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

    public static DateTime Epoch => DateTimeOperations.epoch;

    public static DateTime FromUnixTimeStampMilliseconds(long timestamp) => DateTimeOperations.epoch.AddMilliseconds((double) timestamp);

    public static long ToUnixTimeStampMilliseconds(DateTime moment) => DateTimeOperations.FitToEpoch((long) (moment - DateTimeOperations.epoch).TotalMilliseconds);

    public static long GetUtcNowTimeStampMilliseconds() => DateTimeOperations.FitToEpoch(DateTimeOperations.ToUnixTimeStampMilliseconds(DateTime.UtcNow));

    public static DateTime FromUnixTimeStampSeconds(long timestamp) => DateTimeOperations.epoch.AddSeconds((double) timestamp);

    public static long ToUnixTimeStampSeconds(DateTime moment) => DateTimeOperations.FitToEpoch((long) (moment - DateTimeOperations.epoch).TotalSeconds);

    public static long GetUtcNowTimeStampSeconds() => DateTimeOperations.FitToEpoch(DateTimeOperations.ToUnixTimeStampSeconds(DateTime.UtcNow));

    public static long GetUtcUnixMillisecondsFromUtcMoment(DateTime utcMoment) => DateTimeOperations.FitToEpoch((long) (utcMoment - DateTimeOperations.epoch).TotalMilliseconds);

    public static DateTime GetTimeZoneSpecificDateTimeFromUnixMilliseconds(
      long unixMilliseconds,
      TimeZoneInfo timeZoneInfo)
    {
      return TimeZoneInfo.ConvertTimeFromUtc(DateTimeOperations.epoch.AddMilliseconds((double) unixMilliseconds), timeZoneInfo);
    }

    public static long GetUtcUnixMillisecondsFromTimeZoneSpecificMoment(
      DateTime moment,
      TimeZoneInfo timeZoneInfo)
    {
      long epoch;
      if (DateTimeKind.Utc == moment.Kind)
      {
        epoch = DateTimeOperations.FitToEpoch((long) (moment - DateTimeOperations.epoch).TotalMilliseconds);
      }
      else
      {
        DateTime dateTime = moment;
        if (DateTimeKind.Local == moment.Kind)
          dateTime = new DateTime(moment.Year, moment.Month, moment.Day, moment.Hour, moment.Minute, moment.Second, DateTimeKind.Unspecified);
        epoch = DateTimeOperations.FitToEpoch((long) (TimeZoneInfo.ConvertTimeToUtc(dateTime, timeZoneInfo) - DateTimeOperations.epoch).TotalMilliseconds);
      }
      return epoch;
    }

    public static DateTime RoundDateTimeLocalMinute(DateTime original, int minutes) => DateTimeOperations.RoundDateTimeLocal(original, minutes, 1, 1);

    public static DateTime RoundDateTimeLocalHour(DateTime original, int hours) => DateTimeOperations.RoundDateTimeLocal(original, 60, hours, 1);

    public static DateTime RoundDateTimeLocalDay(DateTime original, int days) => DateTimeOperations.RoundDateTimeLocal(original, 60, 24, days);

    public static DateTime RoundDateTimeLocalMonth(DateTime original)
    {
      DateTime localTime = DateTimeOperations.RoundDateTimeLocal(original, 60, 24, 1).ToLocalTime();
      return new DateTime(localTime.Year, localTime.Month, 1, 0, 0, 0, DateTimeKind.Local).ToUniversalTime();
    }

    private static DateTime RoundDateTimeLocal(
      DateTime original,
      int minutes,
      int hours,
      int days)
    {
      DateTime dateTime = original;
      DateTime localTime1 = original.ToLocalTime();
      dateTime = dateTime.AddMinutes((double) (-localTime1.Minute % minutes));
      dateTime = dateTime.AddHours((double) (-localTime1.Hour % hours));
      dateTime = dateTime.AddDays((double) (-(int) localTime1.DayOfWeek % days));
      DateTime localTime2 = dateTime.ToLocalTime();
      if (localTime1.IsDaylightSavingTime())
      {
        if (!localTime2.IsDaylightSavingTime())
          dateTime = dateTime.AddHours(1.0);
      }
      else if (localTime2.IsDaylightSavingTime())
        dateTime = dateTime.AddHours(-1.0);
      return dateTime;
    }

    private static long FitToEpoch(long unixTimestamp) => unixTimestamp >= 0L ? unixTimestamp : 0L;
  }
}
