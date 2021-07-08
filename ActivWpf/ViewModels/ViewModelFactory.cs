using ActivTrades.ActivTrader.API;
using ActivWpf.Service;
using ATPlatform.Model.Entities;

namespace ActivWpf.ViewModels
{
    class ViewModelFactory
    {
        private readonly IDispatcherService _dispatcherService;

        public ViewModelFactory(IDispatcherService dispatcherService)
        {
            _dispatcherService = dispatcherService;
        }

        public OrderViewModel CreateOrderViewModel(IActivTraderAPI api, Order order)
            => new OrderViewModel(_dispatcherService, api, order);

        public SymbolViewModel CreateSymbolViewModel(Symbol symbol)
            => new SymbolViewModel(_dispatcherService, symbol);
    }
}