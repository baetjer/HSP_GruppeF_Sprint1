using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2WPF
{
    class ExcelControl
    {
        int input_excel = 0;

        public List<double> getWerte(int sk_auswahl)
        {
            Excel excel = new Excel("filler", sk_auswahl);
            List<double> liste = new List<double>();

            for (int i = 0; i < 4; i++)
            {
                liste.Add(excel.ReadCell(input_excel, i));
            }

            return liste;
        }
    }
}
