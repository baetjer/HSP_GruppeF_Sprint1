using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class Schraubenkopf
    {
        //Auswahl
        string[] schraubenkopf_array = new string[3] { "Sechskantschraube", "Zylinderschraube", "Senkschraube(Innensechskant)"};
        string[] zylinderschraube_array = new string[2] { "Innensechskant", "Schlitz" };


        //Sechskant
        double[] seckskant_s = new double[12] { 5.5, 7, 8, 10, 13, 16, 18, 21, 24, 30, 36, 46 };
        double[] seckskant_k = new double[12] { 2, 2.8, 3.5, 4, 5.3, 6.4, 7.5, 8.8, 10, 12.5, 15, 18.7 };

        //Zylinderschraube
        //Innensechskant
        double[] zylinder_is_k = new double[12] { 3, 4, 5, 6, 8, 10, 12, 14, 16, 20, 24, 30 };
        double[] zylinder_is_s = new double[12] { 2.5, 3, 4, 5, 6, 8, 10, 12, 14, 17, 19, 22 };

        //Schlitz
        double[] schlitz_sz_k4 = new double[12] { 2, 2.6, 3.3, 3.9, 5, 6, 6, 6, 6, 6, 6, 6 };

        //Innensechskant & Schlitz
        double[] zylinder_is_sz_d1 = new double[12] { 5.5, 7, 8.5, 10, 13, 16, 18, 21, 24, 30, 36, 45 };

        //Senkschraube
        double[] senk_d2 = new double[12] { 6.72, 8.96, 11.2, 13.44, 17.92, 22.4, 26.88, 26.88, 33.6, 40.32, 40.32, 40.32 };



    }
}
