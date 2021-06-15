// Decompiled with JetBrains decompiler
// Type: ActivTrades.ActivTrader.Lightstreamer.ILightstreamerClient
// Assembly: ActivTrades.ActivTrader.Client.API, Version=3.20.0.9368, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 1DDD33EC-7764-4260-B8CC-81E638C549BC
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ActivTrades.ActivTrader.Client.API.dll

using ActivTrades.ActivTrader.Connection;
using ActivTrades.ActivTrader.Connection.Models;
using ActivTrades.ActivTrader.Lightstreamer.MarketData;
using ActivTrades.ActivTrader.Lightstreamer.Trade.Models;
using ATPlatform.IDL;
using Google.Protobuf;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ActivTrades.ActivTrader.Lightstreamer
{
  public interface ILightstreamerClient : IAPIChannel, IDisposable
  {
    event EventHandler<LsTickReceivedEventArgs> PriceUpdated;

    event EventHandler<ClientNotificationEventArgs> TradingNotificationReceived;

    event EventHandler<ClientNotificationEventArgs> MarketDataEventNotification;

    event EventHandler<ServiceStatusEventArg> ServiceStatusNotificationReceived;

    event EventHandler<APIChannelStateChangedEventArgs> ConnectionStatusChangeNotification;

    int AccountId { get; }

    bool IsReloadInProgress { get; }

    int ReloadTradeSettingsForAccountNotificationRequestId { get; }

    ClientNotification SendRequest(MessageTypeProto type, IMessage request);

    Task<ClientNotification> SendRequestAsync(
      MessageTypeProto type,
      IMessage request);

    ClientNotification SendRequest(
      MessageTypeProto type,
      IMessage request,
      TimeSpan timeout);

    Task<ClientNotification> SendRequestAsync(
      MessageTypeProto type,
      IMessage request,
      TimeSpan timeout);

    IEnumerable<ClientNotification> SendRequest(
      MessageTypeProto type,
      IMessage request,
      int expectedNotifications);

    Task<IEnumerable<ClientNotification>> SendRequestAsync(
      MessageTypeProto type,
      IMessage request,
      int expectedNotifications);

    IEnumerable<ClientNotification> SendRequest(
      MessageTypeProto type,
      IMessage request,
      int expectedNotifications,
      TimeSpan timeout);

    Task<IEnumerable<ClientNotification>> SendRequestAsync(
      MessageTypeProto type,
      IMessage request,
      int expectedNotifications,
      TimeSpan timeout);

    string Token { get; }

    AccountProto Account { get; }

    AccountTradeSummaryProto BalanceInfo { get; }

    GetServerPublicInfoNotificationProto ServerPublicInfo { get; }

    IDictionary<string, SymbolProto> SymbolConfigurations { get; }

    IEnumerable<SymbolGroupProto> SymbolGroups { get; }

    ConcurrentDictionary<string, SymbolTradingSessionsProto> SymbolTradingSessions { get; }

    ConcurrentDictionary<string, SymbolMarginTiersProto> SymbolMarginTiers { get; }

    MarkupSettingsSetProto MarkupSettingsSet { get; }

    IDictionary<long, OrderProto> PendingOrders { get; }

    IDictionary<long, OrderProto> OpenedOrders { get; }

    IDictionary<long, OrderProto> ClosedOrders { get; }

    IDictionary<int, ClientMessageProto> ClientMessages { get; }

    NewTickNotificationProto LastNewTickNotification { get; }

    void SubscribeForPriceUpdates(string symbol);

    void Reload();
  }
}
