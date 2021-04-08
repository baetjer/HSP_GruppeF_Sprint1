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
            Schraubenkopf sk = new Schraubenkopf();
            sk.Schraubenkopf_Array();
            sk.Schraubenkopf_Ausgabe();

            Schraubenschaft ss = new Schraubenschaft();
            ss.Schraubenschaft_Array();
            ss.Schraubenschaft_Ausgabe();


            Console.ReadKey();
        }
    }
}
