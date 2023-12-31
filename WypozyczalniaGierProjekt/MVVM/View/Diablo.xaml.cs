﻿using System;
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
    /// Logika interakcji dla klasy Diablo.xaml
    /// </summary>
    public partial class Diablo : UserControl
    {
        private decimal totalPrice = 0;

        private int availableQuantity = 192;
        public Diablo()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Window.GetWindow(this).Close();
        }
        private void AddToCartButton_Click(object sender, RoutedEventArgs e)
        {
            totalPrice += 299.99m;

            totalPriceTextBlock.Text = "Suma Twojego koszyka: " + totalPrice.ToString();

            int quantity = 1;

            if (availableQuantity > 0)
            {
                availableQuantity -= quantity;
                AvailableQuantityTextBlock.Text = "Ilość sztuk dostępnych do kupienia: " + availableQuantity.ToString();
            }
            else
            {
                MessageBox.Show("Brak dostępnego produktu");
            }

            // Pobierz dane gry, które chcesz dodać do bazy danych
            string tytul = "Diablo IV";
            decimal cena = 349.99m;
            DateTime dataKupienia = DateTime.Now;

            // Połącz z bazą danych
            string connectionString = "Server=(local)\\SQLEXPRESS; Database=MVVMLoginDb; Integrated Security=true";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Wstaw dane do tabeli Koszyk
                string query = "INSERT INTO Koszyk (Tytuł, Cena, DataKupienia) VALUES (@Tytuł, @Cena, @DataKupienia)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Tytuł", tytul);
                command.Parameters.AddWithValue("@Cena", cena);
                command.Parameters.AddWithValue("@DataKupienia", dataKupienia);
                command.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}
