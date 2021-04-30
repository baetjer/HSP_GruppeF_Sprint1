using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Sprint2
{
    class Program
    {
        static void Main(string[] args)
        {
            new ExcelControl();
            Gewinde gw = new Gewinde();
            Schraubenkopf sk = new Schraubenkopf(gw);

            Console.ReadKey();
        }
    }
}
