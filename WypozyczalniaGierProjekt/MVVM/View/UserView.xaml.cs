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
    /// Logika interakcji dla klasy UserView.xaml
    /// </summary>
    public partial class UserView : UserControl
    {
        public UserView()
        {
            InitializeComponent();

            // Pobierz dane z bazy danych
            string connectionString = "Server=(local)\\SQLEXPRESS; Database=MVVMLoginDb; Integrated Security=true";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                string query = "SELECT Imię, Nazwisko, Adres, Telefon, Email FROM StalyKlient";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", 1); // Przykładowe ID klienta do pobrania

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // Wyświetl pobrane dane w kontrolce
                    ImieTextBox.Text = reader["Imię"].ToString();
                    NazwiskoTextBox.Text = reader["Nazwisko"].ToString();
                    AdresTextBox.Text = reader["Adres"].ToString();
                    TelefonTextBox.Text = reader["Telefon"].ToString();
                    EmailTextBox.Text = reader["Email"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // Obsłuż błąd
            }
            finally
            {
                connection.Close();
            }
        }
    }
}