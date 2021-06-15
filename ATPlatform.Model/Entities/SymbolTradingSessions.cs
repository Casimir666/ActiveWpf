// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Entities.SymbolTradingSessions
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

using ATPlatform.Common.Sessions;
using ATPlatform.Model.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ATPlatform.Model.Entities
{
  public class SymbolTradingSessions : 
    ICloneable<SymbolTradingSessions>,
    IUpdatable<SymbolTradingSessions>,
    Contracts.IEquatable<SymbolTradingSessions>
  {
    protected readonly TimeZoneInfo _timeZoneInfo;
    protected readonly IDailySessions<TradingSession> _tradingSessions;

    public SymbolTradingSessions()
    {
      this._timeZoneInfo = TimeZoneInfo.Local;
      this._tradingSessions = (IDailySessions<TradingSession>) new DailySessions<TradingSession>(this._timeZoneInfo);
    }

    public SymbolTradingSessions(string symbolId, TimeZoneInfo timeZoneInfo)
    {
      this.SymbolId = symbolId;
      this._timeZoneInfo = timeZoneInfo;
      this._tradingSessions = (IDailySessions<TradingSession>) new DailySessions<TradingSession>(timeZoneInfo);
    }

    public string SymbolId { get; private set; }

    public IReadOnlyCollection<TradingSession> Sessions => this._tradingSessions.Sessions;

    public bool InSessionAndNotExpired => this._tradingSessions.HasActiveSession();

    public bool InSessionAndNotExpiredAt(DateTime moment) => this._tradingSessions.HasActiveSession(new DateTime?(moment));

    public void AddTradingSessions(TradingSession tradingSession) => this._tradingSessions.Add(tradingSession);

    public void AddTradingSessions(IReadOnlyCollection<TradingSession> sessions) => this._tradingSessions.AddRange(sessions);

    public void Clear() => this._tradingSessions.Clear();

    public SymbolTradingSessions Clone()
    {
      SymbolTradingSessions symbolTradingSessions = new SymbolTradingSessions(this.SymbolId, this._timeZoneInfo);
      symbolTradingSessions.Update(this);
      return symbolTradingSessions;
    }

    public void Update(SymbolTradingSessions other)
    {
      this.SymbolId = other.SymbolId;
      this._tradingSessions.Clear();
      foreach (TradingSession session in other.Sessions.ToList<TradingSession>())
        this._tradingSessions.Add(session);
    }

    public bool Equals(SymbolTradingSessions other) => this.SymbolId == other.SymbolId && this.Sessions.AreEqual<TradingSession>((IEnumerable<TradingSession>) other.Sessions);
  }
}
