using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint1
{
    class Festigkeitsklasse
    {
        int festigkeitzahl1 = 0;
        int festigkeitzahl2 = 0;
        int input_festigkeit1 = 0;
        int input_festigkeit2 = 0;
        string output_festigkeit1;
        string output_festigkeit2;

        string[] festigkeit_klassen = new string[4] {"5.8", "8.8", "9.8", "10.9" };
        string[] festigkeit_spannung5_8 = new string[2] {"500 N/mm²", "400 N/mm²" };
        string[] festigkeit_spannung8_8 = new string[2] {"800 N/mm²", "640 N/mm²" };
        string[] festigkeit_spannung9_8 = new string[2] { "900 N/mm²", "720 N/mm²" };
        string[] festigkeit_spannung10_8 = new string[2] { "1000 N/mm²", "900 N/mm²" };

        public void Festigkeit_Array()
        {
            Console.WriteLine("Bitte wählen Sie eine Festigkeitsklasse aus:");

            foreach (string i in festigkeit_klassen)
            {
                Console.WriteLine(festigkeitzahl1 + " = " + i);
                festigkeitzahl1 += 1;
            }
        }

        public string getFestigkeit_Array(int i)
        {
            return festigkeit_klassen[i];
        }

        public string getFestigkeit_Spannung5_8(int j)
        {
            return festigkeit_spannung5_8[j];
        }

        public string getFestigkeit_Spannung8_8(int j)
        {
            return festigkeit_spannung8_8[j];
        }

        public string getFestigkeit_Spannung9_8(int j)
        {
            return festigkeit_spannung9_8[j];
        }

        public string getFestigkeit_Spannung10_8(int j)
        {
            return festigkeit_spannung10_8[j];
        }

        public void Festigkeit_Ausgabe()
        {
            input_festigkeit1 = Convert.ToInt32(Console.ReadLine());

            while (input_festigkeit1 < 0 || input_festigkeit1 > 3)
            {
                Console.WriteLine("Falsche Eingabe, bitte wählen Sie nochmal.");
                input_festigkeit1 = Convert.ToInt32(Console.ReadLine());
            }

            output_festigkeit1 = getFestigkeit_Array(input_festigkeit1);

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Sie haben sich für den Durchmesser {0} entschieden.", output_festigkeit1);
            Console.WriteLine("--------------------------------------------------");
        }

        public void Festigkeit_Spannung()
        {

            if (input_festigkeit1 == 0)
            {
                foreach (string j in festigkeit_spannung5_8)
                {
                    Console.WriteLine(festigkeitzahl2 + " = " + j);
                    festigkeitzahl2 += 1;
                }

                input_festigkeit2 = Convert.ToInt32(Console.ReadLine());

                while ((input_festigkeit2 != 0) && (input_festigkeit2 != 1))
                {
                    Console.WriteLine("Falsche Eingabe, bitte wählen Sie nochmal.");
                    input_festigkeit1 = Convert.ToInt32(Console.ReadLine());
                }

                output_festigkeit2 = getFestigkeit_Spannung8_8(input_festigkeit2);
            }

            else if (input_festigkeit1 == 1)
            {
                foreach (string j in festigkeit_spannung8_8)
                {
                    Console.WriteLine(festigkeitzahl2 + " = " + j);
                    festigkeitzahl2 += 1;
                }
                
                input_festigkeit2 = Convert.ToInt32(Console.ReadLine());

                while ((input_festigkeit2 != 0) && (input_festigkeit2 != 1))
                {
                    Console.WriteLine("Falsche Eingabe, bitte wählen Sie nochmal.");
                    input_festigkeit1 = Convert.ToInt32(Console.ReadLine());
                }

                output_festigkeit2 = getFestigkeit_Spannung8_8(input_festigkeit2);
            }

            else if (input_festigkeit1 == 2)
            {
                foreach (string j in festigkeit_spannung9_8)
                {
                    Console.WriteLine(festigkeitzahl2 + " = " + j);
                    festigkeitzahl2 += 1;
                }
                
                input_festigkeit2 = Convert.ToInt32(Console.ReadLine());

                while ((input_festigkeit2 != 0) && (input_festigkeit2 != 1))
                {
                    Console.WriteLine("Falsche Eingabe, bitte wählen Sie nochmal.");
                    input_festigkeit1 = Convert.ToInt32(Console.ReadLine());
                }

                output_festigkeit2 = getFestigkeit_Spannung9_8(input_festigkeit2);
            }

            else if (input_festigkeit1 == 3)
            {
                foreach (string j in festigkeit_spannung10_8)
                {
                    Console.WriteLine(festigkeitzahl2 + " = " + j);
                    festigkeitzahl2 += 1;
                }

                input_festigkeit2 = Convert.ToInt32(Console.ReadLine());

                while ((input_festigkeit2 != 0) && (input_festigkeit2 != 1))
                {
                    Console.WriteLine("Falsche Eingabe, bitte wählen Sie nochmal.");
                    input_festigkeit1 = Convert.ToInt32(Console.ReadLine());
                }

                output_festigkeit2 = getFestigkeit_Spannung10_8(input_festigkeit2);
            }


            Console.WriteLine(output_festigkeit2);
        }

        //static void Main(string[] args)
        //{
        //  string[,] FestigkeitsklassenTabelle = new string[4, 3];

        //Festigkeitsklasse 5.8
        //FestigkeitsklassenTabelle[0, 0] = "5.8";
        //FestigkeitsklassenTabelle[0, 1] = "500 N/mm²";
        //FestigkeitsklassenTabelle[0, 2] = "400 N/mm²";

        //Festigkeitsklasse 8.8
        //FestigkeitsklassenTabelle[1, 0] = "8.8";
        //FestigkeitsklassenTabelle[1, 1] = "800 N/mm²";
        //FestigkeitsklassenTabelle[1, 2] = "640 N/mm²";

        //Festigkeitsklasse 9.8
        //FestigkeitsklassenTabelle[2, 0] = "9.8";
        //FestigkeitsklassenTabelle[2, 1] = "900 N/mm²";
        //FestigkeitsklassenTabelle[2, 2] = "720 N/mm²";

        //Festigkeitsklasse 10.9
        //FestigkeitsklassenTabelle[3, 0] = "10.9";
        //FestigkeitsklassenTabelle[3, 1] = "1000 N/mm²";
        //FestigkeitsklassenTabelle[3, 2] = "900 N/mm²";

        //Console.WriteLine("Festigkeitsklasse: " + FestigkeitsklassenTabelle[1, 0]);
        //Console.WriteLine("Zugfestigkeit: " + FestigkeitsklassenTabelle[1, 1]);
        //Console.WriteLine("Streckgrenze: " + FestigkeitsklassenTabelle[1, 2]);

        //Console.ReadLine();
        //}
    }
}
