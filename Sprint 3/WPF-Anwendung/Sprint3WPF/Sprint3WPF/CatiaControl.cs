using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint3WPF
{
    class CatiaControl
    {
        public CatiaControl()
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
                    // cc.ErzeugeProfil(20, 10);
                    // Console.WriteLine("3");

                    // Extrudiere Balken
                    // cc.ErzeugeBalken(300);
                    // Console.WriteLine("4");

                    Schraube dieSchraube = new Schraube(60, 50, "Standartgewinde", "M8", 5.3d, 4d, 1.25d);

                    cc.ErzeugeZylinder(dieSchraube);
                    Console.WriteLine("Schaft");

                    // cc.ErzeugeGewindeFeature();
                    cc.ErzeugeGewindeHelix(dieSchraube);
                    Console.WriteLine("Gewinde");

                    Schraubenkopf derSchraubenkopf = new Schraubenkopf(7, 7.66, 2.8);

                    cc.ErzeugeSechskant(derSchraubenkopf);
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
        }
    }
}
