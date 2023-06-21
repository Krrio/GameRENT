using System.Windows.Controls;
using System.Windows;
using WypozyczalniaGierProjekt.MVVM.ViewModel;
using System.Windows.Media.Animation;
using System.Windows.Media;
using System;

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


                ThicknessAnimation animation = new ThicknessAnimation();
                animation.To = new Thickness(0, 900, 0, 0); // Przesunięcie o 300 pikseli w dół
                animation.Duration = TimeSpan.FromSeconds(1.5); // Czas trwania animacji

                CarImage.Visibility = Visibility.Visible;
                CarImage.BeginAnimation(Canvas.MarginProperty, animation);

                CarImage1.Visibility = Visibility.Visible;
                CarImage.BeginAnimation(Canvas.MarginProperty, animation);

                CarImage2.Visibility = Visibility.Visible;
                CarImage.BeginAnimation(Canvas.MarginProperty, animation);

                CarImage3.Visibility = Visibility.Visible;
                CarImage.BeginAnimation(Canvas.MarginProperty, animation);

                CarImage4.Visibility = Visibility.Visible;
                CarImage.BeginAnimation(Canvas.MarginProperty, animation);

                CarImage5.Visibility = Visibility.Visible;
                CarImage.BeginAnimation(Canvas.MarginProperty, animation);

                CarImage6.Visibility = Visibility.Visible;
                CarImage.BeginAnimation(Canvas.MarginProperty, animation);

                CarImage7.Visibility = Visibility.Visible;
                CarImage.BeginAnimation(Canvas.MarginProperty, animation);

                CarTranslation.BeginAnimation(TranslateTransform.XProperty, animation);

                //MessageBox.Show("Dane zostały potwierdzone.", "Sukces", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
