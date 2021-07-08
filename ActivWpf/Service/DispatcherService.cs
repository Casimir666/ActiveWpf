using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ActivWpf.Service
{
    interface IDispatcherService
    {
        void Invoke(Action action);
    }

    class DispatcherService : IDispatcherService
    {
        public void Invoke(Action action)
        {
            Application.Current?.Dispatcher?.Invoke(action);
        }
    }
}
