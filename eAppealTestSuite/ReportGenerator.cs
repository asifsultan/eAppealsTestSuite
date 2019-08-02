﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAppealTestSuite
{
    class ReportGenerator
    {
        static string filePath = "C://template.xlsx";
        internal static void GenerateXLS(Dictionary<int, string> testResult, Dictionary<int, string> errorMessage, bool status)
        {
            var xlApp = new
            Microsoft.Office.Interop.Excel.Application();
            var xlWorkBook = xlApp.Workbooks.Add(filePath);


            var xlWorkSheet = xlWorkBook.Worksheets.get_Item(5);
            foreach (var item in testResult)
            {
                xlWorkSheet.Cells[item.Key + 1, 1] = item.Value.ToString();

            }
            foreach (var item in errorMessage)
            {
                xlWorkSheet.Cells[item.Key + 1, 2] = item.Value.ToString();

            }

            var fileName = DateTime.Now.ToString("MMMM dd yyyy HH mm") + ".xlsx";
            xlWorkBook.SaveAs(fileName);

            xlWorkBook.Close(true);
        }
    }
}

