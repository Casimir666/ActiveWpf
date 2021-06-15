// Decompiled with JetBrains decompiler
// Type: ActivTrades.ActivTrader.Lightstreamer.Trade.Models.ClientNotifications
// Assembly: ActivTrades.ActivTrader.Client.API, Version=3.20.0.9368, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 1DDD33EC-7764-4260-B8CC-81E638C549BC
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ActivTrades.ActivTrader.Client.API.dll

using System.Collections.Generic;

namespace ActivTrades.ActivTrader.Lightstreamer.Trade.Models
{
  public class ClientNotifications
  {
    public int RequestId { get; set; }

    public bool IsCompleted
    {
      get
      {
        if (!this.ExpectedNotificationsCount.HasValue)
          return false;
        int num = this.ExpectedNotificationsCount.Value;
        int? count = this.Notifications?.Count;
        int valueOrDefault = count.GetValueOrDefault();
        return num == valueOrDefault & count.HasValue;
      }
    }

    public int? ExpectedNotificationsCount { get; set; }

    public IList<ClientNotification> Notifications { get; set; }
  }
}
