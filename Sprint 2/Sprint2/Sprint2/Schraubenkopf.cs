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
        //Sechskant
        double[] seckskant_s = new double[12] { 5.5, 7, 8, 10, 13, 16, 18, 21, 24, 30, 36, 46 };
        double[] seckskant_k = new double[12] { 2, 2.8, 3.5, 4, 5.3, 6.4, 7.5, 8.8, 10, 12.5, 15, 18.7 };
        //Zylinderschraube
        string[] zylinderschraube_array = new string[2] { "Innensechskant", "Schlitz" };
        //Innensechskant
        double[] zylinder_is_k = new double[12] { 3, 4, 5, 6, 8, 10, 12, 14, 16, 20, 24, 30 };
        double[] zylinder_is_s = new double[12] { 2.5, 3, 4, 5, 6, 8, 10, 12, 14, 17, 19, 22 };
        //Schlitz
        double[] zylinder_sz_k4 = new double[12] { 2, 2.6, 3.3, 3.9, 5, 6, 6, 6, 6, 6, 6, 6 };
        //Innensechskant & Schlitz
        double[] zylinder_is_sz_d1 = new double[12] { 5.5, 7, 8.5, 10, 13, 16, 18, 21, 24, 30, 36, 45 };
        //Senkschraube
        double[] senk_d2 = new double[12] { 6.72, 8.96, 11.2, 13.44, 17.92, 22.4, 26.88, 26.88, 33.6, 40.32, 40.32, 40.32 };
        double[] senk_k5 = new double[12] { 1.86, 2.48, 3.1, 3.72, 4.96, 6.2, 7.44, 8.4, 8.8, 10.16, 10.16, 10.16 };

        public Schraubenkopf(Gewinde gw)
        {
            gw.test_gewinde();
            test_output = gw.getInput_Gewinde();
            Test_Schraubenkopf();
        }

        int test_output = 0;

        public void Test_Schraubenkopf()
        {
            Console.WriteLine(test_output);
        }

        public string getSchraubenkopf_Array(int i) { return schraubenkopf_array[i]; }
        public double getSeckskant_S(int i) { return seckskant_s[i]; }
        public double getSeckskant_K(int i) { return seckskant_k[i]; }
        public string getZylinderschraube_Array(int i) { return zylinderschraube_array[i]; }
        public double getZylinder_IS_K(int i) { return zylinder_is_k[i]; }
        public double getZylinder_IS_S(int i) { return zylinder_is_s[i]; }
        public double getZylinder_SZ_K4(int i) { return zylinder_sz_k4[i]; }
        public double getZylinder_IS_SZ_D1(int i) { return zylinder_is_sz_d1[i]; }
        public double getSenk_D2(int i) { return senk_d2[i]; }
        public double getSenk_K5(int i) { return senk_k5[i]; }

    }
}
