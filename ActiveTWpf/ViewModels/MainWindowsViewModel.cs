using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveTWpf.ViewModels
{
    public class MainWindowsViewModel
    {
        public ActiveViewModel ActiveViewModel { get; }

        public MainWindowsViewModel(ActiveViewModel activeViewModel)
        {
            ActiveViewModel = activeViewModel;
        }
    }
}
