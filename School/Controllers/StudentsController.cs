using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School.Data.Models;

namespace School.Controllers
{
    public class StudentsController : Controller
    {
        public static List<Person> peopls;
        public ViewResult students()
        {
            WorkWithDB workWithDB = new WorkWithDB();
            peopls = workWithDB.getStudiers();
            return View();
        }
        [HttpPost]
        
        public ViewResult getFindedChild(string LastName, string FirstName, string Patronymic, string phone, string ClassName) 
        {
            WorkWithDB workWithDB = new WorkWithDB();
            LastName = LastName == null ? "%" : LastName;
            FirstName = FirstName == null ? "%" : FirstName;
            Patronymic = Patronymic == null ? "%" : Patronymic;
            phone = phone == null ? "%" : phone;
            ClassName = ClassName == null ? "%" : ClassName;
            peopls = workWithDB.getStudiers(LastName,FirstName,Patronymic,phone,ClassName);
            return View("students");
        }
        public ViewResult SetClass()
        {
            return View();
        }
    }
}
