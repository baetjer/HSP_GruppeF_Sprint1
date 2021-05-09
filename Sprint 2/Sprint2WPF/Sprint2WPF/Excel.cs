using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace Sprint2WPF
{
    class Excel
    {
        string filename = "DatenbankSchraube.xlsx";
        string path = "";

        Workbook wb;
        Worksheet ws;

        public Excel(string path, int sheet)
        {
            _Application excel = new _Excel.Application();
            excel.Visible = true;

            this.path = path;

            path = System.IO.Path.GetFullPath(filename);

            if (System.IO.File.Exists(path))
            {
                wb = excel.Workbooks.Open(path);
                ws = wb.Worksheets[sheet];
            }
        }

        public double ReadCell(int i, int j)
        {
            i++;
            j++;
            if (ws.Cells[i, j].Value2 != null)
                return ws.Cells[i, j].Value2;
            else
                return 0;
        }
    }
}
