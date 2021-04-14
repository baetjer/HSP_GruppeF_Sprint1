using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint1
{
    class Gewinde
    {
        int Gewinde_zahl1;

        string[,] Gewinde_array2D = new string[,] { {"2mm","3mm"}, { "3.5mm", "4mm" }, { "4.5mm", "5mm" }, { "5.5mm", "6mm" }, { "6.5mm", "7mm" } };
        //  Alternativ string[] Gewinde_array = new string[] { "2mm","3mm",  "3.5mm", "4mm" ,  "4.5mm", "5mm" ,  "5.5mm", "6mm" , "6.5mm", "7mm" };
        public void Gewinde_Array()
        {
            Console.WriteLine("Bitte wählen Sie ein Gewinde aus:");

            foreach (string i in Gewinde_array2D) //
            {
                Console.WriteLine(Gewinde_zahl1 + " = " + i);
                Gewinde_zahl1 += 1;
            }
        }

        public string getGewinde_Array(int i)
        {
            return Gewinde_array2D[i,i];
            // Gewinde_array[i];
        }

        public void Gewinde_Ausgabe()
        {
            int input_Gewinde = Convert.ToInt32(Console.ReadLine());

            while (input_Gewinde < 0 || input_Gewinde > 9)
            {
                Console.WriteLine("Falsche Eingabe, bitte wählen Sie nochmal.");
                input_Gewinde = Convert.ToInt32(Console.ReadLine());
            }

            string output_Gewinde = getGewinde_Array(input_Gewinde);

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Sie haben sich für die Durchmesse {0} entschieden.", output_Gewinde);
            Console.WriteLine("--------------------------------------------------");
        }
    }
}
