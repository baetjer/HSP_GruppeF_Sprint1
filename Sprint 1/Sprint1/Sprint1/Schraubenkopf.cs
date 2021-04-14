using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint1
{
    public class Schraubenkopf
    {
        int input_schraubenkopf = 0;
        string output_schraubenkopf;
        int schraubenkopf_zahl1;

        string[] schraubenkopf_array = new string[2] { "Innensechskant", "Sechskant" };
        public void Schraubenkopf_Array()
        {
            Console.WriteLine("Bitte wählen Sie einen Schraubenkopf aus:");

            foreach (string i in schraubenkopf_array)
            {
                Console.WriteLine(schraubenkopf_zahl1 + " = " + i);
                schraubenkopf_zahl1 += 1;
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
        public void Schraubenkopf_Warenkorb()
        {
            Console.WriteLine(output_schraubenkopf);
        }
    }
}
