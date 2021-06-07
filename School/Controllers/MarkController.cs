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
        public static string asnwer;
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
        public IActionResult likeToChanche()
        {
            WorkWithDocs doc = new WorkWithDocs();
            return null;
        }
        public IActionResult addMark(string idStudier, string idScObj, int mark, DateTime dateMark)
        {
            string date = dateMark.ToString("dd.MM.yyyy");
            WorkWithDB workWithDB = new WorkWithDB();
            workWithDB.addMark(idStudier, idScObj, AccountController.current.id.ToString(), mark, date);
            Person studier = workWithDB.getFullInformation(Convert.ToInt32(idStudier));
            Classes clas = workWithDB.getClassobj(studier.id);
            studier.child.ScClass = clas.Name;
            ViewBag.Answer = $"Выставлено {mark} учащемуся: {studier.lastName} {studier.name} из {studier.child.ScClass} класса";
            return View("show");
        }
        public ViewResult Editor()
        {
            WorkWithDB workWithDB = new WorkWithDB();
            marks = workWithDB.GetMarks("%", "%", "%", "%", "%");
            return View();
        }
        public IActionResult updateMark(int idMark, int mark)
        {
            WorkWithDB workWithDB = new WorkWithDB();
            if (workWithDB.updateMark(idMark, mark))
                asnwer = "Оценка изменена";
            else
                asnwer = "Не могу изменить оценку";
            return Redirect("/Mark/Editor#popup1");
        }
        public IActionResult deleteMark(string idMark)
        {
            WorkWithDB workWithDB = new WorkWithDB();
            if (workWithDB.deleteFromJournal(idMark, "%", "%", "%", "%"))
                asnwer = "Удалено";
            else
                asnwer = "Не могу удалить";
            return Redirect("/Mark/Editor#popup1");
        }
    }
}
