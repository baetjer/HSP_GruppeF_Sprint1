using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace Sprint2
{
    class Program
    {
        public Program()
        {
            OpenFile();
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            //Gewinde gw = new Gewinde();
            //Schraubenkopf sk = new Schraubenkopf(gw);

            Console.ReadKey();
        }

        public void OpenFile()
        {
            Excel excel = new Excel(System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "DatenbankSchraube.xlsx"), 1);
        }
    }
}
