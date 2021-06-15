using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ActivTrades.ActivTrader.API;
using ATPlatform.Model.Entities;
using ATPlatform.Model.Enums.Order;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace ActiveTWpf.ViewModels
{
    public class OrderViewModel : ObservableObject
    {
        private readonly IActivTraderAPI _api;
        private readonly Symbol _symbol;
        private Order _order;
        private Tick _lastTick;

        public long Id => _order.Id;
        public string Symbol => _order.Symbol;
        public double? OpenPrice => _order?.OpenPrice;
        public double? StopLoss => _order?.StopLoss;
        public double? TakeProfit => _order?.TakeProfit;
        public double? Lots => _order.Lots;

        public double? Profit
        {
            get
            {
                if ((_lastTick != null) && (_order.State == OrderState.Open || _order.State == OrderState.Closed))
                {
                    switch (_order.OrderType)
                    {
                        case OrderType.Buy:
                        case OrderType.BuyLimit:
                        case OrderType.BuyStop:
                            return (_lastTick.Bid - _order.OpenPrice) * _order.Lots * _symbol.ContractSize * _order.ProfitConversionRate;
                        case OrderType.Sell:
                        case OrderType.SellLimit:
                        case OrderType.SellStop:
                            return (_order.OpenPrice - _lastTick.Ask) * _order.Lots * _symbol.ContractSize * _order.ProfitConversionRate;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }

                return null;
            }
        }

        public ICommand CancelCommand => new AsyncRelayCommand(OnCancelAsync);
        public ICommand PartialCloseCommand => new AsyncRelayCommand(OnPartialCloseAsync);

        private async Task OnCancelAsync()
        {
            await CancelAsync();
        }

        private async Task OnPartialCloseAsync()
        {
            try
            {
                await PartialClose(_order.Lots / 100);
            }
            catch (Exception ex)
            {

            }
        }

        public OrderViewModel(IActivTraderAPI api, Order order)
        {
            _api = api;
            _order = order;
            _symbol = api.GetSymbol(order.Symbol);
        }

        public void UpdateTick(Tick tick)
        {
            _lastTick = tick;
            Application.Current.Dispatcher.Invoke(() =>
            {
                OnPropertyChanged(nameof(Profit));
            });
        }

        public async Task<Order> CancelAsync()
        {
            return await _api.CancelPendingOrderAsync(new OrderRequest { AccountId = _order.AccountId, OrderId = _order.Id });
        }

        public async Task PartialClose(double lots)
        {
            await _api.PartialCloseMarketOrderAsync(new OrderRequest
            {
                Symbol = _order.Symbol, 
                AccountId = _order.AccountId, 
                OrderId = _order.Id,
                Lots = 0.01
            });

            //await _api.CloseMarketOrderAsync (new OrderRequest { Symbol = _order.Symbol, AccountId = _order.AccountId, OrderId = _order.Id} );
        }

        public void Update(Order order)
        {
            _order = order;
            OnPropertyChanged(nameof(StopLoss));
            OnPropertyChanged(nameof(TakeProfit));
            OnPropertyChanged(nameof(Lots));
        }
    }
}
