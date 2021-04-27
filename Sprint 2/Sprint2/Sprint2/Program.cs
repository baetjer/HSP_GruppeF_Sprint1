using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class Program
    {
        static void Main(string[] args)
        {
            Gewinde gw = new Gewinde();
            Schraubenkopf sk = new Schraubenkopf(gw);

            Console.ReadKey();
        }
    }
}
