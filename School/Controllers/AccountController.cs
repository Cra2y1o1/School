using Microsoft.AspNetCore.Mvc;
using School.Data.interfaces;
using School.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Controllers
{
    public class AccountController : Controller
    {
        private string CreatePassword()
        {
            int[] arr = new int[16]; // сделаем длину пароля в 16 символов
            Random rnd = new Random();
            string Password = "";
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(48, 122);
                if (arr[i] == 96) arr[i]++;
                Password += (char)arr[i];
            }
            return Password;
        }

        public ViewResult LogIn()
        {
            return View();
        }
        public ActionResult Verify(string username, string password)
        {
            WorkWithDB db = new WorkWithDB();
            Person p = db.getVerifyResult(username, password);
            if (p.level > 0)
            {
                return View("True");
            }
            else
            {
                ViewBag.messageWrong = "Совпадения не найдены";
                return View("LogIn");
            }
        }
        public ActionResult Remember(string username, string password)
        {
            return View();
        }

        public ActionResult RestorePassword(string username, string secretWord)
        {
            WorkWithDB workWithDB = new WorkWithDB();
            string newPass = CreatePassword();
            int id = workWithDB.getIdForRemember(username, secretWord);
            workWithDB.UpdatePassword(id, newPass);
            Person currentPerson = workWithDB.getFullInformation(id);
            string text = "<h2>Заявка на новыйпароль одобрена!</ h2 > " +
                $"<p>Наша система сгененировала вам новый пароль: {newPass}</ p > " +
                $"<hr><p>Постарайтесь больше не забывать ваш пароль. < i > Совет: храните пароль в специальном приложении для менеджера паролей.</ i ></ p > ";
            mailbot.send(currentPerson.email, "Восстановление пароля", text); 
            return View("Remember");
        }
    }
}
