using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ActivTrades.ActivTrader.API;
using ActivWpf.Service;
using ActivWpf.Utils;
using ActivWpf.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Toolkit.Mvvm.DependencyInjection;

namespace ActivWpf
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
                .AddSingleton<IActivTraderAPI>(CreateActivTradeClient())
                .AddSingleton<ActiveViewModel>()
                .AddSingleton<MainWindowsViewModel>()
                .AddSingleton<Calculator>()
                .BuildServiceProvider());
        }

        private ActivTraderAPI CreateActivTradeClient(bool demo = true)
        {
            var apiKeyFilename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), $"ActiveT_{(demo ? "demo" : "real")}.conf");

            if (File.Exists(apiKeyFilename))
            {
                var strings = CryptoUtility.LoadProtectedStringsFromFile(apiKeyFilename);
                if (strings.Length < 4)
                {
                    throw new InvalidOperationException(
                        "Encrypted keys file should have at least a public and private key, and an optional pass phrase"
                    );
                }

                return new ActivTraderAPI(
                    strings[0].ToUnsecureString(),
                    strings[1].ToUnsecureString(),
                    strings[2].ToUnsecureString(),
                    int.Parse(strings[3].ToUnsecureString()));
            }

            throw new InvalidOperationException("Credentials file not found");
        }
    }
}
