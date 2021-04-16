using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint1
{
    class Warenkorb
    {
        int warenkorb_zahl1;
        string[] warenkorb_array = new string[2] { "nein", "ja" };

        public void Warenkorb_Array()
        {
            foreach (string i in warenkorb_array)
            {
                Console.WriteLine(warenkorb_zahl1 + " = " + i);
                warenkorb_zahl1++;
            }
        }

        public string getWarenkorb_Array(int i)
        {
            return warenkorb_array[i];
        }


        public void Warenkorb_Ausgabe()
        {
            int input_warenkorb = Convert.ToInt32(Console.ReadLine());

            while ((input_warenkorb != 0) && (input_warenkorb != 1))
            {
                Console.WriteLine("Falsche Eingabe, bitte wählen Sie nochmal.");
                input_warenkorb = Convert.ToInt32(Console.ReadLine());
            }

            string output_warenkorb = getWarenkorb_Array(input_warenkorb);

            if (input_warenkorb == 0)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Ihre Auswahl wurde gelöscht.");
            }

            else if (input_warenkorb == 1)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Ihre Auswahl wurde zum Warenkorb hinzugefügt.");
            }
        }
    }
}
