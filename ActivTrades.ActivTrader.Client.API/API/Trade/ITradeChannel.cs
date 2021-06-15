// Decompiled with JetBrains decompiler
// Type: ActivTrades.ActivTrader.API.Trade.ITradeChannel
// Assembly: ActivTrades.ActivTrader.Client.API, Version=3.20.0.9368, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 1DDD33EC-7764-4260-B8CC-81E638C549BC
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ActivTrades.ActivTrader.Client.API.dll

using ActivTrades.ActivTrader.API.Models;
using ActivTrades.ActivTrader.Connection;
using ATPlatform.Model.Entities;
using ATPlatform.Model.Enums;
using ATPlatform.Model.Enums.ClientMessage;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ActivTrades.ActivTrader.API.Trade
{
  public interface ITradeChannel : IAPIChannel, IDisposable
  {
    event EventHandler<OrderNotificationEventArgs> OrderNotification;

    event EventHandler<ClientMessageNotificationEventArgs> ClientMessageNotification;

    event EventHandler<MarketDataEventNotificationEventArgs> MarketDataEventNotification;

    Task ConnectAsync();

    TimeZoneInfo GetTimeZoneInfo();

    Account GetAccount();

    TradeSummary GetTradeSummary();

    IReadOnlyCollection<SymbolGroup> GetSymbolGroups();

    SymbolGroup GetSymbolGroup(int id);

    IReadOnlyCollection<Symbol> GetSymbols();

    Symbol GetSymbol(string symbol);

    bool IsInSessionAndNotExpired(string symbol);

    IReadOnlyCollection<TradingSession> GetSymbolTradingSessions(
      string symbol);

    IReadOnlyCollection<Order> GetOrders();

    IReadOnlyCollection<Order> GetOrders(string symbol);

    Order GetOrder(string symbol, long orderId);

    IReadOnlyCollection<Bar> GetBars(
      string symbol,
      HistoryQuotesPeriod period);

    Task<IReadOnlyCollection<Bar>> GetBarsAsync(
      string symbol,
      HistoryQuotesPeriod period);

    ClosedOrdersAndBalanceOperations GetClosedOrdersAndBalanceOperations(
      DateTime fromDateTime,
      DateTime toDateTime);

    Task<ClosedOrdersAndBalanceOperations> GetClosedOrdersAndBalanceOperationsAsync(
      DateTime fromDateTime,
      DateTime toDateTime);

    double RequiredMarginGet(OrderRequest orderRequest);

    Task<double> RequiredMarginGetAsync(OrderRequest orderRequest);

    Order OpenOrder(OrderRequest orderRequest);

    Task<Order> OpenOrderAsync(OrderRequest orderRequest);

    Order ModifyOrder(OrderRequest orderRequest);

    Task<Order> ModifyOrderAsync(OrderRequest orderRequest);

    Order CloseMarketOrder(OrderRequest orderRequest);

    Task<Order> CloseMarketOrderAsync(OrderRequest orderRequest);

    Order CancelPendingOrder(OrderRequest orderRequest);

    Task<Order> CancelPendingOrderAsync(OrderRequest orderRequest);

    IReadOnlyCollection<ATPlatform.Model.Entities.ClientMessage> GetClientMessages(
      GetClientMessagesForAccountRequest request);

    Task<IReadOnlyCollection<ATPlatform.Model.Entities.ClientMessage>> GetClientMessagesAsync(
      GetClientMessagesForAccountRequest request);

    int GetClientMessagesCount(GetClientMessagesForAccountRequest request);

    Task<int> GetClientMessagesCountAsync(GetClientMessagesForAccountRequest request);

    void SetClientMessageAccountState(
      ATPlatform.Model.Entities.ClientMessage clientMessage,
      ClientMessageAccountState clientMessageAccountState);

    Task SetClientMessageAccountStateAsync(
      ATPlatform.Model.Entities.ClientMessage clientMessage,
      ClientMessageAccountState clientMessageAccountState);
  }
}
