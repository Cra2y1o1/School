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
    }
}
