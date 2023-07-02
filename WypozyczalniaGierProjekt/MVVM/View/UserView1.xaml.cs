using System;
using System.Collections.Generic;
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
using System.Data.SqlClient;


namespace WypozyczalniaGierProjekt.MVVM.View
{
    public class DatabaseManager
    {
        private string connectionString = "Server=(local)\\SQLEXPRESS; Database=MVVMLoginDb; Integrated Security=true";

        public void InsertData(string id, string imie, string nazwisko, string numerTelefonu, string adres, int iloscWypozyczonychGier, int iloscKupionychGier, int twojePunkty)
        {
            string insertDataQuery = "INSERT INTO DaneKlienta (ID, Imie, Nazwisko, NumerTelefonu, Adres, IloscWypozyczonychGier, IloscKupionychGier, TwojePunkty) VALUES (@ID, @Imie, @Nazwisko, @NumerTelefonu, @Adres, @IloscWypozyczonychGier, @IloscKupionychGier, @TwojePunkty)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(insertDataQuery, connection);
                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@Imie", imie);
                command.Parameters.AddWithValue("@Nazwisko", nazwisko);
                command.Parameters.AddWithValue("@NumerTelefonu", numerTelefonu);
                command.Parameters.AddWithValue("@Adres", adres);
                command.Parameters.AddWithValue("@IloscWypozyczonychGier", iloscWypozyczonychGier);
                command.Parameters.AddWithValue("@IloscKupionychGier", iloscKupionychGier);
                command.Parameters.AddWithValue("@TwojePunkty", twojePunkty);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}