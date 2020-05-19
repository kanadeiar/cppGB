using System;

using Excel = Microsoft.Office.Interop.Excel;
namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = excelApp.ActiveSheet;
            worksheet.Cells[1, "A"] = "Fam";
            worksheet.Cells[2, "B"] = "Name";
            worksheet.Cells[3, "C"] = "Age";
            for (int i = 0; i <= 5; i++)
            {
                worksheet.Cells[i + 1, "A"] = $"Фамилия{i}";
                worksheet.Cells[i + 1, "B"] = $"{i}-е имя";
                worksheet.Cells[i + 1, "C"] = 18 + i;
            }
            worksheet.Range["A1"].AutoFormat(Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic2);
            excelApp.Visible = true;
            worksheet.SaveAs($@"{Environment.CurrentDirectory}\Test.xlsx");
            //excelApp.Quit();
            Console.ReadLine();
        }
    }
}
