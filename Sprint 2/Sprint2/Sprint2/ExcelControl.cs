using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Sprint2
{
    class ExcelControl
    {
        public ExcelControl()
        {
            Excel.Application excelAPP = new Excel.Application();
            excelAPP.Visible = true;
            excelAPP.Workbooks.Add();

            Excel._Worksheet mySheet = (Excel.Worksheet) excelAPP.ActiveSheet;
            mySheet.Cells[1, "A"] = "Hallo Welt";

            var workSheet_range = mySheet.get_Range("A1", "B3");
            workSheet_range.Borders[Excel.XlBordersIndex.xlEdgeBottom].Color = ConsoleColor.Green;
        }
    }
}
