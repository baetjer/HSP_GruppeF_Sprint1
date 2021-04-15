using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint1
{
    class Schraubenschaft
    {
        int input_schraubenschaft = 0;
        string output_schraubenschaft;
        int schraubenschaft_zahl1;

        string[] schraubenschaft_array = new string[5] { "10mm", "16mm", "20mm", "30mm", "40mm" };

        public void Schraubenschaft_Array()
        {
            Console.WriteLine("Bitte wählen Sie eine Schaftlänge aus:");

            foreach (string i in schraubenschaft_array)
            {
                Console.WriteLine(schraubenschaft_zahl1 + " = " + i);
                schraubenschaft_zahl1 += 1;
            }
        }
        
        public string getSchraubenschaft_Array(int i)
        {
            return schraubenschaft_array[i];
        }
        
        public void Schraubenschaft_Ausgabe()
        {
            input_schraubenschaft = Convert.ToInt32(Console.ReadLine());

            while (input_schraubenschaft < 0 || input_schraubenschaft > 4)
            {
                Console.WriteLine("Falsche Eingabe, bitte wählen Sie nochmal.");
                input_schraubenschaft = Convert.ToInt32(Console.ReadLine());
            }

            output_schraubenschaft = getSchraubenschaft_Array(input_schraubenschaft);

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Sie haben sich für die Länge {0} entschieden.", output_schraubenschaft);
            Console.WriteLine("--------------------------------------------------");
        }

        public void Schraubenschaft_Warenkorb()
        {
            Console.WriteLine("Schraubenschaftlänge: " + output_schraubenschaft);
        }
    }
}
