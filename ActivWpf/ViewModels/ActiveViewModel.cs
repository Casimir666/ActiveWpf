using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using ActivTrades.ActivTrader.API;
using ActivTrades.ActivTrader.API.Models;
using ActivTrades.ActivTrader.Connection.Models;
using ActivWpf.Service;
using ATPlatform.Model.Entities;
using ATPlatform.Model.Enums.Order;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.DependencyInjection;

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
                var calc = Ioc.Default.GetService<Calculator>();

                /*var newOrder = await _api.OpenOrderAsync(new OrderRequest
                {
                    Symbol = "AUDUSD",
                    OrderType = OrderType.BuyLimit,
                    Price = 0.7,
                    Lots = 0.05, 
                    AccountId = _api.GetAccount().Id
                });*/

                if (symbolNames != null)
                {
                    foreach (var symbol in symbolNames)
                    {
                        try
                        {
                            Application.Current.Dispatcher.Invoke(() => Symbols.Add(_viewModelFactory.CreateSymbolViewModel(_api.GetSymbol(symbol))));
                            _api.Subscribe(symbol);
                        }
                        catch (Exception ex)
                        {
                            // Symbol not found!
                            _manualMarketUpdate.Add(symbol);
                        }
                    }
                }
                _manualMarketTimer.Start();

                foreach (var order in _api.GetOrders())
                {
                    Application.Current.Dispatcher.Invoke(() =>
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
                    });
                }
            }
            catch (Exception ex)
            {

            }
        }

        private async void OnManualMarketTimer(object? sender, EventArgs e)
        {
            await _api.RefreshPricesAsync();

            foreach (var symbol in _manualMarketUpdate)
            {
                var tradingData = _api.GetSymbolTradingData(symbol);
                UpdateSymbolTick(tradingData.LastFilteredTicks.Close);
            }
        }

        private void OnStateChanged(object sender, APIChannelStateChangedEventArgs e)
        {
        }

        private void OnOrderNotification(object sender, OrderNotificationEventArgs e)
        {
            switch (e.Order.State)
            {
                case OrderState.Pending:
                    Positions.Add(_viewModelFactory.CreateOrderViewModel(_api, e.Order));
                    break;
                case OrderState.Open:
                    var existingPosition = Positions.SingleOrDefault(p => p.Id == e.Order.Id);
                    if (existingPosition != null)
                    {
                        Positions.Remove(existingPosition);
                    }
                    else
                    {
                        var existingOrder = Orders.SingleOrDefault(p => p.Id == e.Order.Id);
                        if (existingOrder != null)
                        {
                            existingOrder.Update(e.Order);
                        }
                    }

                    break;

                case OrderState.Closed:
                case OrderState.Deleted:
                case OrderState.Canceled:
                    _dispatcherService.Invoke(() =>
                    {
                        RemoveIfExists(e.Order, Positions);
                        RemoveIfExists(e.Order, Orders);
                    });
                    break;

                case OrderState.Rejected:
                    // TODO
                    break;
            }
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
    }
}
