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
            marks = workWithDB.GetMarks("%","%","%");
            
            return View();
        }
        public IActionResult getMarks(string idClass, string idScObj, DateTime dateMark, string Studier, string Teacher)
        {

        }
    }
}
