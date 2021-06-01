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
        public static WeakTimeTable choosedClass;
        public static List<TimeTablemodel> choosedDay;
        public static List<Classes> classes;


        public IActionResult Index()
        {
            return View();
        }
        public ViewResult TimeTableClasses()
        {
            string ScClass = "1А";
            if(AccountController.current.level < 3)
            {
                ScClass = AccountController.current.child.ScClass;
            }
            WorkWithDB db = new WorkWithDB();
            choosedClass = new WeakTimeTable();
            choosedDay = new List<TimeTablemodel>();
            classes = db.getClassses();
            choosedClass.monday = db.GetTimeTables("1", ScClass, "%", "%", "%", "%");
            choosedClass.tuesday = db.GetTimeTables("2", ScClass, "%", "%", "%", "%");
            choosedClass.wednesday = db.GetTimeTables("3", ScClass, "%", "%", "%", "%");
            choosedClass.thursday = db.GetTimeTables("4", ScClass, "%", "%", "%", "%");
            choosedClass.friday = db.GetTimeTables("5", ScClass, "%", "%", "%", "%");
            choosedClass.saturday = db.GetTimeTables("6", ScClass, "%", "%", "%", "%");
            choosedDay = choosedClass.monday;
            return View();
        }
        [HttpPost]
        public ViewResult TimeTableClasses(string ScClass, string day)
        {
            
            
            WorkWithDB db = new WorkWithDB();
            if (AccountController.current.level < 3)
            {
                ScClass = db.getIdBySQL($"Select [Код класса] from Классы  where Название = '{AccountController.current.child.ScClass}'").ToString();

            }
            choosedClass = new WeakTimeTable();
            choosedDay = new List<TimeTablemodel>();
            classes = db.getClassses();

            choosedDay = db.GetTimeTables(day, ScClass, "%", "%", "%", "%");
            return View();
        }
    }
}
