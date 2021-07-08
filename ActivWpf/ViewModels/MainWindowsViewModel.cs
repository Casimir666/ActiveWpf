namespace ActivWpf.ViewModels
{
    class MainWindowsViewModel
    {
        public ActiveViewModel ActiveViewModel { get; }

        public MainWindowsViewModel(ActiveViewModel activeViewModel)
        {
            ActiveViewModel = activeViewModel;
        }
    }
}
