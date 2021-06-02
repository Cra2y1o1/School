using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Controllers
{
    public class HomeController : Controller
    {
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



            return View();
        }
    }
}
