using System.ComponentModel;
using System.Windows.Input;
using WypozyczalniaGierProjekt.MVVM.ViewModel;

namespace WypozyczalniaGierProjekt.MVVM.ViewModel
{
    internal class BagViewModel : INotifyPropertyChanged
    {
        private string imie;
        public string Imie
        {
            get { return imie; }
            set
            {
                if (imie != value)
                {
                    imie = value;
                    OnPropertyChanged(nameof(Imie));
                }
            }
        }

        private string nazwisko;
        public string Nazwisko
        {
            get { return nazwisko; }
            set
            {
                if (nazwisko != value)
                {
                    nazwisko = value;
                    OnPropertyChanged(nameof(Nazwisko));
                }
            }
        }

        private string miejscowosc;
        public string Miejscowosc
        {
            get { return miejscowosc; }
            set
            {
                if (miejscowosc != value)
                {
                    miejscowosc = value;
                    OnPropertyChanged(nameof(Miejscowosc));
                }
            }
        }

        private string kodPocztowy;
        public string KodPocztowy
        {
            get { return kodPocztowy; }
            set
            {
                if (kodPocztowy != value)
                {
                    kodPocztowy = value;
                    OnPropertyChanged(nameof(KodPocztowy));
                }
            }
        }

        private string ulica;
        public string Ulica
        {
            get { return ulica; }
            set
            {
                if (ulica != value)
                {
                    ulica = value;
                    OnPropertyChanged(nameof(Ulica));
                }
            }
        }

        private string numerMieszkania;
        public string NumerMieszkania
        {
            get { return numerMieszkania; }
            set
            {
                if (numerMieszkania != value)
                {
                    numerMieszkania = value;
                    OnPropertyChanged(nameof(NumerMieszkania));
                }
            }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                if (email != value)
                {
                    email = value;
                    OnPropertyChanged(nameof(Email));
                }
            }
        }

        private string numerTelefonu;
        public string NumerTelefonu
        {
            get { return numerTelefonu; }
            set
            {
                if (numerTelefonu != value)
                {
                    numerTelefonu = value;
                    OnPropertyChanged(nameof(NumerTelefonu));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ViewModelCommand confirmViewCommand;

    }
}
