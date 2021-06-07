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
        public static List<TimeTablemodel> choosedDay; // выбранный день для отображения
        public static List<Classes> classes; //список классов
        public static List<ScObj> scObjs; //список предметов
        public static List<ClassRoom> classRooms;//список кабинетов
        public static List<Person> Teacher;//список учителей
        public static List<Ring> Rings;//список звонков

        public static string dayOfWeak; //выбранный день
        public static string chossedClass; //выбранный класс
        public static int choosedIdScObj; //Выбраный предмет
        public static int choosedIdTeacher; //Выбраный учитель
        public static int choosedClassRoom; //Выбраный кабинет
        public static int choosedidRing; //Выбраный номер урока

        public static Dictionary<string, string> days;

        public IActionResult Index()
        {
            return View();
        }
        public ViewResult TimeTableClasses()
        {
            chossedClass = "1А";
            dayOfWeak = "Понедельник";
            string idClass = "1";
            WorkWithDB db = new WorkWithDB();
            if (AccountController.current.level < 3)
            {
                chossedClass = AccountController.current.child.ScClass;
                idClass = db.getIdBySQL($"Select [Код класса] from Классы  where Название = '{AccountController.current.child.ScClass}'").ToString();
            }
            Rings = db.GetRings();

            choosedDay = new List<TimeTablemodel>();
            classes = db.getClassses();
            choosedDay = db.GetTimeTables("1", idClass, "%", "%", "%", "%");
            return View();
        }
        [HttpPost]
        public ViewResult TimeTableClasses(string idClass, string day)
        {
            WorkWithDB db = new WorkWithDB();
            if (AccountController.current.level < 3)
            {
                idClass = db.getIdBySQL($"Select [Код класса] from Классы  where Название = '{AccountController.current.child.ScClass}'").ToString();
            }
            dayOfWeak = db.getIdBySQL($"Select [название] from Дни  where [Код дня] = '{day}'").ToString();
            chossedClass = db.getIdBySQL($"Select [Название] from Классы where [Код класса] = '{idClass}'").ToString();
            classes = db.getClassses();
            Rings = db.GetRings();
            choosedDay = db.GetTimeTables(day, idClass, "%", "%", "%", "%");
            return View();
        }
        public ViewResult SetUpTimeTable()
        {
            chossedClass = "1А";
            dayOfWeak = "Понедельник";
            string idClass = "1";
            WorkWithDB db = new WorkWithDB();
            scObjs = db.GetScObjs();
            classRooms = db.GetClassRooms();
            Teacher = db.getEmployers("%", "%", "%", "%", "%", "%");
            Rings = db.GetRings();
            if (AccountController.current.level < 3)
            {
                chossedClass = AccountController.current.child.ScClass;
                idClass = db.getIdBySQL($"Select [Код класса] from Классы  where Название = '{AccountController.current.child.ScClass}'").ToString();
            }
            choosedDay = new List<TimeTablemodel>();
            classes = db.getClassses();
            choosedDay = db.GetTimeTables("1", idClass, "%", "%", "%", "%");
            return View();
        }
        [HttpPost]
        public IActionResult SetUpTimeTable(string idClass, string day)
        {
            WorkWithDB db = new WorkWithDB();
            if (AccountController.current.level < 3)
            {
                idClass = db.getIdBySQL($"Select [Код класса] from Классы  where Название = '{AccountController.current.child.ScClass}'").ToString();
            }
            dayOfWeak = db.getIdBySQL($"Select [название] from Дни  where [Код дня] = '{day}'").ToString();
            chossedClass = db.getIdBySQL($"Select [Название] from Классы where [Код класса] = '{idClass}'").ToString();
            classes = db.getClassses();

            choosedDay = db.GetTimeTables(day, idClass, "%", "%", "%", "%");
            return View("SetUpTimeTable");
        }
        [HttpPost]
        public IActionResult toUpdate(int id, int idClass, int Day,int idRing ,int idScObj, int idTeacher, int idClassRoom)
        {
            WorkWithDB workWithDB = new WorkWithDB();
            string result = "Успешно";
            if(id == 0)
            {
                if (!workWithDB.addTimeTable(Day, idRing, idClass, idScObj, idTeacher, idClassRoom))
                    result = "не получилось добавить. Причина: " + workWithDB.catchStatus;
                else
                    result += " добавлено";
            }
            else
            {
                if (!workWithDB.updateTimeTable(id,Day, idRing, idClass, idScObj, idTeacher, idClassRoom))
                    result = "не получилось добавить. Причина: " + workWithDB.catchStatus;
                else
                    result += " изменено";
            }
            return SetUpTimeTable(idClass.ToString(),Day.ToString());
        }
    }
}
