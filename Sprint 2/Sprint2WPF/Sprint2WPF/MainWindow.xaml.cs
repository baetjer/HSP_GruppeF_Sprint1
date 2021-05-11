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

        int sheet_sk;

        double gw_output;
        double wert1_output;
        double wert2_output;
        double laenge_output;
        double dichte_output = 7.85;
        double stueckzahl_output;
        double volumen_output;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            getFestigkeit();
            getSchraube();
            getGewindeSheet();
            readGewinde(getGewinde(sheet_sk));
            setLaenge();
            setStckzahl();
            Berechnungen berechnungen = new Berechnungen();
            dichte_ausgabe.Content = dichte_output;
            traegheit_ausgabe.Content = berechnungen.getFlächenträgeitsmoment(gw_output);
            volumen_output = Math.Round(berechnungen.getVolumen(wert1_output, wert2_output, gw_output, laenge_output), 3);
            volumen_ausgabe.Content = volumen_output;
            gewicht_ausgabe.Content = Math.Round(berechnungen.getMasse(volumen_output, dichte_output, stueckzahl_output), 3);
            material_ausgabe.Content = "unlegierter Stahl";
        }

        private void cbx_gew_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

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
        }

        private void tvi_zy1_Selected(object sender, RoutedEventArgs e)
        {
            //Visibility Image
            hideallimages();
            img_DIN_4762.Visibility = Visibility.Visible;

            //visibility Gewinde
            showallgewinde();
            cbx_m14.Visibility = Visibility.Hidden;
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

        public void getGewindeSheet()
        {
            if (tvi_sk.IsSelected == true)
            {
                sheet_sk = 1;
            }
            else if (tvi_zy1.IsSelected == true)
            {
                sheet_sk = 2;
            }
            else if (tvi_zy2.IsSelected == true)
            {
                sheet_sk = 4;
            }
            else if (tvi_ss.IsSelected == true)
            {
                sheet_sk = 3;
            }
        }

        public List<double> getGewinde(int sheet)
        {
            List<double> gewinde = new List<double>();
            if (cbx_m3.IsSelected == true)
            {
                gewinde = excelControl.getWerte(sheet, 2);
            }
            else if (cbx_m4.IsSelected == true)
            {
                gewinde = excelControl.getWerte(sheet, 3);
            }
            else if (cbx_m5.IsSelected == true)
            {
                gewinde = excelControl.getWerte(sheet, 4);
            }
            else if (cbx_m6.IsSelected == true)
            {
                gewinde = excelControl.getWerte(sheet, 5);
            }
            else if (cbx_m8.IsSelected == true)
            {
                gewinde = excelControl.getWerte(sheet, 6);
            }
            else if (cbx_m10.IsSelected == true)
            {
                gewinde = excelControl.getWerte(sheet, 7);
            }
            else if (cbx_m12.IsSelected == true)
            {
                gewinde = excelControl.getWerte(sheet, 8);
            }
            else if (cbx_m14.IsSelected == true)
            {
                gewinde = excelControl.getWerte(sheet, 9);
            }
            else if (cbx_m16.IsSelected == true)
            {
                gewinde = excelControl.getWerte(sheet, 10);
            }
            else if (cbx_m20.IsSelected == true)
            {
                gewinde = excelControl.getWerte(sheet, 11);
            }
            else if (cbx_m24.IsSelected == true)
            {
                gewinde = excelControl.getWerte(sheet, 12);
            }
            else if (cbx_m30.IsSelected == true)
            {
                gewinde = excelControl.getWerte(sheet, 13);
            }
            else if (cbx_m36.IsSelected == true)
            {
                gewinde = excelControl.getWerte(sheet, 14);
            }

            return gewinde;
        }

        public void readGewinde(List<double> gewinde)
        {
            gw_ausgabe.Content = gewinde[0];
            gw_output = gewinde[0];

            if (tvi_sk.IsSelected == true)
            {
                wert1.Content = "s:";
                wert1_ausgabe.Content = gewinde[1];
                wert1_output = gewinde[1];
                wert2.Content = "e:";
                wert2_ausgabe.Content = gewinde[2];
                wert2_output = gewinde[2];
                wert3.Content = "k:";
                wert3_ausgabe.Content = gewinde[3];
            }
            else if (tvi_zy1.IsSelected == true)
            {
                wert1.Content = "s:";
                wert1_ausgabe.Content = gewinde[1];
                wert1_output = gewinde[1];
                wert2.Content = "dk:";
                wert2_ausgabe.Content = gewinde[2];
                wert2_output = gewinde[2];
                wert3.Content = "k:";
                wert3_ausgabe.Content = gewinde[3];
            }
            else if (tvi_zy2.IsSelected == true)
            {
                wert1.Content = "dk:";
                wert1_ausgabe.Content = gewinde[1];
                wert1_output = gewinde[1];
                wert2.Content = "n:";
                wert2_ausgabe.Content = gewinde[2];
                wert2_output = gewinde[2];
                wert3.Content = "k:";
                wert3_ausgabe.Content = gewinde[3];
            }
            else if (tvi_ss.IsSelected == true)
            {
                wert1.Content = "s:";
                wert1_ausgabe.Content = gewinde[1];
                wert1_output = gewinde[1];
                wert2.Content = "dk:";
                wert2_ausgabe.Content = gewinde[2];
                wert2_output = gewinde[2];
                wert3.Content = "k:";
                wert3_ausgabe.Content = gewinde[3];
            }
        }

        public void setLaenge()
        {
            List<double> laenge_liste = new List<double>();

            if (l10.IsSelected == true)
            {
                laenge_liste = excelControl.getWerte(5, 2);
                laenge.Content = laenge_liste[0];
                laenge_output = laenge_liste[0];
            }
            else if (l16.IsSelected == true)
            {
                laenge_liste = excelControl.getWerte(5, 3);
                laenge.Content = laenge_liste[0];
                laenge_output = laenge_liste[0];
            }
            else if (l20.IsSelected == true)
            {
                laenge_liste = excelControl.getWerte(5, 4);
                laenge.Content = laenge_liste[0];
                laenge_output = laenge_liste[0];
            }
            else if (l30.IsSelected == true)
            {
                laenge_liste = excelControl.getWerte(5, 5);
                laenge.Content = laenge_liste[0];
                laenge_output = laenge_liste[0];
            }
            else if (l40.IsSelected == true)
            {
                laenge_liste = excelControl.getWerte(5, 6);
                laenge.Content = laenge_liste[0];
                laenge_output = laenge_liste[0];
            }
        }

        public void setStckzahl()
        {
            List<double> stueckzahl = new List<double>();

            if (stk50.IsSelected == true)
            {
                stueckzahl = excelControl.getWerte(7, 2);
                stueckzahl_ausgabe.Content = stueckzahl[0];
                stueckzahl_output = stueckzahl[0];
            }
            else if (stk100.IsSelected == true)
            {
                stueckzahl = excelControl.getWerte(7, 3);
                stueckzahl_ausgabe.Content = stueckzahl[0];
                stueckzahl_output = stueckzahl[0];
            }
            else if (stk200.IsSelected == true)
            {
                stueckzahl = excelControl.getWerte(7, 4);
                stueckzahl_ausgabe.Content = stueckzahl[0];
                stueckzahl_output = stueckzahl[0];
            }
            else if (stk500.IsSelected == true)
            {
                stueckzahl = excelControl.getWerte(7, 5);
                stueckzahl_ausgabe.Content = stueckzahl[0];
                stueckzahl_output = stueckzahl[0];
            }
        }
    }
}
