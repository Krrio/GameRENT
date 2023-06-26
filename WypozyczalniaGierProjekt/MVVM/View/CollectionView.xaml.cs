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

        public static readonly DependencyProperty ChildControlProperty =
        DependencyProperty.Register("ChildControl", typeof(UserControl), typeof(CollectionView), new PropertyMetadata(null));

        public UserControl ChildControl
        {
            get { return (UserControl)GetValue(ChildControlProperty);}
            set { SetValue(ChildControlProperty, value); }
        }

        public CollectionView()
        {
            InitializeComponent();
        }

        private void ButtonGoToB_Click(object sender, RoutedEventArgs e)
        {
            ChildControl = new WitcherView();
        }
    }
}
