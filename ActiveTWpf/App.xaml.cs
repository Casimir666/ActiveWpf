using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ActiveTWpf.Properties;
using ActiveTWpf.Service;
using ActiveTWpf.ViewModels;
using ActivTrades.ActivTrader.API;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Toolkit.Mvvm.DependencyInjection;

namespace ActiveTWpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            ConfigureServices();
            Task.Run(StartAsync);
        }

        private async Task StartAsync()
        {
            await Ioc.Default.GetService<ActiveViewModel>()?.ConnectAsync(Settings.Default.Symbols?.Cast<string>()?.ToList());
        }

        private void ConfigureServices()
        {
            Ioc.Default.ConfigureServices(new ServiceCollection()
                .AddSingleton<IActivTraderAPI>(new ActivTraderAPI("https://activtrader.activtrades.com", "casimir666@free.fr", "0T~C2?a,!YoKP\"Wm*`!l", 10645858))
                .AddSingleton<ActiveViewModel>()
                .AddSingleton<MainWindowsViewModel>()
                .AddSingleton<Calculator>()
                .BuildServiceProvider());
        }
    }
}
