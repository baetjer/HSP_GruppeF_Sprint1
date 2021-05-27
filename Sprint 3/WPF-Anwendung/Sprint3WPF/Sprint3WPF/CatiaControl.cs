using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint3WPF
{
    class CatiaControl
    {
        CatiaControl()
        {
            try
            {

                CatiaConnect cc = new CatiaConnect();

                // Finde Catia Prozess
                if (cc.CATIALaeuft())
                {
                    Console.WriteLine("0");

                    // Öffne ein neues Part
                    cc.ErzeugePart();
                    Console.WriteLine("1");

                    // Erstelle eine Skizze
                    cc.ErstelleLeereSkizze();
                    Console.WriteLine("2");

                    // Generiere ein Profil
                    cc.ErzeugeProfil(20, 10);
                    Console.WriteLine("3");

                    // Extrudiere Balken
                    cc.ErzeugeBalken(300);
                    Console.WriteLine("4");
                }
                else
                {
                    Console.WriteLine("Laufende Catia Application nicht gefunden");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Exception aufgetreten");
            }
            Console.WriteLine("Fertig - Taste drücken.");
            Console.ReadKey();
        }
    }
}
