﻿using System;
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
    /// Logika interakcji dla klasy WitcherView.xaml
    /// </summary>
    public partial class WitcherView : UserControl
    {
        public WitcherView()
        {
            InitializeComponent();
        }

        private void ButtonGoToA_Click(object sender, RoutedEventArgs e)
        {
            CollectionView collectionView = new CollectionView();
        }
    }
}
