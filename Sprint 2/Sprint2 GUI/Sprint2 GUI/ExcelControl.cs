using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace Sprint2_GUI
{
    class ExcelControl
    {
        ExcelControl()
        {
            Application excelAPP = new Application();
            excelAPP.Visible = true;
            excelAPP.Workbooks.Add();

        }
    }
}
