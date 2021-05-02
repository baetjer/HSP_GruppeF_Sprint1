using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class Schraubenkopf
    {


        ////Auswahl
        //string[] schraubenkopf_array = new string[3] { "Sechskantschraube", "Zylinderschraube", "Senkschraube(Innensechskant)" };
        ////Sechskant
        //double[] seckskant_s = new double[12] { 5.5, 7, 8, 10, 13, 16, 18, 21, 24, 30, 36, 46 };
        //double[] seckskant_k = new double[12] { 2, 2.8, 3.5, 4, 5.3, 6.4, 7.5, 8.8, 10, 12.5, 15, 18.7 };
        ////Zylinderschraube
        //string[] zylinderschraube_array = new string[2] { "Innensechskant", "Schlitz" };
        ////Innensechskant
        //double[] zylinder_is_k = new double[12] { 3, 4, 5, 6, 8, 10, 12, 14, 16, 20, 24, 30 };
        //double[] zylinder_is_s = new double[12] { 2.5, 3, 4, 5, 6, 8, 10, 12, 14, 17, 19, 22 };
        ////Schlitz
        //double[] zylinder_sz_k4 = new double[12] { 2, 2.6, 3.3, 3.9, 5, 6, 6, 6, 6, 6, 6, 6 };
        ////Innensechskant & Schlitz
        //double[] zylinder_is_sz_d1 = new double[12] { 5.5, 7, 8.5, 10, 13, 16, 18, 21, 24, 30, 36, 45 };
        ////Senkschraube
        //double[] senk_d2 = new double[12] { 6.72, 8.96, 11.2, 13.44, 17.92, 22.4, 26.88, 26.88, 33.6, 40.32, 40.32, 40.32 };
        //double[] senk_k5 = new double[12] { 1.86, 2.48, 3.1, 3.72, 4.96, 6.2, 7.44, 8.4, 8.8, 10.16, 10.16, 10.16 };
        //double[] senk_s3 = new double[12] { 2, 2.5, 3, 4, 5, 6, 8, 8, 10, 12, 12, 12 };
        ////input
        //int input_schraubenkopf1 = 0;
        //int input_schraubenkopf2 = 0;
        ////output string
        //string output_schraubenkopf1;
        //string output_schraubenkopf2;
        ////output double
        //double output_schraubenkopf3 = 0;
        //double output_schraubenkopf4 = 0;
        //double output_schraubenkopf5 = 0;
        ////input Gewinde
        //int input_getGewinde = 0;

        //public Schraubenkopf(Gewinde gw)
        //{
        //    Schraubenkopf_Array();
        //    Schraubenkopf_Ausgabe();
        //    Zylinderkopf_Ausgabe();
        //    gw.test_gewinde();
        //    input_getGewinde = gw.getInput_Gewinde();
        //    Schraubenkopf_Erzeugung();
        //    Console.WriteLine("Auswahl:");
        //    Schraubenkopf_Warenkorb();
        //}

        //public void Schraubenkopf_Array()
        //{
        //    int schraubenkopf_zahl1 = 0;
        //    Console.WriteLine("Bitte wählen Sie einen Schraubenkopf aus:");
        //    foreach (string i in schraubenkopf_array)
        //    {
        //        Console.WriteLine(schraubenkopf_zahl1 + " = " + i);
        //        schraubenkopf_zahl1++;
        //    }
        //}

        //public void Schraubenkopf_Ausgabe()
        //{
        //    try
        //    {
        //        input_schraubenkopf1 = Convert.ToInt32(Console.ReadLine());
        //        while (input_schraubenkopf1 < 0 || input_schraubenkopf1 > 2)
        //        {
        //            Console.WriteLine("Falsche Eingabe, bitte wählen Sie nochmal.");
        //            input_schraubenkopf1 = Convert.ToInt32(Console.ReadLine());
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Falsche Eingabe");
        //        Schraubenkopf_Ausgabe();
        //    }
        //    output_schraubenkopf1 = getSchraubenkopf_Array(input_schraubenkopf1);
        //    Console.WriteLine("--------------------------------------------------");
        //    Console.WriteLine("Sie haben sich für {0} entschieden.", output_schraubenkopf1);
        //    Console.WriteLine("--------------------------------------------------");
        //}
    

        //public void Zylinderkopf_Ausgabe()
        //{
        //    int schraubenkopf_zahl2 = 0;
        //    if (input_schraubenkopf1 == 1)
        //    {
        //        Console.WriteLine("Bitte wählen Sie einen Typ der Zylinderschraube aus:");
        //        foreach (string i in zylinderschraube_array)
        //        {
        //        Console.WriteLine(schraubenkopf_zahl2 + " = " + i);
        //        schraubenkopf_zahl2++;
        //        }
        //        try
        //        {
        //            input_schraubenkopf2 = Convert.ToInt32(Console.ReadLine());
        //            while ((input_schraubenkopf2 != 0) && (input_schraubenkopf2 != 1))
        //            {
        //                Console.WriteLine("Falsche Eingabe, bitte wählen Sie nochmal.");
        //                input_schraubenkopf2 = Convert.ToInt32(Console.ReadLine());
        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine("Falsche Eingabe");
        //            Zylinderkopf_Ausgabe();
        //        }
        //        output_schraubenkopf2 = getZylinderschraube_Array(input_schraubenkopf2);
        //        Console.WriteLine("--------------------------------------------------");
        //        Console.WriteLine("Sie haben sich für {0} entschieden.", output_schraubenkopf2);
        //        Console.WriteLine("--------------------------------------------------");
        //    }
        //}

        //public void Schraubenkopf_Erzeugung()
        //{
        //    if (input_schraubenkopf1 == 0)
        //    {
        //        output_schraubenkopf3 = getSeckskant_S(input_getGewinde);
        //        output_schraubenkopf4 = getSeckskant_K(input_getGewinde);
        //    }
        //    else if (input_schraubenkopf1 == 1)
        //    {
        //        if (input_schraubenkopf2 == 0)
        //        {
        //            output_schraubenkopf3 = getZylinder_IS_K(input_getGewinde);
        //            output_schraubenkopf4 = getZylinder_IS_S(input_getGewinde);
        //            output_schraubenkopf5 = getZylinder_IS_SZ_D1(input_getGewinde);
        //        }
        //        else if (input_schraubenkopf2 == 1)
        //        {
        //            output_schraubenkopf3 = getZylinder_SZ_K4(input_getGewinde);
        //            output_schraubenkopf4 = getZylinder_IS_SZ_D1(input_getGewinde);
        //        }
        //    }
        //    else if (input_schraubenkopf1 == 2)
        //    {
        //        output_schraubenkopf3 = getSenk_D2(input_getGewinde);
        //        output_schraubenkopf4 = getSenk_K5(input_getGewinde);
        //        output_schraubenkopf5 = getSenk_S3(input_getGewinde);
        //    }
        //}

        //public void Schraubenkopf_Warenkorb()
        //{
        //    if (input_schraubenkopf1 == 0)
        //    {
        //        Console.WriteLine("{0} | Schlüsselweite = {1} mm | Schraubenkopfdicke = {2} mm", output_schraubenkopf1, output_schraubenkopf3, output_schraubenkopf4);
        //    }
        //    if (input_schraubenkopf1 == 1)
        //    {
        //        if (input_schraubenkopf2 == 0)
        //        {
        //            Console.WriteLine("{0} | Schraubenkopfdicke = {1} mm | Schlüsselweite = {2} mm | Schraubenkopfdurchmesser = {3} mm", output_schraubenkopf2, output_schraubenkopf3, output_schraubenkopf4, output_schraubenkopf5);
        //        }
        //        else if (input_schraubenkopf2 == 1)
        //        {
        //            Console.WriteLine("{0} | Schraubenkopfdicke = {1} mm | Schraubenkopfdurchmesser = {2} mm", output_schraubenkopf2, output_schraubenkopf3, output_schraubenkopf4);
        //        }
        //    }
        //    if (input_schraubenkopf1 == 2)
        //    {
        //        Console.WriteLine("{0} | Schraubenkopfdurchmesser = {1} mm | Schraubenkopfdicke = {2} mm | Schlüsselweite = {3} mm", output_schraubenkopf1, output_schraubenkopf3, output_schraubenkopf4, output_schraubenkopf5);
        //    }
        //}

        //public string getSchraubenkopf_Array(int i) { return schraubenkopf_array[i]; }
        //public double getSeckskant_S(int i) { return seckskant_s[i]; }
        //public double getSeckskant_K(int i) { return seckskant_k[i]; }
        //public string getZylinderschraube_Array(int i) { return zylinderschraube_array[i]; }
        //public double getZylinder_IS_K(int i) { return zylinder_is_k[i]; }
        //public double getZylinder_IS_S(int i) { return zylinder_is_s[i]; }
        //public double getZylinder_SZ_K4(int i) { return zylinder_sz_k4[i]; }
        //public double getZylinder_IS_SZ_D1(int i) { return zylinder_is_sz_d1[i]; }
        //public double getSenk_D2(int i) { return senk_d2[i]; }
        //public double getSenk_K5(int i) { return senk_k5[i]; }
        //public double getSenk_S3(int i) { return senk_s3[i]; }

    }
}
