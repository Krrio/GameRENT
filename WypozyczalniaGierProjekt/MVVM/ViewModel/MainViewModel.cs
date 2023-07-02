using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using WypozyczalniaGierProjekt.Core;

namespace WypozyczalniaGierProjekt.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        /// <summary>
        /// Used to bind commands related to navigation in the application.
        /// Each command is represented by an object of type RelayCommand and is assigned to a specific view.
        /// </summary>

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }
        public RelayCommand BagViewCommand { get; set; }
        public RelayCommand ConfirmViewCommand { get; set; }
        public RelayCommand CollectionViewCommand { get; set; }
        public RelayCommand UserViewCommand { get; set; }

        /// <summary>
        /// Each of the views is an instance of the corresponding ViewModel class, which is responsible for the logic and state of that particular view.
        /// </summary>

        public HomeViewModel HomeVM { get; set; }
        public DiscoveryViewModel DiscoveryVM { get; set; }
        public BagViewModel BagVM { get; set; }
        public ConfirmViewModel ConfirmVM { get; set; }
        public CollectionViewModel CollectionVM { get; set; }
        public UserViewModel UserVM { get; set; }

        /// <summary>
        /// The CurrentView property stores the currently displayed view. When the value of this property changes, the OnPropertyChanged method is called, which notifies the view about the value change and performs the necessary update of the user interface.
        /// </summary>

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

            /// <summary>
            /// The constructor of the MainViewModel class initializes all the views and assigns the default view to the CurrentView property. It also creates instances of the RelayCommand objects.
            /// </summary>

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
