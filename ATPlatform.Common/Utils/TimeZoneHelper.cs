// Decompiled with JetBrains decompiler
// Type: ATPlatform.Common.Utils.TimeZoneHelper
// Assembly: ATPlatform.Common, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 8510DEE7-1F48-4C8D-BDF8-D15D1FBC6558
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Common.dll

using ATPlatform.Common.Defaults;
using System;
using System.Collections.Generic;

namespace ATPlatform.Common.Utils
{
  public static class TimeZoneHelper
  {
    public static readonly List<string> SupportedTimezones = new List<string>()
    {
      "Undefined",
      "Coordinated Universal Time",
      "Pacific Standard Time",
      "Mountain Standard Time",
      "Central Standard Time",
      "Eastern Standard Time",
      "GMT Standard Time",
      "W. Europe Standard Time",
      "FLE Standard Time",
      "Russia TZ 2 Standard Time",
      "China Standard Time",
      "Tokyo Standard Time",
      "AUS Eastern Standard Time"
    };

    public static TimeZoneInfo GetTimeZoneById(int id)
    {
      if (id < 0 || id > TimeZoneHelper.SupportedTimezones.Count)
        id = 0;
      return TimeZoneInfo.FindSystemTimeZoneById(TimeZoneHelper.SupportedTimezones[id]);
    }

    public static List<TimeZoneItem> GetAllSupportedTimeZones()
    {
      List<TimeZoneItem> timeZoneItemList = new List<TimeZoneItem>();
      foreach (Enums.PlatformTimeZone zone in Enum.GetValues(typeof (Enums.PlatformTimeZone)))
      {
        TimeZoneItem timeZoneItem = new TimeZoneItem(zone);
        timeZoneItemList.Add(timeZoneItem);
      }
      return timeZoneItemList;
    }
  }
}
