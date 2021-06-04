using Microsoft.AspNetCore.Mvc;
using School.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Controllers
{
    public class MarkController : Controller
    {
        public static List<Mark> marks;
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult show()
        {
            WorkWithDB workWithDB = new WorkWithDB();
            marks = workWithDB.GetMarks("%","%","%","%","%");
            
            return View();
        }
        [HttpPost]
        public ViewResult show(string idClass, string idScObj, string dateMark, string Studier, string Teacher)
        {
            dateMark = HomeController.TranformForSearch(dateMark);
            Studier = HomeController.TranformForSearch(Studier);
            Teacher = HomeController.TranformForSearch(Teacher);
            WorkWithDB workWithDB = new WorkWithDB();
            marks = workWithDB.GetMarks(idClass, idScObj, dateMark, Studier, Teacher);
            return View();
        }
    }
}
