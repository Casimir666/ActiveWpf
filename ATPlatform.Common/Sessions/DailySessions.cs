// Decompiled with JetBrains decompiler
// Type: ATPlatform.Common.Sessions.DailySessions`1
// Assembly: ATPlatform.Common, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 8510DEE7-1F48-4C8D-BDF8-D15D1FBC6558
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Common.dll

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ATPlatform.Common.Sessions
{
  public class DailySessions<TSession> : IDailySessions<TSession>, IDailySessions
    where TSession : IDailySession, IDailySession<TSession>, new()
  {
    private static readonly int _initCapacity = 16;
    private static readonly int _notInitialized = -1;
    private readonly List<TSession> _sessionsStorage = new List<TSession>(DailySessions<TSession>._initCapacity);
    private readonly object _sessionsLock = new object();
    private static readonly int _empty = 0;
    private TimeSpan _timeZoneOffset;
    private DayOfWeek _lastDayRequested;
    private int _lastMinuteRequested;
    private int _currentEndMinute = DailySessions<TSession>._notInitialized;
    private ReadOnlyCollection<TSession> _sessions = new ReadOnlyCollection<TSession>((IList<TSession>) new List<TSession>(DailySessions<TSession>._initCapacity));
    private readonly TSession currentSession = new TSession();

    public DailySessions()
    {
      this.TimeZoneInfo = TimeZoneInfo.Local;
      this.SetUTCOffset();
    }

    public DailySessions(TimeZoneInfo timeZoneInfo) => this.TimeZoneInfo = timeZoneInfo;

    public TimeZoneInfo TimeZoneInfo { get; }

    public IReadOnlyCollection<TSession> Sessions => (IReadOnlyCollection<TSession>) this._sessionsStorage;

    public void Add(TSession session)
    {
      this.AddSessionToStorage(session);
      this.CopySessionsFromStorage();
    }

    public void AddRange(IReadOnlyCollection<TSession> sessions)
    {
      foreach (TSession session in (IEnumerable<TSession>) sessions)
        this.AddSessionToStorage(session);
      this.CopySessionsFromStorage();
    }

    public void Clear()
    {
      lock (this._sessionsLock)
      {
        this._sessionsStorage.Clear();
        this._sessions = new ReadOnlyCollection<TSession>((IList<TSession>) new List<TSession>());
      }
    }

    public bool HasActiveSession() => this.HasActiveSession(this.GetDateTimeNow());

    public bool HasActiveSession(DateTime? expirationDateTime)
    {
      DateTime dateTimeNow = this.GetDateTimeNow();
      if (expirationDateTime.HasValue)
      {
        DateTime dateTime = dateTimeNow;
        DateTime? nullable = expirationDateTime;
        if ((nullable.HasValue ? (dateTime >= nullable.GetValueOrDefault() ? 1 : 0) : 0) != 0)
          return false;
      }
      return this.HasActiveSession(dateTimeNow);
    }

    private DateTime GetDateTimeNow() => DateTime.UtcNow + this._timeZoneOffset;

    private bool HasActiveSession(DateTime now)
    {
      DayOfWeek dayOfWeek = now.DayOfWeek;
      int minuteOfDay = now.Hour * 60 + now.Minute;
      if (this._currentEndMinute == DailySessions<TSession>._notInitialized || this._lastDayRequested != dayOfWeek || this._lastMinuteRequested > minuteOfDay)
      {
        this.SetCurrentSession(dayOfWeek, minuteOfDay);
        return this.CheckIsInSession(dayOfWeek, minuteOfDay);
      }
      if (this._currentEndMinute > DailySessions<TSession>._empty && minuteOfDay > this._currentEndMinute)
        this.SetCurrentSession(dayOfWeek, minuteOfDay);
      return this.CheckIsInSession(dayOfWeek, minuteOfDay);
    }

    private void SetUTCOffset() => this._timeZoneOffset = this.TimeZoneInfo.GetUtcOffset(DateTime.Now);

    private bool CheckIsInSession(DayOfWeek day, int minuteOfDay)
    {
      this._lastDayRequested = day;
      this._lastMinuteRequested = minuteOfDay;
      return this._currentEndMinute > DailySessions<TSession>._empty && minuteOfDay >= this.currentSession.StartFrame && minuteOfDay < this.currentSession.EndFrame;
    }

    private void SetCurrentSession(DayOfWeek dayOfWeek, int minuteOfDay)
    {
      lock (this._sessionsLock)
      {
        this.SetUTCOffset();
        TSession session = this._sessions.FirstOrDefault<TSession>((Func<TSession, bool>) (ts => ts.DayOfWeek == dayOfWeek && minuteOfDay < ts.EndFrame));
        TSession currentSession = this.currentSession;
        currentSession.Update(session ?? new TSession());
        currentSession = this.currentSession;
        ref TSession local = ref currentSession;
        this._currentEndMinute = ((object) local != null ? new int?(local.EndFrame) : new int?()).Value;
      }
    }

    private void CopySessionsFromStorage()
    {
      lock (this._sessionsLock)
      {
        this._sessions = new ReadOnlyCollection<TSession>((IList<TSession>) this.Sessions.OrderBy<TSession, int>((Func<TSession, int>) (s => (int) s.DayOfWeek)).ThenBy<TSession, int>((Func<TSession, int>) (s => s.StartFrame)).Select<TSession, TSession>((Func<TSession, TSession>) (ts => ts.Clone())).ToList<TSession>());
        this._currentEndMinute = DailySessions<TSession>._notInitialized;
      }
    }

    private void AddSessionToStorage(TSession session)
    {
      this.EnsureIsValid((IDailySession) session);
      this._sessionsStorage.Add(session);
    }

    private void EnsureIsValid(IDailySession session)
    {
      foreach (TSession session1 in this._sessionsStorage)
      {
        if ((object) session1 == session)
          throw new InvalidOperationException(string.Format("Adding session which is already present. {0}", (object) session));
      }
    }
  }
}
