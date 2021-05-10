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
            img_DIN_1207.Visibility = Visibility.Hidden;
            img_DIN_4014.Visibility = Visibility.Hidden;
            img_DIN_4762.Visibility = Visibility.Hidden;
            Img_DIN_10642.Visibility = Visibility.Hidden;
        }

        


        private void tvi_sk_Selected(object sender, RoutedEventArgs e)
        {
            hideallimages();
            img_DIN_4014.Visibility = Visibility.Visible;
        }

        private void tvi_zy1_Selected(object sender, RoutedEventArgs e)
        {
            hideallimages();
            img_DIN_4762.Visibility = Visibility.Visible;
        }

        private void tvi_zy2_Selected(object sender, RoutedEventArgs e)
        {
            hideallimages();
            img_DIN_1207.Visibility = Visibility.Visible;
        }

        private void tvi_ss_Selected(object sender, RoutedEventArgs e)
        {
            hideallimages();
            Img_DIN_10642.Visibility = Visibility.Visible;


            // Visibility Gewinde
            cbx_m14.Visibility = Visibility.Hidden;
            cbx_m24.Visibility = Visibility.Hidden;
            cbx_m30.Visibility = Visibility.Hidden;
            cbx_m36.Visibility = Visibility.Hidden;


          
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }



        //Treeview Actions
    }
}
