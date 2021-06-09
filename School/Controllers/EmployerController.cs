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
        public static List<Position> Positions;
        public ViewResult Show()
        {
            WorkWithDB db = new WorkWithDB();
            Employers = db.getEmployers("%", "%", "%", "%", "%", "%");

            return View();
        }
        
        public IActionResult getEmployers(string id,string LastName, string FirstName, string Patronymic, string phone, string FullPosition)
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

        public IActionResult UpdatePosition()
        {
            if (!(AccountController.current.level > 5)) return Redirect("/Home/error403");
            WorkWithDB db = new WorkWithDB();
            Positions = db.GetPositions();
            Employers = db.getEmployers("%", "%", "%", "%", "%", "%");
            return View();
        }
        public IActionResult getEmployers2(string id, string LastName, string FirstName, string Patronymic, string phone, string FullPosition)
        {
            id = id == null ? "%" : id;
            LastName = LastName == null ? "%" : "%" + LastName + "%";
            FirstName = FirstName == null ? "%" : "%" + FirstName + "%";
            Patronymic = Patronymic == null ? "%" : "%" + Patronymic + "%";
            phone = phone == null ? "%" : "%" + phone + "%";
            FullPosition = FullPosition == null ? "%" : "%" + FullPosition + "%";
            WorkWithDB db = new WorkWithDB();
            Employers = db.getEmployers(id, FirstName, LastName, Patronymic, phone, FullPosition);
            return View("UpdatePosition");
        }
        [HttpPost]
        public IActionResult UpdatePosition(string id, string idPosition, string position, string level)
        {
            WorkWithDB db = new WorkWithDB();
            db.updatePosition(id, position, idPosition);
            if(AccountController.current.level == 7 && level != null)
            {
                db.updateLevel(id, level);
            }
            ViewBag.message = db.catchStatus;
            Employers = db.getEmployers("%", "%", "%", "%", "%", "%");
            return View();
        }
    }
}
