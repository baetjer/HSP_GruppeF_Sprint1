using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint1
{
    class Festigkeitsklasse
    {
        static void Main(string[] args)
        {
            string[,] FestigkeitsklassenTabelle = new string[4, 3];

            //Festigkeitsklasse 5.8
            FestigkeitsklassenTabelle[0, 0] = "5.8";
            FestigkeitsklassenTabelle[0, 1] = "500 N/mm²";
            FestigkeitsklassenTabelle[0, 2] = "400 N/mm²";

            //Festigkeitsklasse 8.8
            FestigkeitsklassenTabelle[1, 0] = "8.8";
            FestigkeitsklassenTabelle[1, 1] = "800 N/mm²";
            FestigkeitsklassenTabelle[1, 2] = "640 N/mm²";

            //Festigkeitsklasse 9.8
            FestigkeitsklassenTabelle[2, 0] = "9.8";
            FestigkeitsklassenTabelle[2, 1] = "900 N/mm²";
            FestigkeitsklassenTabelle[2, 2] = "720 N/mm²";

            //Festigkeitsklasse 10.9
            FestigkeitsklassenTabelle[3, 0] = "10.9";
            FestigkeitsklassenTabelle[3, 1] = "1000 N/mm²";
            FestigkeitsklassenTabelle[3, 2] = "900 N/mm²";

            Console.WriteLine("Festigkeitsklasse: " + FestigkeitsklassenTabelle[1, 0]);
            Console.WriteLine("Zugfestigkeit: " + FestigkeitsklassenTabelle[1, 1]);
            Console.WriteLine("Streckgrenze: " + FestigkeitsklassenTabelle[1, 2]);

            Console.ReadLine();
        }
    }
}
