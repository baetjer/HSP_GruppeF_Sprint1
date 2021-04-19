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
            //Schraubenkopf
            //Schraubenkopf sk = new Schraubenkopf();
            //sk.Schraubenkopf_Array();
            //sk.Schraubenkopf_Ausgabe();
            //sk.Schraubenkopf_Erzeugung();

            // Gewinde
            Gewinde gp = new Gewinde();
            gp.Gewinde_Array();
            gp.Gewinde_Ausgabe();
            gp.Gewinde_Steigung();

            //Schraubenkopf
            gp.Schraubenkopf_Array();
            gp.Schraubenkopf_Ausgabe();
            gp.Schraubenkopf_Erzeugung();

            //Schraubenschaft
            Schraubenschaft ss = new Schraubenschaft();
            ss.Schraubenschaft_Array();
            ss.Schraubenschaft_Ausgabe();

            // Festigkeitsklasse
            Festigkeitsklasse fk = new Festigkeitsklasse();
            fk.Festigkeit_Array();
            fk.Festigkeit_Ausgabe();
            fk.Festigkeit_Spannung();


            //Warenkorb
            Console.WriteLine("Ihre Auswahl lautet:");
            //sk.Schraubenkopf_Warenkorb();
            gp.Schraubenkopf_Warenkorb();
            gp.Gewinde_Warenkorb();
            ss.Schraubenschaft_Warenkorb();
            gp.Gewinde_Steigung_Warenkorb();
            fk.Festigkeit_Warenkorb();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Auswahl bestätigen?");
            Warenkorb wk = new Warenkorb();
            wk.Warenkorb_Array();
            wk.Warenkorb_Ausgabe();
            
            Console.ReadKey();
        }
    }
}
