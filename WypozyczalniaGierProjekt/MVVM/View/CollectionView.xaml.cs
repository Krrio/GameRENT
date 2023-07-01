using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
    /// Logika interakcji dla klasy CollectionView.xaml
    /// </summary>
    public partial class CollectionView : UserControl
    {
        public CollectionView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Witcher userControl2 = new Witcher();
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.Content = userControl2;
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            TheLastOfUs userControl2 = new TheLastOfUs();
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.Content = userControl2;
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Cyberpunk userControl2 = new Cyberpunk();
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.Content = userControl2;
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            Hogwarts userControl2 = new Hogwarts();
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.Content = userControl2;
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            Jedi userControl2 = new Jedi();
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.Content = userControl2;
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            rdr2 userControl2 = new rdr2();
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.Content = userControl2;
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            gow userControl2 = new gow();
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.Content = userControl2;
        }

        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            EldenRing userControl2 = new EldenRing();
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.Content = userControl2;
        }

        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            Stray userControl2 = new Stray();
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.Content = userControl2;
        }

        private void Button_Click9(object sender, RoutedEventArgs e)
        {
            Subnautica userControl2 = new Subnautica();
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.Content = userControl2;
        }

        private void Button_Click10(object sender, RoutedEventArgs e)
        {
            Diablo userControl2 = new Diablo();
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.Content = userControl2;
        }

        private void Button_Click11(object sender, RoutedEventArgs e)
        {
            Spiderman userControl2 = new Spiderman();
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.Content = userControl2;
        }

        private void Button_Click12(object sender, RoutedEventArgs e)
        {
            Fable userControl2 = new Fable();
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.Content = userControl2;
        }

        private void Button_Click13(object sender, RoutedEventArgs e)
        {
            KatanaZero userControl2 = new KatanaZero();
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.Content = userControl2;
        }

        private void Button_Click14(object sender, RoutedEventArgs e)
        {
            Knight userControl2 = new Knight();
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.Content = userControl2;
        }

        private void Button_Click15(object sender, RoutedEventArgs e)
        {
            som userControl2 = new som();
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.Content = userControl2;
        }

    }
}
