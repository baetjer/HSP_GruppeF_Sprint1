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

namespace wpf_probe
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cbx_gew_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        // Treeview Actions 
        private void hideallimages()
        {

        }

        


        private void tvi_sk_Selected(object sender, RoutedEventArgs e)
        {
            hideallimages();
        }

        private void tvi_zy1_Selected(object sender, RoutedEventArgs e)
        {
            hideallimages();
        }

        private void tvi_zy2_Selected(object sender, RoutedEventArgs e)
        {
            hideallimages();
        }

        private void tvi_ss_Selected(object sender, RoutedEventArgs e)
        {
            hideallimages();
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }



        //Treeview Actions
    }
}
