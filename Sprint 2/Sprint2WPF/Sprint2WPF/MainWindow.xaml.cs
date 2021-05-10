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

namespace Sprint2WPF
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int sheet_sk = 1;
        int sheet_l = 5;
        int sheet_fst = 6;
        int sheet_stz = 7;

        int zeile_gw = 3;
        int zeile_l = 3;
        int zeile_stz = 3;
        int zeile_fst = 3;

        ExcelControl excelControl = new ExcelControl();

        public MainWindow()
        {
            InitializeComponent();
        }


        private void cbx_gew_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbx_gew.SelectedItem != null)
            {
                bool parseOK = Int32.TryParse(cbx_gew.SelectedValue.ToString(), out zeile_gw);
            }
            else
            { //Value is null 
            }

            //bool parseOK = Int32.TryParse(cbx_gew.SelectedValue.ToString(), out zeile);
        }

        private void cbx_laenge_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbx_laenge.SelectedItem != null)
            {
                bool parseOK = Int32.TryParse(cbx_laenge.SelectedValue.ToString(), out zeile_l);
            }
            else
            { //Value is null 
            }
        }

        private void cbx_stkz_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbx_stkz.SelectedItem != null)
            {
                bool parseOK = Int32.TryParse(cbx_stkz.SelectedValue.ToString(), out zeile_stz);
            }
            else
            { //Value is null 
            }
        }

        // Treeview Actions 
        public void hideallimages()
        {
            img_DIN_1207.Visibility = Visibility.Hidden;
            img_DIN_4014.Visibility = Visibility.Hidden;
            img_DIN_4762.Visibility = Visibility.Hidden;
            Img_DIN_10642.Visibility = Visibility.Hidden;
        }



        //Gewinde Actions
        private void showallgewinde()
        {
            cbx_m3.Visibility = Visibility.Visible;
            cbx_m4.Visibility = Visibility.Visible;
            cbx_m5.Visibility = Visibility.Visible;
            cbx_m6.Visibility = Visibility.Visible;
            cbx_m8.Visibility = Visibility.Visible;
            cbx_m10.Visibility = Visibility.Visible;
            cbx_m12.Visibility = Visibility.Visible;
            cbx_m14.Visibility = Visibility.Visible;
            cbx_m16.Visibility = Visibility.Visible;
            cbx_m20.Visibility = Visibility.Visible;
            cbx_m24.Visibility = Visibility.Visible;
            cbx_m30.Visibility = Visibility.Visible;
            cbx_m36.Visibility = Visibility.Visible;
        }


        private void tvi_sk_Selected(object sender, RoutedEventArgs e)
        {
            //Visibility Image
            hideallimages();
            img_DIN_4014.Visibility = Visibility.Visible;


            //Visibility Gewinde
            showallgewinde();
            cbx_m14.Visibility = Visibility.Hidden;

            //excel-Zugriff
            sheet_sk = 1;
        }

        private void tvi_zy1_Selected(object sender, RoutedEventArgs e)
        {
            //Visibility Image
            hideallimages();
            img_DIN_4762.Visibility = Visibility.Visible;

            //visibility Gewinde
            showallgewinde();
            cbx_m14.Visibility = Visibility.Hidden;

            //excel-Zugriff
            sheet_sk = 2;
        }

        private void tvi_zy2_Selected(object sender, RoutedEventArgs e)
        {
            //Visibility Image
            hideallimages();
            img_DIN_1207.Visibility = Visibility.Visible;


            // Visibility Gewinde
            showallgewinde();
            cbx_m12.Visibility = Visibility.Hidden;
            cbx_m14.Visibility = Visibility.Hidden;
            cbx_m16.Visibility = Visibility.Hidden;
            cbx_m20.Visibility = Visibility.Hidden;
            cbx_m24.Visibility = Visibility.Hidden;
            cbx_m30.Visibility = Visibility.Hidden;
            cbx_m36.Visibility = Visibility.Hidden;

            //excel-Zugriff
            sheet_sk = 4;
        }

        private void tvi_ss_Selected(object sender, RoutedEventArgs e)
        {
            //Visibility Image
            hideallimages();
            Img_DIN_10642.Visibility = Visibility.Visible;


            // Visibility Gewinde

            showallgewinde();
            cbx_m14.Visibility = Visibility.Hidden;
            cbx_m24.Visibility = Visibility.Hidden;
            cbx_m30.Visibility = Visibility.Hidden;
            cbx_m36.Visibility = Visibility.Hidden;

            //excel-Zugriff
            sheet_sk = 3;
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        public void getFestigkeit()
        {
            if (rb_5_8.IsChecked == true)
            {
                festigkeit_ausgabe.Content = "5.8";
                List<double> erg = excelControl.getWerte(6, 2);
                zugfestigkeit_ausgabe.Content = erg[0];
                streckgrenze_ausgabe.Content = erg[1];
            }
            else if (rb_8_8.IsChecked == true)
            {
                festigkeit_ausgabe.Content = "8.8";
                List<double> erg = excelControl.getWerte(6, 3);
                zugfestigkeit_ausgabe.Content = erg[0];
                streckgrenze_ausgabe.Content = erg[1];
            }
            else if (rb_9_8.IsChecked == true)
            {
                festigkeit_ausgabe.Content = "9.8";
                List<double> erg = excelControl.getWerte(6, 4);
                zugfestigkeit_ausgabe.Content = erg[0];
                streckgrenze_ausgabe.Content = erg[1];
            }
            else if (rb_10_9.IsChecked == true)
            {
                festigkeit_ausgabe.Content = "10.9";
                List<double> erg = excelControl.getWerte(6, 5);
                zugfestigkeit_ausgabe.Content = erg[0];
                streckgrenze_ausgabe.Content = erg[1];
            }
        }

        public void getSchraube()
        {
            
            if (tvi_sk.IsSelected == true)
            {
                sk_ausgabe.Content = "Sechskant DIN 4014";
            }
            else if (tvi_zy1.IsSelected == true)
            {
                sk_ausgabe.Content = "Zylinderschraube DIN 4762";
            }
            else if (tvi_zy2.IsSelected == true)
            {
                sk_ausgabe.Content = "Zylinderschraube DIN 1207";
            }
            else if (tvi_ss.IsSelected == true)
            {
                sk_ausgabe.Content = "Senkschraube DIN 10642";
            }
        }

        public void getGewinde()
        {
            if (cbx_gew.SelectedItem != null)
            {
                bool parseOK = Int32.TryParse(cbx_gew.SelectedValue.ToString(), out zeile_gw);
                
                if (tvi_sk.IsSelected == true)
                {
                    List<double> erg = excelControl.getWerte(1, zeile_gw);
                }
                else if(tvi_zy1.IsSelected == true)
                {
                    List<double> erg = excelControl.getWerte(2, zeile_gw);
                }
            }
            else
            { //Value is null 
            }
        }

        public void getStueckzahl()
        {
            double stueckzahl = 0;

            if (cbx_stkz.SelectedItem != null)
            {
                bool parseOK = double.TryParse(cbx_stkz.SelectedValue.ToString(), out stueckzahl);
            }
            else
            { //Value is null 
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            gw_ausgabe.Content = zeile_gw;
            getFestigkeit();
            getSchraube();
            getGewinde();
        }
    }
}
