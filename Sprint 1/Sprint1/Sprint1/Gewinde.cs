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
                gewinde_zahl1 += 1;
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
    }
}
