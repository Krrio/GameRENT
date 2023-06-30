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

    }
}
