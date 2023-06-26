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

namespace WypozyczalniaGierProjekt.MVVM.View
{
    /// <summary>
    /// Logika interakcji dla klasy CollectionView.xaml
    /// </summary>
    public partial class CollectionView : UserControl
    {

        public static readonly DependencyProperty CurrentControlProperty =
        DependencyProperty.Register("CurrentControl", typeof(UserControl), typeof(CollectionView), new PropertyMetadata(null));

        public UserControl CurrentControl
        {
            get { return (UserControl)GetValue(CurrentControlProperty); }
            set { SetValue(CurrentControlProperty, value); }
        }
        public CollectionView()
        {
            InitializeComponent();
            CurrentControl = new WitcherView();
        }

        private void ButtonGoToB_Click(object sender, RoutedEventArgs e)
        {
            WitcherView witcherView = new WitcherView();
            navigationFrame.Content = witcherView;
        }
    }
}
