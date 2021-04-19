using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint1
{
    class Gewinde
    {
        //Gewinde
        int input_gewinde = 0;
        int output_gewinde = 0;
        int gewinde_zahl1 = 0;

        //string[,] gewinde_array2D = new string[,] { {"2mm","3mm"}, { "3.5mm", "4mm" }, { "4.5mm", "5mm" }, { "5.5mm", "6mm" }, { "6.5mm", "7mm" } };
        int[] gewinde_array = new int[12] {3, 4, 5, 6, 8, 10, 12, 14, 16, 20, 24, 30};

        public void Gewinde_Array()
        {
            Console.WriteLine("Bitte wählen Sie ein Gewinde aus:");

            foreach (int i in gewinde_array)
            {
                Console.WriteLine(gewinde_zahl1 + " = " + "M{0}", i);
                gewinde_zahl1++;
            }
        }

        public int getGewinde_Array(int i)
        {
            return gewinde_array[i];
        }

        public void Gewinde_Ausgabe()
        {
            input_gewinde = Convert.ToInt32(Console.ReadLine());

            while (input_gewinde < 0 || input_gewinde > 11)
            {
                Console.WriteLine("Falsche Eingabe, bitte wählen Sie nochmal.");
                input_gewinde = Convert.ToInt32(Console.ReadLine());
            }

            output_gewinde = getGewinde_Array(input_gewinde);

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Sie haben sich für M{0} entschieden.", output_gewinde);
            Console.WriteLine("--------------------------------------------------");
        }

        public void Gewinde_Warenkorb()
        {
            Console.WriteLine("Gewindedurchmesser: M{0}", output_gewinde);
        }


        //Gewinde anpassen
        string[] gewinde_entscheidung = new string[2] { "nein", "ja" };
        double steigungswinkel = 0;
        int input_gewinde4 = 0;

        public string getGewinde_Entscheidung(int i)
        {
            return gewinde_entscheidung[i];
        }

        public void Gewinde_Steigung()
        {
            double flankendurchmesser = 0;
            double steigung = 0;
            double platzhalter = 0;
            int gewindezahl2 = 0;

            Console.WriteLine("Möchten Sie ihr Gewinde bearbeiten?");
            foreach (string i in gewinde_entscheidung)
            {
                Console.WriteLine(gewindezahl2 + " = " + i);
                gewindezahl2++;
            }
            input_gewinde4 = Convert.ToInt32(Console.ReadLine());

            while ((input_gewinde4 != 0) && (input_gewinde4 != 1))
            {
                Console.WriteLine("Falsche Eingabe, bitte wählen Sie nochmal.");
                input_gewinde4 = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("--------------------------------------------------");

            if (input_gewinde4 == 1)
            {
                Console.WriteLine("Geben Sie die Gewindesteigung ein:");
                string input_gewinde2 = Console.ReadLine();
                steigung = Convert.ToDouble(input_gewinde2);

                Console.WriteLine("--------------------------------------------------");

                Console.WriteLine("Geben Sie den Flankendurchmesser ein:");
                string input_gewinde3 = Console.ReadLine();
                flankendurchmesser = Convert.ToDouble(input_gewinde3);

                platzhalter = Math.Atan(steigung / (flankendurchmesser * (Math.PI)));
                steigungswinkel = (180 / Math.PI) * platzhalter;

                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Der Steigungswinkel des Gewindes lautet {0}°.", Math.Round(steigungswinkel, 2));
                Console.WriteLine("--------------------------------------------------");
            }

            else if (input_gewinde4 == 0)
            {
            }
        }

        public void Gewinde_Steigung_Warenkorb()
        {
            if (input_gewinde4 == 1)
            {
                Console.WriteLine("Gewindesteigungswinkel: {0}°", Math.Round(steigungswinkel, 2));
            }

            else
            {

            }
        }

        //Schraubenkopf
        int input_schraubenkopf = 0;
        string output_schraubenkopf;
        int schraubenkopf_zahl1 = 0;

        string[] schraubenkopf_array = new string[2] { "Innensechskant", "Sechskant" };

        public void Schraubenkopf_Array()
        {
            Console.WriteLine("Bitte wählen Sie einen Schraubenkopf aus:");

            foreach (string i in schraubenkopf_array)
            {
                Console.WriteLine(schraubenkopf_zahl1 + " = " + i);
                schraubenkopf_zahl1++;
            }
        }

        public string getSchraubenkopf_Array(int i)
        {
            return schraubenkopf_array[i];
        }

        public void Schraubenkopf_Ausgabe()
        {
            input_schraubenkopf = Convert.ToInt32(Console.ReadLine());

            while ((input_schraubenkopf != 0) && (input_schraubenkopf != 1))
            {
                Console.WriteLine("Falsche Eingabe, bitte wählen Sie nochmal.");
                input_schraubenkopf = Convert.ToInt32(Console.ReadLine());
            }

            output_schraubenkopf = getSchraubenkopf_Array(input_schraubenkopf);

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Sie haben sich für {0} entschieden.", output_schraubenkopf);
            Console.WriteLine("--------------------------------------------------");
        }


        //Schraubenkopf-Werte
        double output2_Schraubenkopf;
        double output3_Schraubenkopf;
        double output4_Schraubenkopf;
        double output5_Schraubenkopf;

        //Sechskant
        double[] s_sk = new double[12] { 5.5, 7, 8, 10, 13, 16, 18, 21, 24, 30, 36, 46 };
        double[] k_sk = new double[12] { 2, 2.8, 3.5, 4, 5.3, 6.4, 7.5, 8.8, 10, 12.5, 15, 18.7 };

        //Innensechskant
        double[] d1_is = new double[12] { 5.5, 7, 8.5, 10, 13, 16, 18, 21, 24, 30, 36, 45 };
        double[] k_is = new double[12] { 3, 4, 5, 6, 8, 10, 12, 14, 16, 20, 24, 30 };
        double[] s_is = new double[12] { 2.5, 3, 4, 5, 6, 8, 10, 12, 14, 17, 19, 22 };
        double[] dh_is = new double[12] { 3.5, 4.5, 5.5, 6.6, 9, 11, 13.5, 15.5, 17.5, 22, 26, 33 };

        public double getS_SK(int i)
        {
            return s_sk[i];
        }

        public double getK_SK(int i)
        {
            return k_sk[i];
        }

        public double getD1_IS(int i)
        {
            return d1_is[i];
        }

        public double getK_IS(int i)
        {
            return k_is[i];
        }

        public double getS_IS(int i)
        {
            return s_is[i];
        }

        public double getDh_IS(int i)
        {
            return dh_is[i];
        }

        public void Schraubenkopf_Erzeugung()
        {
            if (input_schraubenkopf == 0)
            {
                output2_Schraubenkopf = getD1_IS(input_gewinde);
                output3_Schraubenkopf = getK_IS(input_gewinde);
                output4_Schraubenkopf = getS_IS(input_gewinde);
                output5_Schraubenkopf = getDh_IS(input_gewinde);
            }

            else if (input_schraubenkopf == 1)
            {
                output2_Schraubenkopf = getS_SK(input_gewinde);
                output3_Schraubenkopf = getK_SK(input_gewinde);
            }
        }

        public void Schraubenkopf_Warenkorb()
        {
            if (input_schraubenkopf == 0)
            {
                Console.WriteLine("{0} | d1 = {1} | k = {2} | s = {3} | dh = {4}", output_schraubenkopf, output2_Schraubenkopf, output3_Schraubenkopf, output4_Schraubenkopf, output5_Schraubenkopf);
            }

            else if (input_schraubenkopf == 1)
            {
                Console.WriteLine("{0} | s = {1} | k = {2}", output_schraubenkopf, output2_Schraubenkopf, output3_Schraubenkopf);
            }
        }
    }
}
