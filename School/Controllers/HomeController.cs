using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School.Data.Models;

namespace School.Controllers
{
    public class HomeController : Controller
    {
        public static List<Classes> classes;
        public static List<Ring> rings;
        public static List<ScObj> scObjs;
        public static List<Position> positions;
        public ViewResult Index()
        {
            TimeTableController.days = new Dictionary<string, string>();

            TimeTableController.days.Add("Monday", "Понедельник");
            TimeTableController.days.Add("Tuesday", "Вторник");
            TimeTableController.days.Add("Wednesday", "Среда");
            TimeTableController.days.Add("Thursday", "Четверг");
            TimeTableController.days.Add("Friday", "Пятница");
            TimeTableController.days.Add("Saturday", "Суббота");
            TimeTableController.days.Add("Sunday", "Воскресенье");

            WorkWithDB workWithDB = new WorkWithDB();
            classes = workWithDB.getClassses();
            rings = workWithDB.GetRings();
            scObjs = workWithDB.GetScObjs();
            positions = workWithDB.GetPositions();

            return View();
        }
    }
}
