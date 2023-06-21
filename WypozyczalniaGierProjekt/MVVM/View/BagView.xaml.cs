using System.Windows.Controls;
using System.Windows;
using WypozyczalniaGierProjekt.MVVM.ViewModel;

namespace WypozyczalniaGierProjekt.MVVM.View
{
    public partial class BagView : UserControl
    {
        private BagViewModel viewModel;

        public BagView()
        {
            InitializeComponent();
            viewModel = new BagViewModel();
            DataContext = viewModel;
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            // Sprawdzanie wypełnienia pól przed potwierdzeniem
            if (string.IsNullOrWhiteSpace(viewModel.Imie) ||
                string.IsNullOrWhiteSpace(viewModel.Nazwisko) ||
                string.IsNullOrWhiteSpace(viewModel.Miejscowosc) ||
                string.IsNullOrWhiteSpace(viewModel.KodPocztowy) ||
                string.IsNullOrWhiteSpace(viewModel.Ulica) ||
                string.IsNullOrWhiteSpace(viewModel.NumerMieszkania) ||
                string.IsNullOrWhiteSpace(viewModel.Email) ||
                string.IsNullOrWhiteSpace(viewModel.NumerTelefonu))
            {
                ErrorTextBlock.Text = "Wypełnij wszystkie pola przed potwierdzeniem.";
                ErrorTextBlock.Visibility = Visibility.Visible;
            }
            else
            {
                ErrorTextBlock.Visibility = Visibility.Collapsed;

                // Wykonaj operacje po potwierdzeniu
                // ...
                MessageBox.Show("Dane zostały potwierdzone.", "Sukces", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
