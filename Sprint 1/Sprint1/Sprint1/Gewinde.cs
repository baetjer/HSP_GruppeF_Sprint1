using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint1
{
    class Gewinde
    {
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
            int input_gewinde4 = 0;

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

            else
            {
            }
        }

        public void Gewinde_Steigung_Warenkorb()
        {
            Console.WriteLine("Gewindesteigungswinkel: {0}°", Math.Round(steigungswinkel, 2));
        }
    }
}
