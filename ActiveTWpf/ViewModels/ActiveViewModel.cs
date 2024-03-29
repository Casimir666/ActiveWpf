﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ActiveTWpf.Service;
using ActiveTWpf.ViewModels;
using ActivTrades.ActivTrader.API;
using ActivTrades.ActivTrader.API.Models;
using ActivTrades.ActivTrader.Connection.Models;
using ATPlatform.Model.Entities;
using ATPlatform.Model.Enums.Order;
using ATPlatform.Model.Proto;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.DependencyInjection;

namespace ActiveTWpf
{
    public class ActiveViewModel : ObservableObject
    {
        private readonly IActivTraderAPI _api;

        public ObservableCollection<SymbolViewModel> Symbols { get; }

        public ObservableCollection<OrderViewModel> Orders { get; }

        public ObservableCollection<OrderViewModel> Positions { get; }

        public ActiveViewModel(IActivTraderAPI api)
        {
            _api = api;

            Symbols = new ObservableCollection<SymbolViewModel>();
            Orders = new ObservableCollection<OrderViewModel>();
            Positions = new ObservableCollection<OrderViewModel>();
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
                var oo = calc.EstimateProfit("EURUSD", OrderType.Sell, 0.4, 4.7108, 4.0827, 4.9043);

                /*var newOrder = await _api.OpenOrderAsync(new OrderRequest
                {
                    Symbol = "AUDUSD",
                    OrderType = OrderType.Buy,
                    Lots = 0.05, 
                    AccountId = _api.GetAccount().Id
                });*/

                if (symbolNames != null)
                {
                    foreach (var symbol in symbolNames)
                    {
                        try
                        {
                            Application.Current.Dispatcher.Invoke(() => Symbols.Add(new SymbolViewModel(_api.GetSymbol(symbol))));
                            _api.Subscribe(symbol);
                        }
                        catch (Exception ex)
                        {
                            // Symbol not found!
                        }
                    }
                }

                foreach (var order in _api.GetOrders())
                {
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        switch (order.State)
                        {
                            case OrderState.Pending:
                                Positions.Add(new OrderViewModel(_api, order));
                                break;
                            case OrderState.Open:
                            case OrderState.Closed:
                                Orders.Add(new OrderViewModel(_api, order));
                                break;
                        }
                    });
                }
            }
            catch (Exception ex)
            {

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
                    Positions.Add(new OrderViewModel(_api, e.Order));
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
                    break;

                case OrderState.Rejected:
                    // TODO
                    break;
            }
        }

        private void OnMarketDataUpdate(object sender, MarketDataUpdateEventArgs e)
        {
            var symbolViewModel = Symbols.FirstOrDefault(s => s.Id == e.Tick.SymbolId);
            symbolViewModel?.UpdateTick(e.Tick);
            foreach (var orderViewModel in Orders.Where(o => o.Symbol == e.Tick.SymbolId))
            {
                orderViewModel.UpdateTick(e.Tick);
            }
        }

        private void OnMarketDataEventNotification(object sender, MarketDataEventNotificationEventArgs e)
        {
        }

        private void OnClientMessageNotification(object sender, ClientMessageNotificationEventArgs e)
        {
        }
    }
}
