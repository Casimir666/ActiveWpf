using System.Windows;
using ActivWpf.Service;
using ATPlatform.Model.Entities;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace ActivWpf.ViewModels
{
    class SymbolViewModel : ObservableObject
    {
        private readonly IDispatcherService _dispatcherService;
        private readonly Symbol _symbol;
        private Tick _lastTick;

        public string Id => _symbol.Id;
        public string Description => _symbol.Description;
        public double? Bid => _lastTick?.Bid;
        public double? Ask => _lastTick?.Ask;

        public SymbolViewModel(IDispatcherService dispatcherService, Symbol symbol)
        {
            _dispatcherService = dispatcherService;
            _symbol = symbol;
        }

        public void UpdateTick(Tick tick)
        {
            _lastTick = tick;
            _dispatcherService.Invoke(() =>
            {
                OnPropertyChanged(nameof(Bid));
                OnPropertyChanged(nameof(Ask));
            });
        }
    }
}
