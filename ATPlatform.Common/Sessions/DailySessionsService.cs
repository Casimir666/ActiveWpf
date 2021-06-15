// Decompiled with JetBrains decompiler
// Type: ATPlatform.Common.Sessions.DailySessionsService`1
// Assembly: ATPlatform.Common, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 8510DEE7-1F48-4C8D-BDF8-D15D1FBC6558
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Common.dll

using System.Collections.Generic;

namespace ATPlatform.Common.Sessions
{
  public class DailySessionsService<TSession> : IDailySessionsService<TSession> where TSession : IDailySession, new()
  {
    private readonly Dictionary<string, IDailySessions<TSession>> _sessionsMap = new Dictionary<string, IDailySessions<TSession>>(10000);

    public void Initialize(
      IDictionary<string, IDailySessions<TSession>> sessions)
    {
      foreach (KeyValuePair<string, IDailySessions<TSession>> session in (IEnumerable<KeyValuePair<string, IDailySessions<TSession>>>) sessions)
        this._sessionsMap.Add(session.Key, session.Value);
    }

    public void Clear() => this._sessionsMap.Clear();

    public bool HasActiveSession(string sessionsOwner)
    {
      IDailySessions<TSession> dailySessions;
      return this._sessionsMap.TryGetValue(sessionsOwner, out dailySessions) && dailySessions.HasActiveSession();
    }

    public void AddOrUpdate(string owner, IDailySessions<TSession> sessions)
    {
      IDailySessions<TSession> dailySessions;
      if (this._sessionsMap.TryGetValue(owner, out dailySessions))
        dailySessions.AddRange(sessions.Sessions);
      else
        this._sessionsMap.Add(owner, sessions);
    }
  }
}
