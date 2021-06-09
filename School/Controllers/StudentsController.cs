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
        public static List<Classes> classes;
         public ViewResult students()
        {
            WorkWithDB workWithDB = new WorkWithDB();
            peopls = workWithDB.getStudiers();
            if (AccountController.current.level == 1)
            {
                return getFindedChild(null, null, null, null, null);
            }
            return View();
        }
        [HttpPost]
        public ViewResult getFindedChild(string LastName, string FirstName, string Patronymic, string phone, string ClassName) 
        {
            WorkWithDB workWithDB = new WorkWithDB();
            LastName = LastName == null ? "%" : "%" + LastName + "%";
            FirstName = FirstName == null ? "%" : "%" + FirstName + "%";
            Patronymic = Patronymic == null ? "%" : "%" + Patronymic + "%";
            phone = phone == null ? "%" : "%" + phone + "%";
            ClassName = ClassName == null ? "%" : "%" + ClassName + "%";
            if(AccountController.current.level == 1)
            {
                ClassName = AccountController.current.child.ScClass;
            }
            peopls = workWithDB.getStudiers(LastName,FirstName,Patronymic,phone,ClassName);
            return View("students");
        }
        public IActionResult SetClass()
        {
            if (!(AccountController.current.level > 5)) return Redirect("/Home/error403");

            WorkWithDB db = new WorkWithDB();
            classes = db.getClassses();
            peopls = db.getStudiers();
            return View();
        }
        public ViewResult updateClass(string id, string idClass)
        {
            WorkWithDB db = new WorkWithDB();
            db.updateClass(id, idClass);
            peopls = db.getStudiers();
            return View("SetClass");
        }
    }
}
