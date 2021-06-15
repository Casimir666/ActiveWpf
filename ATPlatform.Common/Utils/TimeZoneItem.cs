// Decompiled with JetBrains decompiler
// Type: ATPlatform.Common.Utils.TimeZoneItem
// Assembly: ATPlatform.Common, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 8510DEE7-1F48-4C8D-BDF8-D15D1FBC6558
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Common.dll

using ATPlatform.Common.Defaults;

namespace ATPlatform.Common.Utils
{
  public class TimeZoneItem
  {
    public string ZoneShortName { get; set; }

    public string ZoneDisplayName { get; set; }

    public TimeZoneItem(Enums.PlatformTimeZone zone)
    {
      this.ZoneShortName = zone.ToString();
      this.ZoneDisplayName = TimeZoneHelper.SupportedTimezones[(int) zone];
    }
  }
}
