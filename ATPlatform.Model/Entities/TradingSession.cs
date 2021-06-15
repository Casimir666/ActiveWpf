// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Entities.TradingSession
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

using ATPlatform.Common.Sessions;
using ATPlatform.Model.Contracts;
using System;

namespace ATPlatform.Model.Entities
{
  public class TradingSession : 
    IDailySession<TradingSession>,
    IDailySession,
    ICloneable<TradingSession>,
    IUpdatable<TradingSession>,
    Contracts.IEquatable<TradingSession>
  {
    public DayOfWeek DayOfWeek { get; set; }

    public int StartHour { get; set; }

    public int StartMinute { get; set; }

    public int EndHour { get; set; }

    public int EndMinute { get; set; }

    public TimeSpan StartTimeSpan => new TimeSpan(0, this.StartHour, this.StartMinute, 0);

    public TimeSpan EndTimeSpan => new TimeSpan(0, this.EndHour, this.EndMinute, 0);

    public int StartFrame { get; set; }

    public int EndFrame { get; set; }

    public TradingSession Clone()
    {
      TradingSession tradingSession = new TradingSession();
      tradingSession.Update(this);
      return tradingSession;
    }

    public void Update(TradingSession tradingSession)
    {
      this.DayOfWeek = tradingSession.DayOfWeek;
      this.StartHour = tradingSession.StartHour;
      this.StartMinute = tradingSession.StartMinute;
      this.EndHour = tradingSession.EndHour;
      this.EndMinute = tradingSession.EndMinute;
      this.StartFrame = tradingSession.StartHour * 60 + tradingSession.StartMinute;
      this.EndFrame = tradingSession.EndHour < 24 ? tradingSession.EndHour * 60 + tradingSession.EndMinute : 1440;
    }

    public bool Equals(TradingSession other) => this.DayOfWeek == other.DayOfWeek && this.StartHour == other.StartHour && (this.StartMinute == other.StartMinute && this.EndHour == other.EndHour) && this.EndMinute == other.EndMinute;

    public override string ToString() => string.Format("{0} [{1:D2}:{2:D2} - {3:D2}:{4:D2}]", (object) this.DayOfWeek, (object) this.StartHour, (object) this.StartMinute, (object) this.EndHour, (object) this.EndMinute);
  }
}
