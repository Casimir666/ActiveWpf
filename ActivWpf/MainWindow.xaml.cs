using System.Windows;
using ActivWpf.ViewModels;
using Microsoft.Toolkit.Mvvm.DependencyInjection;

namespace ActivWpf
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
