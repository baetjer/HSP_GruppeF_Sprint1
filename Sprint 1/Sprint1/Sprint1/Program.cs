using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint1
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte wählen Sie einen Schraubenkopf aus:");

            Schraubenkopf sk = new Schraubenkopf();
            sk.Schraubenkopf_Array();

            int input_schraubenkopf = Convert.ToInt32(Console.ReadLine());

            while ((input_schraubenkopf != 0) && (input_schraubenkopf != 1))
            {
                Console.WriteLine("Falsche Eingabe, bitte wählen Sie nochmal.");
                input_schraubenkopf = Convert.ToInt32(Console.ReadLine());
            }

            string output_schraubenkopf = sk.getSchraubenkopf_Array(input_schraubenkopf);

            Console.WriteLine("Sie haben sich für {0} entschieden.", output_schraubenkopf);



            Console.ReadKey();
        }
    }
}
