// Decompiled with JetBrains decompiler
// Type: ActivTrades.ActivTrader.Lightstreamer.Trade.ILsTradeClient
// Assembly: ActivTrades.ActivTrader.Client.API, Version=3.20.0.9368, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 1DDD33EC-7764-4260-B8CC-81E638C549BC
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ActivTrades.ActivTrader.Client.API.dll

using ActivTrades.ActivTrader.Connection;
using ActivTrades.ActivTrader.Lightstreamer.Trade.Models;
using System;
using System.Threading.Tasks;

namespace ActivTrades.ActivTrader.Lightstreamer.Trade
{
  public interface ILsTradeClient : IAPIChannel, IDisposable
  {
    event EventHandler<ClientNotificationEventArgs> ClientNotificationReceived;

    ClientNotification Request(ClientRequest request);

    Task<ClientNotification> RequestAsync(ClientRequest request);

    ClientNotification Request(ClientRequest request, TimeSpan requestTimeout);

    Task<ClientNotification> RequestAsync(
      ClientRequest request,
      TimeSpan requestTimeout);

    ClientNotifications RequestMany(
      ClientRequest request,
      int expectedNotifications);

    Task<ClientNotifications> RequestManyAsync(
      ClientRequest request,
      int expectedNotifications);

    ClientNotifications RequestMany(
      ClientRequest request,
      TimeSpan requestTimeout);

    Task<ClientNotifications> RequestManyAsync(
      TimeSpan requestTimeout,
      ClientRequest request);

    ClientNotifications RequestMany(
      ClientRequest request,
      int expectedNotifications,
      TimeSpan requestTimeout);

    Task<ClientNotifications> RequestManyAsync(
      ClientRequest request,
      int expectedNotifications,
      TimeSpan requestTimeout);
  }
}
