using System.Windows.Controls;
using System.Windows;
using WypozyczalniaGierProjekt.MVVM.ViewModel;
using System.Windows.Media.Animation;
using System.Windows.Media;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Text;

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
            LoadAddedTitles();
            SumAddedTitles();
        }

        private void PotwierdzButton_Click(object sender, RoutedEventArgs e)
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

                string connectionString = "Server=(local)\\SQLEXPRESS; Database=MVVMLoginDb; Integrated Security=true";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO ShoppingForm (Imię, Nazwisko, Miejscowość, [Kod pocztowy], Ulica, [Numer mieszkania], Email, [Numer telefonu]) VALUES (@Imię, @Nazwisko, @Miejscowość, @KodPocztowy, @Ulica, @NumerMieszkania, @Email, @NumerTelefonu)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Imię", viewModel.Imie);
                        command.Parameters.AddWithValue("@Nazwisko", viewModel.Nazwisko);
                        command.Parameters.AddWithValue("@Miejscowość", viewModel.Miejscowosc);
                        command.Parameters.AddWithValue("@KodPocztowy", viewModel.KodPocztowy);
                        command.Parameters.AddWithValue("@Ulica", viewModel.Ulica);
                        command.Parameters.AddWithValue("@NumerMieszkania", viewModel.NumerMieszkania);
                        command.Parameters.AddWithValue("@Email", viewModel.Email);
                        command.Parameters.AddWithValue("@NumerTelefonu", viewModel.NumerTelefonu);

                        command.ExecuteNonQuery();
                    }
                }

                // Wyczyść pola formularza po dodaniu danych do bazy danych
                viewModel.Imie = string.Empty;
                viewModel.Nazwisko = string.Empty;
                viewModel.Miejscowosc = string.Empty;
                viewModel.KodPocztowy = string.Empty;
                viewModel.Ulica = string.Empty;
                viewModel.NumerMieszkania = string.Empty;
                viewModel.Email = string.Empty;
                viewModel.NumerTelefonu = string.Empty;

                // Wykonaj animację
                ThicknessAnimation animation = new ThicknessAnimation();
                animation.To = new Thickness(0, 900, 0, 0); // Przesunięcie o 300 pikseli w dół
                animation.Duration = TimeSpan.FromSeconds(2.5); // Czas trwania animacji

                CarImage.Visibility = Visibility.Visible;
                CarImage.BeginAnimation(Canvas.MarginProperty, animation);

                CarImage1.Visibility = Visibility.Visible;
                CarImage1.BeginAnimation(Canvas.MarginProperty, animation);

                CarImage2.Visibility = Visibility.Visible;
                CarImage2.BeginAnimation(Canvas.MarginProperty, animation);

                CarImage3.Visibility = Visibility.Visible;
                CarImage3.BeginAnimation(Canvas.MarginProperty, animation);

                CarImage4.Visibility = Visibility.Visible;
                CarImage4.BeginAnimation(Canvas.MarginProperty, animation);

                CarImage5.Visibility = Visibility.Visible;
                CarImage5.BeginAnimation(Canvas.MarginProperty, animation);

                CarImage6.Visibility = Visibility.Visible;
                CarImage6.BeginAnimation(Canvas.MarginProperty, animation);

                CarImage7.Visibility = Visibility.Visible;
                CarImage7.BeginAnimation(Canvas.MarginProperty, animation);

                ConfirmView userControl2 = new ConfirmView();
                MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
                mainWindow.Content = userControl2;

            }

        }
        private void LoadAddedTitles()
        {
            try
            {
                string connectionString = "Server=(local)\\SQLEXPRESS; Database=MVVMLoginDb; Integrated Security=true";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Tytuł FROM Koszyk";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    StringBuilder titlesBuilder = new StringBuilder();
                    while (reader.Read())
                    {
                        string title = reader.GetString(0);
                        titlesBuilder.AppendLine(title);
                    }

                    DodaneTytulyTextBlock.Text = titlesBuilder.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas wczytywania tytułów: " + ex.Message);
            }
        }

        private void SumAddedTitles()
        {
            decimal sumaCen = 0;
            try
            {
                string connectionString = "Server=(local)\\SQLEXPRESS; Database=MVVMLoginDb; Integrated Security=true";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Cena FROM Koszyk";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        decimal cena = reader.GetDecimal(0);
                        sumaCen += cena;
                    }

                    DodaneCenyTextBlock.Text = sumaCen.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas wczytywania cen: " + ex.Message);
            }
        }
    }
}