using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2WPF
{
    class ExcelControl
    {
        public ExcelControl(int sheet_excel, int zeile_excel)
        {
            getWerte(sheet_excel, zeile_excel);
        }


        public List<double> getWerte(int sheet_excel, int zeile_excel)
        {
            Excel excel = new Excel("filler", sheet_excel);
            List<double> liste = new List<double>();

            for (int i = 0; i < 4; i++)
            {
                liste.Add(excel.ReadCell(zeile_excel, i));
            }

            return liste;
        }
    }
}
