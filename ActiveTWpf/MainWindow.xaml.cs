using System.Windows;
using ActiveTWpf.ViewModels;
using Microsoft.Toolkit.Mvvm.DependencyInjection;

namespace ActiveTWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = Ioc.Default.GetService<MainWindowsViewModel>();
        }
    }
}
