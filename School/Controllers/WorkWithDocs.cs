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
        public IActionResult CreateStatementsChange(string docName, Person person) {
            byte[] fileContent;
            // If you are a commercial business and have
            // purchased commercial licenses use the static property
            // LicenseContext of the ExcelPackage class:
            ExcelPackage.LicenseContext = LicenseContext.Commercial;

            // If you use EPPlus in a noncommercial context
            // according to the Polyform Noncommercial license:
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(new FileInfo(docName + ".xlsx")))
            {

                var workSheet = package.Workbook.Worksheets.Add("Documet");
                workSheet.Cells["A1:J40"].Style.Font.Size = 14;
                workSheet.Cells["A1:J40"].Style.Font.Name = "Times New Roman";
                #region head

                workSheet.Cells["D1:J1"].Merge = true;
                workSheet.Cells["D1:J1"].Value = "Инженеру-программисту";
                workSheet.Cells["D1:J1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;



                workSheet.Cells["E2:J2"].Merge = true;
                workSheet.Cells["E2:J2"].Value = "Кригину Кириллу Андреевичу";
                workSheet.Cells["E2:J2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;

                workSheet.Cells["B2:C2"].Merge = true;
                workSheet.Cells["B2:C2"].Value = $"{DateTime.Now.ToString("dd.MM.yyyy")}";
                workSheet.Cells["B2:C2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;


                workSheet.Cells["B3:J3"].Merge = true;
                workSheet.Cells["B3:J3"].Value = $"От {person.lastName} {person.name}";
                workSheet.Cells["B3:J3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                #endregion

                #region body
                workSheet.Cells["B12:J12"].Merge = true;
                workSheet.Cells["B12:J12"].Value = "Заявление";
                workSheet.Cells["B12:J12"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                workSheet.Cells["B14:J22"].Merge = true;
                workSheet.Cells["B14:J22"].Value = $"Я {person.lastName} {person.name} {person.patronymic} (id: {person.id})," +
                    $" прошу изменить данные в web-приложении для ораганизации работы " +
                    $"\"Cредней школы №1 г. Полоцка\" " +
                    $"логин  _________________, " +
                    $"должность  ______________________, " +
                    $"пол _________________, " +
                    $"а так же выдать мне соответствующие привелегии. В связи с ________________________________________________________";
                workSheet.Cells["B14:J22"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                workSheet.Cells["B14:J22"].Style.WrapText = true;


                #endregion

                #region footer
                workSheet.Cells["B24:E24"].Merge = true;
                workSheet.Cells["B24:E24"].Value = "Инспектор по кадрам";
                workSheet.Cells["B24:E24"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

                workSheet.Cells["B25:E25"].Merge = true;
                workSheet.Cells["B25:E25"].Value = "О. Н. Кочерягина";
                workSheet.Cells["B25:E25"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

                workSheet.Cells["H25:J25"].Merge = true;
                workSheet.Cells["H25:J25"].Style.Border.Bottom.Style = ExcelBorderStyle.Medium;

                workSheet.Cells["B27:E27"].Merge = true;
                workSheet.Cells["B27:E27"].Value = "Заявитель";
                workSheet.Cells["B27:E27"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

                workSheet.Cells["H28:J28"].Merge = true;
                workSheet.Cells["H28:J28"].Style.Border.Bottom.Style = ExcelBorderStyle.Medium;

                workSheet.Cells["B28:E28"].Merge = true;
                workSheet.Cells["B28:E28"].Value = $"{person.name[0]}. {person.patronymic[0]}. {person.lastName}";
                workSheet.Cells["B28:E28"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

                #endregion
                fileContent = package.GetAsByteArray();
            }

            //Download Word document in the browser
            return File(
                fileContent,
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                docName + ".xlsx");
        }
        public IActionResult ChangePosition(string docName, Person person)
        {
            byte[] fileContent;
            // If you are a commercial business and have
            // purchased commercial licenses use the static property
            // LicenseContext of the ExcelPackage class:
            ExcelPackage.LicenseContext = LicenseContext.Commercial;

            // If you use EPPlus in a noncommercial context
            // according to the Polyform Noncommercial license:
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(new FileInfo(docName + ".xlsx")))
            {

                var workSheet = package.Workbook.Worksheets.Add("Documet");
                workSheet.Cells["A1:J40"].Style.Font.Size = 14;
                workSheet.Cells["A1:J40"].Style.Font.Name = "Times New Roman";
                #region head

                workSheet.Cells["D1:J1"].Merge = true;
                workSheet.Cells["D1:J1"].Value = "Инженеру-программисту";
                workSheet.Cells["D1:J1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;

                

                workSheet.Cells["E2:J2"].Merge = true;
                workSheet.Cells["E2:J2"].Value = "Кригину Кириллу Андреевичу";
                workSheet.Cells["E2:J2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;

                workSheet.Cells["B2:C2"].Merge = true;
                workSheet.Cells["B2:C2"].Value = $"{DateTime.Now.ToString("dd.MM.yyyy")}";
                workSheet.Cells["B2:C2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;


                workSheet.Cells["B3:J3"].Merge = true;
                workSheet.Cells["B3:J3"].Value =  $"От {person.lastName} {person.name}";
                workSheet.Cells["B3:J3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                #endregion

                #region body
                workSheet.Cells["B12:J12"].Merge = true;
                workSheet.Cells["B12:J12"].Value = "Заявление";
                workSheet.Cells["B12:J12"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                workSheet.Cells["B14:J22"].Merge = true;
                workSheet.Cells["B14:J22"].Value = $"Я {person.lastName} {person.name} {person.patronymic} (id: {person.id})," +
                    $" прошу обновить мою должность в web-приложении для ораганизации работы " +
                    $"\"Cредней школы №1 г. Полоцка\" на: \"________________________\", " +
                    $"а так же выдать мне соответствующие привелегии. В связи с ________________________________________________________";
                workSheet.Cells["B14:J22"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                workSheet.Cells["B14:J22"].Style.WrapText = true;


                #endregion

                #region footer
                workSheet.Cells["B24:E24"].Merge = true;
                workSheet.Cells["B24:E24"].Value = "Инспектор по кадрам";
                workSheet.Cells["B24:E24"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

                workSheet.Cells["B25:E25"].Merge = true;
                workSheet.Cells["B25:E25"].Value = "О. Н. Кочерягина";
                workSheet.Cells["B25:E25"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

                workSheet.Cells["H25:J25"].Merge = true;
                workSheet.Cells["H25:J25"].Style.Border.Bottom.Style = ExcelBorderStyle.Medium;

                workSheet.Cells["B27:E27"].Merge = true;
                workSheet.Cells["B27:E27"].Value = "Заявитель";
                workSheet.Cells["B27:E27"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

                workSheet.Cells["H28:J28"].Merge = true;
                workSheet.Cells["H28:J28"].Style.Border.Bottom.Style = ExcelBorderStyle.Medium;

                workSheet.Cells["B28:E28"].Merge = true;
                workSheet.Cells["B28:E28"].Value = $"{person.name[0]}. {person.patronymic[0]}. {person.lastName}";
                workSheet.Cells["B28:E28"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

                #endregion
                fileContent = package.GetAsByteArray();
            }

            //Download Word document in the browser
            return File(
                fileContent, 
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", 
                docName + ".xlsx");
        }
        public IActionResult SetUpClass(string docName, Person person)
        {
            byte[] fileContent;
            // If you are a commercial business and have
            // purchased commercial licenses use the static property
            // LicenseContext of the ExcelPackage class:
            ExcelPackage.LicenseContext = LicenseContext.Commercial;

            // If you use EPPlus in a noncommercial context
            // according to the Polyform Noncommercial license:
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(new FileInfo(docName + ".xlsx")))
            {

                var workSheet = package.Workbook.Worksheets.Add("Documet");
                workSheet.Cells["A1:J40"].Style.Font.Size = 14;
                workSheet.Cells["A1:J40"].Style.Font.Name = "Times New Roman";
                #region head

                workSheet.Cells["D1:J1"].Merge = true;
                workSheet.Cells["D1:J1"].Value = "Инженеру-программисту";
                workSheet.Cells["D1:J1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;



                workSheet.Cells["E2:J2"].Merge = true;
                workSheet.Cells["E2:J2"].Value = "Кригину Кириллу Андреевичу";
                workSheet.Cells["E2:J2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;

                workSheet.Cells["B2:C2"].Merge = true;
                workSheet.Cells["B2:C2"].Value = $"{DateTime.Now.ToString("dd.MM.yyyy")}";
                workSheet.Cells["B2:C2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;


                workSheet.Cells["B3:J3"].Merge = true;
                workSheet.Cells["B3:J3"].Value = $"От {person.lastName} {person.name}";
                workSheet.Cells["B3:J3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                #endregion

                #region body
                workSheet.Cells["B12:J12"].Merge = true;
                workSheet.Cells["B12:J12"].Value = "Заявление";
                workSheet.Cells["B12:J12"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                workSheet.Cells["B14:J22"].Merge = true;
                workSheet.Cells["B14:J22"].Value = $"Я {person.lastName} {person.name} {person.patronymic} (id: {person.id})," +
                    $" прошу установить мне класс _____" +
                    $" в web-приложении для ораганизации работы " +
                    $"\"Cредней школы №1 г. Полоцка\"" +
                    $" В связи с ________________________________________________________";
                workSheet.Cells["B14:J22"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                workSheet.Cells["B14:J22"].Style.WrapText = true;


                #endregion

                #region footer

                workSheet.Cells["B24:E24"].Merge = true;
                workSheet.Cells["B24:E24"].Value = "Классный руководитель";
                workSheet.Cells["B24:E24"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

                workSheet.Cells["B25:E25"].Merge = true;
                workSheet.Cells["B25:E25"].Style.Border.Bottom.Style = ExcelBorderStyle.Medium;

                workSheet.Cells["B26:E26"].Merge = true;
                workSheet.Cells["B26:E26"].Value = "(ФИО)";
                workSheet.Cells["B26:E26"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                workSheet.Cells["B26:E26"].Style.VerticalAlignment = ExcelVerticalAlignment.Top;
                workSheet.Cells["B26:E26"].Style.Font.Size = 8;

                workSheet.Cells["H25:J25"].Merge = true;
                workSheet.Cells["H25:J25"].Style.Border.Bottom.Style = ExcelBorderStyle.Medium;

                workSheet.Cells["B27:E27"].Merge = true;
                workSheet.Cells["B27:E27"].Value = "Заявитель";
                workSheet.Cells["B27:E27"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

                workSheet.Cells["H28:J28"].Merge = true;
                workSheet.Cells["H28:J28"].Style.Border.Bottom.Style = ExcelBorderStyle.Medium;

                workSheet.Cells["B28:E28"].Merge = true;
                workSheet.Cells["B28:E28"].Value = $"{person.name[0]}. {person.patronymic[0]}. {person.lastName}";
                workSheet.Cells["B28:E28"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

                #endregion
                fileContent = package.GetAsByteArray();
            }

            //Download Word document in the browser
            return File(
                fileContent,
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                docName + ".xlsx");
        }
        public IActionResult setUpParentsChild(string docName, Person person)
        {
            byte[] fileContent;
            // If you are a commercial business and have
            // purchased commercial licenses use the static property
            // LicenseContext of the ExcelPackage class:
            ExcelPackage.LicenseContext = LicenseContext.Commercial;

            // If you use EPPlus in a noncommercial context
            // according to the Polyform Noncommercial license:
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(new FileInfo(docName + ".xlsx")))
            {

                var workSheet = package.Workbook.Worksheets.Add("Documet");
                workSheet.Cells["A1:J40"].Style.Font.Size = 14;
                workSheet.Cells["A1:J40"].Style.Font.Name = "Times New Roman";
                #region head

                workSheet.Cells["D1:J1"].Merge = true;
                workSheet.Cells["D1:J1"].Value = "Инженеру-программисту";
                workSheet.Cells["D1:J1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;



                workSheet.Cells["E2:J2"].Merge = true;
                workSheet.Cells["E2:J2"].Value = "Кригину Кириллу Андреевичу";
                workSheet.Cells["E2:J2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;

                workSheet.Cells["B2:C2"].Merge = true;
                workSheet.Cells["B2:C2"].Value = $"{DateTime.Now.ToString("dd.MM.yyyy")}";
                workSheet.Cells["B2:C2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;


                workSheet.Cells["B3:J3"].Merge = true;
                workSheet.Cells["B3:J3"].Value = $"От {person.lastName} {person.name}";
                workSheet.Cells["B3:J3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                #endregion

                #region body
                workSheet.Cells["B12:J12"].Merge = true;
                workSheet.Cells["B12:J12"].Value = "Заявление";
                workSheet.Cells["B12:J12"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                workSheet.Cells["B14:J22"].Merge = true;
                workSheet.Cells["B14:J22"].Value = $"Я {person.lastName} {person.name} {person.patronymic} (id: {person.id})," +
                    $" прошу установить связь между мной и моим ребенком" +
                    $" в web-приложении для ораганизации работы " +
                    $"\"Cредней школы №1 г. Полоцка\" " +
                    $"ФИО ребенка: __________________________________________, Класс ребенка ______ " +
                    $" В связи с ________________________________________________________";
                workSheet.Cells["B14:J22"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                workSheet.Cells["B14:J22"].Style.WrapText = true;


                #endregion

                #region footer
                workSheet.Cells["B24:E24"].Merge = true;
                workSheet.Cells["B24:E24"].Value = "Классный руководитель";
                workSheet.Cells["B24:E24"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

                workSheet.Cells["B25:E25"].Merge = true;
                workSheet.Cells["B25:E25"].Style.Border.Bottom.Style = ExcelBorderStyle.Medium;

                workSheet.Cells["B26:E26"].Merge = true;
                workSheet.Cells["B26:E26"].Value = "(ФИО)";
                workSheet.Cells["B26:E26"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                workSheet.Cells["B26:E26"].Style.VerticalAlignment = ExcelVerticalAlignment.Top;
                workSheet.Cells["B26:E26"].Style.Font.Size = 8;


                workSheet.Cells["H25:J25"].Merge = true;
                workSheet.Cells["H25:J25"].Style.Border.Bottom.Style = ExcelBorderStyle.Medium;

                workSheet.Cells["B27:E27"].Merge = true;
                workSheet.Cells["B27:E27"].Value = "Заявитель";
                workSheet.Cells["B27:E27"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

                workSheet.Cells["H28:J28"].Merge = true;
                workSheet.Cells["H28:J28"].Style.Border.Bottom.Style = ExcelBorderStyle.Medium;

                workSheet.Cells["B28:E28"].Merge = true;
                workSheet.Cells["B28:E28"].Value = $"{person.name[0]}. {person.patronymic[0]}. {person.lastName}";
                workSheet.Cells["B28:E28"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

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
