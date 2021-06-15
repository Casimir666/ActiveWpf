using System.Windows;
using ATPlatform.Model.Entities;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace ActiveTWpf.ViewModels
{
    public class SymbolViewModel : ObservableObject
    {
        private readonly Symbol _symbol;
        private Tick _lastTick;

        public string Id => _symbol.Id;
        public string Description => _symbol.Description;
        public double? Bid => _lastTick?.Bid;
        public double? Ask => _lastTick?.Ask;

        public SymbolViewModel(Symbol symbol)
        {
            _symbol = symbol;
        }

        public void UpdateTick(Tick tick)
        {
            _lastTick = tick;
            Application.Current.Dispatcher.Invoke(() =>
            {
                OnPropertyChanged(nameof(Bid));
                OnPropertyChanged(nameof(Ask));
            });
        }
    }
}
