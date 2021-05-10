using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace Sprint2
{
    class Gewinde
    {
        
        int input_gw_g = 0;
        int sk_auswahl;

        public Gewinde()
        {
            setGewinde();
            readWerte();
        }

        public void setGewinde()
        {
            sk_auswahl = Convert.ToInt32(Console.ReadLine());
            input_gw_g = Convert.ToInt32(Console.ReadLine());
            input_gw_g--;
        }

        public List<double> getWerte(int sk_auswahl)
        {
            this.sk_auswahl = sk_auswahl;
            Excel excel = new Excel("filler", sk_auswahl);
            List<double> liste = new List<double>();

            for (int i = 0; i < 4; i++)
            {
                liste.Add(excel.ReadCell(input_gw_g, i));
            }

            return liste;
        }

        public void readWerte()
        {
            List<double> erg = getWerte(sk_auswahl);
            foreach (double i in erg)
            {
                Console.WriteLine(i);
            }
            Berechnungen berechnungen = new Berechnungen();
            Console.WriteLine(berechnungen.getVolumen(1, 2, 3, 4));
        }





        //double output_gw = 0;
        //int input = 0;

        //double output_s = 0;
        //double output_e = 0;
        //double output_k = 0;


        //public Gewinde()
        //{
        //    readGewinde();
        //    getOutput(output_gw);
        //    setGewinde();
        //    getSK(input);
        //    Console.ReadKey();
        //    readSKOutput(output_s, output_e, output_k);
        //}

        //public void readGewinde()
        //{
        //    for (int i = 2; i<15; i++)
        //    {
        //        Console.WriteLine(excel.ReadCell(i, 0)); 
        //    }
        //}

        //public double setGewinde()
        //{
        //    double output_gw1;

        //    int input_gw1 = Convert.ToInt32(Console.ReadLine());

        //    output_gw1 = excel.ReadCell(input_gw1, 0);

        //    return output_gw1;
        //}

        //public void getOutput(double output_gw1)
        //{
        //    Console.WriteLine(output_gw1);
        //}

        //public double getSK(int input_gw)
        //{
        //    double output_s = 0;
        //    double output_e = 0;
        //    double output_k = 0;

        //    if (input_gw == 3)
        //    {
        //        output_s = excel.ReadCell(input_gw, 1);
        //        output_e = excel.ReadCell(input_gw, 2);
        //        output_k = excel.ReadCell(input_gw, 3);
        //    }

        //    return output_s;
        //    return output_e;
        //    return output_k;
        //}

        //public void readSKOutput(double input_s, double input_e, double input_k)
        //{
        //    Console.WriteLine(input_s + input_e + input_k);
        //}

        //public int setGewinde()
        //{

        //}






        //int input_gewinde = 0;

        //public void test_gewinde()
        //{
        //    Console.WriteLine("Gewinde auswählen");
        //    try
        //    {
        //        input_gewinde = Convert.ToInt32(Console.ReadLine());
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Falsche Eingabe");
        //        test_gewinde();
        //    }
        //}

        //public int getInput_Gewinde()
        //{
        //    return input_gewinde;
        //}
    }
}
