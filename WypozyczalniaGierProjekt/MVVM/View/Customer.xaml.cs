using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WypozyczalniaGierProjekt.MVVM.View
{
    /// <summary>
    /// Logika interakcji dla klasy Customer.xaml
    /// </summary>
    public partial class Customer : UserControl
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Button_Click(object sender, RoutedEventArgs e)
        {
            if (AreAllFieldsFilled())
            {
                string connectionString = "Server=(local)\\SQLEXPRESS; Database=MVVMLoginDb; Integrated Security=true";
                SqlConnection connection = new SqlConnection(connectionString);

                try
                {
                    connection.Open();

                    string imie = ImieTextBox.Text;
                    string nazwisko = NazwiskoTextBox.Text;
                    string adres = AdresTextBox.Text;
                    string telefon = TelefonTextBox.Text;
                    string email = EmailTextBox.Text;

                    string query = "INSERT INTO StalyKlient (Imię, Nazwisko, Adres, Telefon, Email) " +
                                   "VALUES (@Imie, @Nazwisko, @Adres, @Telefon, @Email)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Imie", imie);
                    command.Parameters.AddWithValue("@Nazwisko", nazwisko);
                    command.Parameters.AddWithValue("@Adres", adres);
                    command.Parameters.AddWithValue("@Telefon", telefon);
                    command.Parameters.AddWithValue("@Email", email);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Witamy w klubie Stałych Klientów.");

                    // Ustaw pola jako nieedytowalne
                    ImieTextBox.IsReadOnly = true;
                    NazwiskoTextBox.IsReadOnly = true;
                    AdresTextBox.IsReadOnly = true;
                    TelefonTextBox.IsReadOnly = true;
                    EmailTextBox.IsReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd podczas zapisywania danych: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Proszę wypełnić wszystkie pola formularza.");
            }
        }


        private bool AreAllFieldsFilled()
        {
            return !string.IsNullOrEmpty(ImieTextBox.Text) &&
                   !string.IsNullOrEmpty(NazwiskoTextBox.Text) &&
                   !string.IsNullOrEmpty(AdresTextBox.Text) &&
                   !string.IsNullOrEmpty(TelefonTextBox.Text) &&
                   !string.IsNullOrEmpty(EmailTextBox.Text);
        }


    }
}
