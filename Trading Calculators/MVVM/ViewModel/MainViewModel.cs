using System;
using Trading_Calculators.Core;

namespace Trading_Calculators.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand RiskViewCommand { get; set; }
        public RelayCommand PositionSizeViewCommand { get; set; }

        public HomeViewModel HomeVm { get; set; }
        public RiskViewModel RiskVm { get; set; }
        public PositionSizeViewModel PositionSizeVm { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value;
                OnPropertyChanged();
            }
        }


        public MainViewModel()
        {
            HomeVm = new HomeViewModel();
            RiskVm = new RiskViewModel();
            PositionSizeVm = new PositionSizeViewModel();

            CurrentView = HomeVm;
            HomeViewCommand = new RelayCommand(o =>
                {
                    CurrentView = HomeVm;
            });
            RiskViewCommand = new RelayCommand(o =>
            {
                CurrentView = RiskVm;
            });
            PositionSizeViewCommand = new RelayCommand(o =>
            {
                CurrentView = PositionSizeVm;
            });
        }
    }
}
