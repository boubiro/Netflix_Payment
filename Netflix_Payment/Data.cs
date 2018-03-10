using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;

namespace Netflix_Payment
{
    
    class Data
    {
        const string FILE = "NetflixGroup.xlsx";
        private Excel.Worksheet exWks;
        private Excel.Workbook exWb;
        private Excel.Application exApp;
        public int OpenExcel()
        {
            exApp = new Excel.Application();
            exWb = exApp.Workbooks.Open("C:\\Users\\Patrick\\Desktop\\NetflixGroup.xlsx");
            exWks = (Excel.Worksheet)exWb.Sheets["Bezahlung"];
            return 0;
        }

        public int WriteExcel()
        {
            return 0;
        }

        public String[] ReadExcel()
        {
            String[] datainRows= null;
            foreach (Excel.ListObject table in exWks.ListObjects)
            {
                Console.WriteLine("Tabelle Gefunden");
                Excel.Range tableRange = table.Range;
                datainRows = new string[tableRange.Rows.Count];

                int i = 0;

                foreach(Excel.Range row in tableRange.Rows)
                {
                    for (int j = 0; j < row.Columns.Count; j++)
                        if (row.Cells[1, j + 1].Value2 != null)
                        {
                            datainRows[i] = datainRows[i] + "_" + row.Cells[1, j + 1].Value2.ToString();
                            
                        }
#if DEBUG
                    Console.WriteLine(datainRows[i]);
#endif
                    i++;
                }

            }
            return datainRows;
        }

        public int CloseExcel()
        {
            exWb.Close();
            exApp.Quit();
            return 0;
        }
    }
}

