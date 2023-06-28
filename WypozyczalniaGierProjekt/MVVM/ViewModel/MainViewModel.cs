using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WypozyczalniaGierProjekt.Core;

namespace WypozyczalniaGierProjekt.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }
        public RelayCommand BagViewCommand { get; set; }
        public RelayCommand ConfirmViewCommand { get; set; }
        public RelayCommand CollectionViewCommand { get; set; }
        public RelayCommand UserViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public DiscoveryViewModel DiscoveryVM { get; set; }
        public BagViewModel BagVM { get; set; }
        public ConfirmViewModel ConfirmVM { get; set; }
        public CollectionViewModel CollectionVM { get; set; }
        public UserViewModel UserVM { get; set; }

        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            DiscoveryVM = new DiscoveryViewModel();
            BagVM = new BagViewModel();
            ConfirmVM = new ConfirmViewModel();
            CollectionVM = new CollectionViewModel();
            UserVM = new UserViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            DiscoveryViewCommand = new RelayCommand(o =>
            {
                CurrentView = DiscoveryVM;
            });

            BagViewCommand = new RelayCommand(o =>
            {
                CurrentView = BagVM;
            });

            ConfirmViewCommand = new RelayCommand(o =>
            {
                CurrentView = ConfirmVM;
            });

            CollectionViewCommand = new RelayCommand(o =>
            {
                CurrentView = CollectionVM;
            });

            UserViewCommand = new RelayCommand(o =>
            {
                CurrentView = UserVM;
            });
        }
    }
}
