using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using School.Data.Models;

namespace School.Controllers
{
    public class WorkWithDocs : Controller
    {
        
        public IActionResult CreateStatementsChange(string docName, Person person)
        {
            byte[] fileContent;
            using( var package = new ExcelPackage())
            {

                var workSheet = package.Workbook.Worksheets.Add("Documet");
                workSheet.Cells["A1:I40"].Style.Font.Size = 14;
                workSheet.Cells["A1:I40"].Style.Font.Name = "Times New Roman";
                #region head

                workSheet.Cells["D1:I1"].Merge = true;
                workSheet.Cells["D1:I1"].Value = "Инженеру-программисту";
                workSheet.Cells["D1:I1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;

                workSheet.Cells["A1:C1"].Merge = true;
                workSheet.Cells["A1:C1"].Value = "Заявление";
                workSheet.Cells["A1:C1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

                workSheet.Cells["E2:I2"].Merge = true;
                workSheet.Cells["E2:I2"].Value = "Кригину Кириллу Андреевичу";
                workSheet.Cells["E2:I2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;

                workSheet.Cells["A2:C2"].Merge = true;
                workSheet.Cells["A2:C2"].Value = $"{DateTime.Now.ToString("dd.MM.yyyy")}";
                workSheet.Cells["A2:C2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;


                workSheet.Cells["A3:I3"].Merge = true;
                workSheet.Cells["A3:I3"].Value =  $"От {person.lastName} {person.name}";
                workSheet.Cells["A3:I3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                #endregion

                #region body
                workSheet.Cells["A12:I12"].Merge = true;
                workSheet.Cells["A12:I12"].Value = "Заявление";
                workSheet.Cells["A12:I12"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;

                workSheet.Cells["A14:I22"].Merge = true;
                workSheet.Cells["A14:I22"].Value = $"Я {person.lastName} {person.name} {person.patronymic} (id: {person.id})," +
                    $" прошу обновить мою должность в web-приложении для ораганизации работы " +
                    $"\"Cредней школы №1 г. Полоцка\" на: \"________________________\", " +
                    $"а так же выдать мне соответствующие привелегии. В связи с __________________________________________________________________";
                workSheet.Cells["A14:I22"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                workSheet.Cells["A14:I22"].Style.WrapText = true;


                #endregion

                #region footer
                

                workSheet.Cells["A24:D24"].Merge = true;
                workSheet.Cells["A24:D24"].Value = "Директор П.Г. Ястремский";
                workSheet.Cells["A24:D24"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;

                workSheet.Cells["G24:I24"].Merge = true;
                workSheet.Cells["G24:I24"].Style.Border.Bottom.Style = ExcelBorderStyle.Medium;


                #endregion
                fileContent = package.GetAsByteArray();
            }

            //Download Word document in the browser
            return File(
                fileContent, 
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", 
                docName + ".xlsx");
        }

    }
}
