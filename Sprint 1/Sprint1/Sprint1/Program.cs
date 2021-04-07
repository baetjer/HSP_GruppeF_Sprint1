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
            Schraubenkopf schraubenkopf = new Schraubenkopf();

            Console.WriteLine(schraubenkopf.Innensechskant);

            Console.ReadKey();
        }
    }
}
