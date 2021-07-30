using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using ActivTrades.ActivTrader.API;
using ActivTrades.ActivTrader.API.Models;
using ActivTrades.ActivTrader.Connection.Models;
using ActivWpf.Service;
using ActivWpf.Utils;
using ATPlatform.Model.Entities;
using ATPlatform.Model.Enums.Order;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Input;

namespace ActivWpf.ViewModels
{
    class ActiveViewModel : ObservableObject
    {
        private readonly IActivTraderAPI _api;
        private readonly IDispatcherService _dispatcherService;
        private readonly ViewModelFactory _viewModelFactory;
        private readonly List<string> _manualMarketUpdate = new();
        private readonly DispatcherTimer _manualMarketTimer;

        public ObservableCollection<SymbolViewModel> Symbols { get; }

        public ObservableCollection<OrderViewModel> Orders { get; }

        public ObservableCollection<OrderViewModel> Positions { get; }

        public ObservableCollection<OrderViewModel> History { get; }

        public ActiveViewModel(
            IActivTraderAPI api, 
            IDispatcherService dispatcherService,
            ViewModelFactory viewModelFactory)
        {
            _api = api;
            _dispatcherService = dispatcherService;
            _viewModelFactory = viewModelFactory;

            Symbols = new ObservableCollection<SymbolViewModel>();
            Orders = new ObservableCollection<OrderViewModel>();
            Positions = new ObservableCollection<OrderViewModel>();
            History = new ObservableCollection<OrderViewModel>();

            _manualMarketTimer = new DispatcherTimer(DispatcherPriority.Normal, Application.Current.Dispatcher)
            {
                Interval = TimeSpan.FromSeconds(1),
                IsEnabled = false
            };
            _manualMarketTimer.Tick += OnManualMarketTimer;
        }

        public async Task ConnectAsync(IEnumerable<string> symbolNames = null)
        {
            _api.ClientMessageNotification += OnClientMessageNotification;
            _api.MarketDataEventNotification += OnMarketDataEventNotification;
            _api.MarketDataUpdate += OnMarketDataUpdate;
            _api.OrderNotification += OnOrderNotification;
            _api.StateChanged += OnStateChanged;

            try
            {
                await _api.ConnectAsync();
                var utcNow = DateTime.UtcNow;
                var closedOrders = await _api.GetClosedOrdersAndBalanceOperationsAsync(utcNow - TimeSpan.FromDays(7), utcNow);

                /*var newOrder = await _api.OpenOrderAsync(new OrderRequest
                {
                    Symbol = "AUDUSD",
                    OrderType = OrderType.BuyLimit,
                    Price = 0.7,
                    Lots = 0.05, 
                    AccountId = _api.GetAccount().Id
                });*/

                Application.Current.Dispatcher.Invoke(() =>
                {
                    if (symbolNames != null)
                    {
                        foreach (var symbolName in symbolNames)
                        {
                            try
                            {
                                Symbols.Add(_viewModelFactory.CreateSymbolViewModel(_api.GetSymbol(symbolName)));
                                _api.Subscribe(symbolName);
                            }
                            catch (Exception ex)
                            {
                                // Symbol not found!
                                _manualMarketUpdate.Add(symbolName);
                            }
                        }
                    }

                    _manualMarketTimer.Start();

                    foreach (var order in _api.GetOrders())
                    {
                        switch (order.State)
                        {
                            case OrderState.Pending:
                                Positions.Add(_viewModelFactory.CreateOrderViewModel(_api, order));
                                break;
                            case OrderState.Open:
                            case OrderState.Closed:
                                Orders.Add(_viewModelFactory.CreateOrderViewModel(_api, order));
                                break;
                        }
                    }

                    foreach (var order in closedOrders.ClosedOrders.OrderByDescending(o => o.CloseTime))
                    {
                        History.Add(_viewModelFactory.CreateOrderViewModel(_api, order));
                    }
                });
            }
            catch (Exception ex)
            {

            }


            /*
            var symbol = _api.GetSymbol("EURUSD");
            var orderType = OrderType.Sell;
            var lots = 0.2;
            
            var fees = 0.0;
            var sellOrder = default(Order);
            var buyOrder = default(Order);
            var tradingData = _api.GetSymbolTradingData(symbol.Id);
//            await _api.RefreshPricesAsync();
            while (fees < 50.0)
            {
                try
                {
                    if (sellOrder == null)
                    {
                        sellOrder = await OpenOrderAsync(symbol.Id, OrderType.Sell, lots);
                        fees += (tradingData.LastFilteredTicks.Close.Ask - tradingData.LastFilteredTicks.Close.Bid) * sellOrder.Lots * symbol.ContractSize * sellOrder.ProfitConversionRate;
                        System.Diagnostics.Debug.WriteLine($"Total fees : {fees}");
                    }

                    if (buyOrder == null)
                    {
                        buyOrder = await OpenOrderAsync(symbol.Id, OrderType.Buy, lots);
                        fees += (tradingData.LastFilteredTicks.Close.Ask - tradingData.LastFilteredTicks.Close.Bid) * buyOrder.Lots * symbol.ContractSize * buyOrder.ProfitConversionRate;
                        System.Diagnostics.Debug.WriteLine($"Total fees : {fees}");
                    }

                    while (sellOrder != null && buyOrder != null && sellOrder.State != OrderState.Closed && buyOrder.State != OrderState.Closed)
                    {
                        await Task.Delay(50);
                        if (sellOrder != null) sellOrder = _api.GetOrder(symbol.Id, sellOrder.Id);
                        if (buyOrder != null) buyOrder = _api.GetOrder(symbol.Id, buyOrder.Id);
                    }
                }
                catch (Exception ex)
                {

                }
            }*/

        }

        private async void OnManualMarketTimer(object? sender, EventArgs e)
        {
            try
            {
                await _api.RefreshPricesAsync();

                foreach (var symbol in _manualMarketUpdate)
                {
                    var tradingData = _api.GetSymbolTradingData(symbol);
                    UpdateSymbolTick(tradingData.LastFilteredTicks.Close);
                }
            }
            catch (Exception ex)
            {
                // TODO...
            }
        }

        private void OnStateChanged(object sender, APIChannelStateChangedEventArgs e)
        {
        }

        private void OnOrderNotification(object sender, OrderNotificationEventArgs e)
        {
            _dispatcherService.Invoke(() =>
            {
                switch (e.Order.State)
                {
                    case OrderState.Pending:
                        if (!Positions.Any(o => o.Id == e.Order.Id))
                            Positions.Add(_viewModelFactory.CreateOrderViewModel(_api, e.Order));
                        break;
                    case OrderState.Open:
                        var existingPosition = Positions.SingleOrDefault(p => p.Id == e.Order.Id);
                        if (existingPosition != null)
                        {
                            Positions.Remove(existingPosition);
                        }
                        var existingOrder = Orders.SingleOrDefault(p => p.Id == e.Order.Id);
                        if (existingOrder != null)
                            existingOrder.Update(e.Order);
                        else
                            Orders.Add(_viewModelFactory.CreateOrderViewModel(_api, e.Order));

                        break;

                    case OrderState.Closed:
                    case OrderState.Deleted:
                    case OrderState.Canceled:
                        RemoveIfExists(e.Order, Positions);
                        RemoveIfExists(e.Order, Orders);
                        var historyPosition = History.SingleOrDefault(p => p.Id == e.Order.Id);
                        if (historyPosition != null)
                            historyPosition.Update(e.Order);
                        else
                            History.Insert(0, _viewModelFactory.CreateOrderViewModel(_api, e.Order));
                        break;

                    case OrderState.Rejected:
                        // TODO
                        break;
                }
            });
        }

        private void RemoveIfExists(Order order, ObservableCollection<OrderViewModel> collection)
        {
            var existingItem = collection.SingleOrDefault(c => c.Id == order.Id);
            if (existingItem != null)
                collection.Remove(existingItem);
        }

        private void OnMarketDataUpdate(object sender, MarketDataUpdateEventArgs e)
        {
            UpdateSymbolTick(e.Tick);
        }

        private void OnMarketDataEventNotification(object sender, MarketDataEventNotificationEventArgs e)
        {
        }

        private void OnClientMessageNotification(object sender, ClientMessageNotificationEventArgs e)
        {
        }

        private void UpdateSymbolTick(Tick tick)
        {
            var symbolViewModel = Symbols.FirstOrDefault(s => s.Id == tick.SymbolId);
            symbolViewModel?.UpdateTick(tick);
            foreach (var orderViewModel in Orders.Where(o => o.Symbol == tick.SymbolId))
            {
                orderViewModel.UpdateTick(tick);
            }
        }


        private const string _testSymbol = "AUDCAD";
        private const double _testLots = 0.2;
        private const double _gain = 0.00001;

        private async Task<Order> OpenOrderAsync(string symbol, OrderType orderType, double lots, double price = 0.0)
        {
            var order = await _api.OpenOrderAsync(new OrderRequest
            {
                Symbol = symbol,
                OrderType = orderType,
                Lots = lots,
                Price = price,
                AccountId = _api.GetAccount().Id
            });

            var takeProfit = order.OpenPrice + (orderType == OrderType.Buy ? 1 : -1) * _gain;
            
            order = await _api.ModifyOrderAsync(new OrderRequest
            {
                OrderId = order.Id,
                Symbol = symbol,
                OrderType = orderType,
                Lots = lots,
                Price = price,
                TakeProfit = takeProfit, // + (tradingData.LastFilteredTicks.Close.Ask - tradingData.LastFilteredTicks.Close.Bid) * (orderType.IsSellOrder() ? -1 : 1),
                AccountId = _api.GetAccount().Id
            });

            return order;
        }

        public ICommand SellCommand => new AsyncRelayCommand(OnSellAsync);

        private async Task OnSellAsync()
        {
            if (_api.IsConnected && Orders.Union(Positions).All(o => o.Symbol != _testSymbol || o.OrderType != OrderType.Sell))
            {
                await OpenOrderAsync(_testSymbol, OrderType.Sell, _testLots);
            }
        }

        public ICommand BuyCommand => new AsyncRelayCommand(OnBuyAsync);

        private async Task OnBuyAsync()
        {
            if (_api.IsConnected && Orders.Union(Positions).All(o => o.Symbol != _testSymbol || o.OrderType != OrderType.Buy))
            {
                await OpenOrderAsync(_testSymbol, OrderType.Buy, _testLots);
            }
        }
    }
}
