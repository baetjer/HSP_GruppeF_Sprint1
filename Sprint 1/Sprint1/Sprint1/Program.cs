﻿using System;
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
            //Schraubenkopf
            Schraubenkopf sk = new Schraubenkopf();
            sk.Schraubenkopf_Array();
            sk.Schraubenkopf_Ausgabe();

            //Schraubenschaft
            Schraubenschaft ss = new Schraubenschaft();
            ss.Schraubenschaft_Array();
            ss.Schraubenschaft_Ausgabe();

            // Gwinde
            Gewinde gp = new Gewinde();
            gp.Gewinde_Array();
            gp.Gewinde_Ausgabe();

            //Warenkorb
            Console.WriteLine("Ihre Auswahl lautet:");
            sk.Schraubenkopf_Warenkorb();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Auswahl bestätigen?");
            Warenkorb wk = new Warenkorb();
            wk.Warenkorb_Array();
            wk.Warenkorb_Ausgabe();

            Console.ReadKey();
        }
    }
}
