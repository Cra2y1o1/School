using Microsoft.AspNetCore.Mvc;
using School.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Controllers
{
    public class EmployerController : Controller
    {
        public static List<Person> Employers;
        public ViewResult Show()
        {
            WorkWithDB db = new WorkWithDB();
            Employers = db.getEmployers("%", "%", "%", "%", "%", "%");
            return View();
        }
        public ViewResult getEmployers(string id,string LastName, string FirstName, string Patronymic, string phone, string FullPosition)
        {
            id = id == null ? "%" : id;
            LastName = LastName == null ? "%" : "%" + LastName + "%";
            FirstName = FirstName == null ? "%" : "%" + FirstName+ "%";
            Patronymic = Patronymic == null ? "%" : "%" + Patronymic + "%";
            phone = phone == null ? "%" : "%"+ phone + "%";
            FullPosition = FullPosition == null ? "%" : "%"+FullPosition+"%";
            WorkWithDB db = new WorkWithDB();
            Employers = db.getEmployers(id,FirstName,LastName,Patronymic,phone,FullPosition);
            return View("Show");
        }

    }
}
