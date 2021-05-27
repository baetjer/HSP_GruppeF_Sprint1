using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint3WPF
{
    class ExcelControl
    {
        public ExcelControl()
        {

        }

        Excel excel = new Excel("filler");

        public List<double> getWerte(int sheet_excel, int zeile_excel)
        {
            excel.getSheet(sheet_excel);
            List<double> liste = new List<double>();

            for (int i = 0; i < 4; i++)
            {
                liste.Add(excel.ReadCell(zeile_excel, i));
            }

            return liste;
        }

        public void Excel_Quit()
        {
            excel.ExcelQuit();
        }
    }
}
