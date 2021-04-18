using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint1
{
    class Schraubenkopf
    {
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
        double k_sk = 0;
        double s_sk = 0;
        double d1_is = 0;
        double k_is = 0;
        double s_is = 0;

        public void Schraubenkopf_Erzeugung()
        {
            if (input_schraubenkopf == 0)
            {
                Console.WriteLine("Bitte geben Sie den Wert für d1 ein:");
                string input_is1 = Console.ReadLine();
                d1_is = Convert.ToDouble(input_is1);
                Console.WriteLine("--------------------------------------------------");

                Console.WriteLine("Bitte geben Sie den Wert für k ein:");
                string input_is2 = Console.ReadLine();
                k_is = Convert.ToDouble(input_is2);
                Console.WriteLine("--------------------------------------------------");

                Console.WriteLine("Bitte geben Sie den Wert für s ein:");
                string input_is3 = Console.ReadLine();
                s_is = Convert.ToDouble(input_is3);
                Console.WriteLine("--------------------------------------------------");
            }

            else if (input_schraubenkopf == 1)
            {
                Console.WriteLine("Bitte geben Sie den Wert für s ein:");
                string input_sk1 = Console.ReadLine();
                s_sk = Convert.ToDouble(input_sk1);
                Console.WriteLine("--------------------------------------------------");

                Console.WriteLine("Bitte geben Sie den Wert für k ein:");
                string input_sk2 = Console.ReadLine();
                k_sk = Convert.ToDouble(input_sk2);
                Console.WriteLine("--------------------------------------------------");
            }
        }

        public void Schraubenkopf_Warenkorb()
        {
            if (input_schraubenkopf == 0)
            {
                Console.WriteLine("{0} | d1 = {1} | k = {2} | s = {3}", output_schraubenkopf, d1_is, k_is, s_is);
            }
            else if (input_schraubenkopf == 1)
            {
                Console.WriteLine("{0} | s = {1} | k = {2}", output_schraubenkopf, s_sk, k_sk);
            }
        }
    }
}
