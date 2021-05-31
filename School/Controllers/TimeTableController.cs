using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School.Data.Models;

namespace School.Controllers
{
    public class TimeTableController : Controller
    {
        public static List<TimeTablemodel> choosedClass;
        
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult TimeTableClasses()
        {

            return View();
        }
    }
}
