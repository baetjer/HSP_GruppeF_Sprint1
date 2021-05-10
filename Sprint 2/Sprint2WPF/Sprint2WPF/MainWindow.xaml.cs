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
        ExcelControl excelControl = new ExcelControl();

        public MainWindow()
        {
            InitializeComponent();
        }


        private void cbx_gew_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if (cbx_gew.SelectedItem != null)
            //{
            //    bool parseOK = Int32.TryParse(cbx_gew.SelectedValue.ToString(), out zeile_gw);
            //}
            //else
            //{ //Value is null 
            //}

            //bool parseOK = Int32.TryParse(cbx_gew.SelectedValue.ToString(), out zeile);
        }

        private void cbx_laenge_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cbx_stkz_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

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

        public int getSheet()
        {
            int sheet;

            if (tvi_sk.IsSelected == true)
            {
                sheet = 1;
            }
            else if (tvi_zy1.IsSelected == true)
            {
                sheet = 2;
            }
            else if (tvi_zy2.IsSelected == true)
            {
                sheet = 3;
            }
            else if (tvi_ss.IsSelected == true)
            {
                sheet = 4;
            }

            return sheet;
        }

        public List<double> getGewinde(int sheet)
        {
            List<double> gewinde = new List<double>();
            if (cbx_m3.IsSelected == true)
            {
                gewinde = excelControl.getWerte(sheet, 4);
            }

            return gewinde;
        }

        public void readGewinde(List<double> gewinde)
        {
            gw_ausgabe.Content = gewinde[0];
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            getFestigkeit();
            getSchraube();
            int sheet = getSheet();
            readGewinde(getGewinde(sheet));
        }
    }
}
