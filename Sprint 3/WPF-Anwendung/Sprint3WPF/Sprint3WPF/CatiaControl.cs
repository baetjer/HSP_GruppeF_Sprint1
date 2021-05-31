using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint3WPF
{
    class CatiaControl
    {
        public CatiaControl(string gw_string, double laenge, double gw_laenge, double gw_double, double wert1, double wert2, double wert3)
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

                    Schraube dieSchraube = new Schraube(laenge, gw_laenge, "Standartgewinde", gw_string, 5.3d, gw_double / 2, 1.25d);

                    cc.ErzeugeZylinder(dieSchraube);
                    Console.WriteLine("Schaft");

                    cc.ErzeugeGewindeFeature(dieSchraube);
                    cc.ErzeugeGewindeHelix(dieSchraube);
                    Console.WriteLine("Gewinde");

                    Schraubenkopf derSchraubenkopf = new Schraubenkopf(wert1, wert2, wert3);

                    //cc.ErzeugeSechskant(derSchraubenkopf);
                    cc.ErzeugeZylinderKopf(derSchraubenkopf);
                }
                else
                {

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
