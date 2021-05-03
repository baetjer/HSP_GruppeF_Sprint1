using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class Gewinde
    {
        Excel excel = new Excel(System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "DatenbankSchraube.xlsx"), 1);
        int input_gw_g = 0;


        public Gewinde()
        {
            input_gw_g = setGewinde();
            readWerte();
        }

        public int setGewinde()
        {
            int input_gw = Convert.ToInt32(Console.ReadLine());

            return input_gw;
        }

        public IList<double> getWerte()
        {
            double output_gw = excel.ReadCell(input_gw_g, 0);
            double output_s = excel.ReadCell(input_gw_g, 1);
            double output_e = excel.ReadCell(input_gw_g, 2);
            double output_k = excel.ReadCell(input_gw_g, 3);

            return new List<double>() { output_gw, output_s, output_e, output_k };
        }

        public void readWerte()
        {
            double output_gw = getWerte();
            //double output_s = 0;
            //double output_e = 0;
            //double output_k = 0;

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
