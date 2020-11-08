
using Microsoft.AspNetCore.Http;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace RetialBusinessApp
{
    public class WriteToExcel
    {
        public static void WriteData(IFormCollection collection)
        {
            String path = Path.Combine(Assembly.GetExecutingAssembly().Location.Replace("bin\\Debug\\netcoreapp3.1\\RetialBusinessApp.dll", ""), "DataBase.xlsx");
           
            FileInfo file = new FileInfo(path);
            using (ExcelPackage excelPackage = new ExcelPackage(file))
            {
                //create an instance of the the first sheet in the loaded file
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets["Sheet1"];
                int currentrow = worksheet.Dimension.Rows+1;          
                              
               int  j = 1;
               
                foreach (var item in collection)
                {
                    worksheet.Cells[currentrow, j].Value = item.Value;
                    j++;
                }
                //save the changes
                excelPackage.Save();
            }
                       

        }
    }
}
