
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Data.interfaces;
using School.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace School.Controllers
{
    public class AccountController : Controller
    {
        private static Person newPerson;
        public static Person current;
        public static int id;
        private string CreatePassword()
        {
            int[] arr = new int[16]; // сделаем длину пароля в 16 символов
            Random rnd = new Random();
            string Password = "";
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(48, 122);
                if (arr[i] == 96) arr[i]++;
                if (arr[i] == 60) 
                    arr[i]++;
                Password += (char)arr[i];
            }
            return Password;
        }

        public ViewResult LogIn()
        {

            return View();
        }
        public ViewResult LogOut()
        {
            id = -1;
            current = null;
            return View("LogIn");
        }
        [HttpPost]
        public ActionResult Verify(string username, string password)
        {
            WorkWithDB db = new WorkWithDB();
            Person p = db.getVerifyResult(username, password);
            if (p.level > 0)
            {
                id = p.id;
                p = db.getFullInformation(id);
                current = p;

                string line = "";
                using(WebClient wc = new WebClient())
                {
                    line = wc.DownloadString($@"http://ip-api.com/xml/");
                }
                Match match = Regex.Match(line, @"<regionName>(.*?)</regionName>");
                string region = match.Groups[1].Value;
                if(!region.Contains("Vitebsk"))
                {
                    if (!p.email.Equals(""))
                    {
                        match = Regex.Match(line, @"<query>(.*?)</query>");
                        string ip = match.Groups[1].Value;
                        match = Regex.Match(line, @"<city>(.*?)</city>");
                        string city = match.Groups[1].Value;
                        match = Regex.Match(line, @"<isp>(.*?)</isp>");
                        string provider = match.Groups[1].Value;
                        mailbot.send(p.email, "Вход с необычного местоположения", "" +
                            "<h2>Вход в аккаунт был воспроизведен с необычного местоположения</h2>" +
                            $"<p>Вход был произведен с ip адреса <b>{ip}</b></p>" +
                            $"<p>Регион: <b>{region}</b></p>" +
                            $"<p>Город: <b>{city}</b></p>" +
                            $"<p>Провайдер: <b>{provider}</b></p>");
                    }
                }
                return RedirectPermanent("/Client/Index");
            }
            else
            {
                ViewBag.messageWrong = "Совпадения не найдены";
                return View("LogIn");
            }
        }
        
        public ViewResult Remember()
        {
            return View();
        }

        public ViewResult CreateAccount()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult RestorePassword(string username, string secretWord)
        {
            
            WorkWithDB workWithDB = new WorkWithDB();
            string newPass = CreatePassword();
            int id = workWithDB.getIdForRemember(username, secretWord);
            Person currentPerson = workWithDB.getFullInformation(id);
            if (id != -1)
            {
                workWithDB.UpdatePassword(id, newPass);
                DateTime now = DateTime.Now;
                string text = "<h2>Заявка на новый пароль одобрена!</h2> " +
                    $"<p>Наша система сгененировала вам новый пароль: <pre>{newPass}</pre></p > " +
                    $"<hr><p>Постарайтесь больше не забывать ваш пароль. <i>Совет: храните пароль в специальном приложении для менеджера паролей.</i> </p>" +
                    $"<p>Дата и время генерации пароля: {now.ToString()}</p>" +
                        $"<h3>Если это были не вы срочно обратитесь к разработчику ответив на это письмо</h3>" +
                         $"<hr><p>Дата и время входа: {DateTime.Now.ToString()}</p> ";
                if (currentPerson.email != "")
                {
                    mailbot.send(currentPerson.email, "Восстановление пароля", text);
                    ViewBag.messageRem = $"Ваш новый пароль отправлен на почту {currentPerson.email}";
                }
                else
                    ViewBag.messageRem = $"Ваш новый пароль {newPass} Для большей безопасности заведите почту!";
                }
            else
            {
                ViewBag.messageRem = "Совпадения не найдены";
            }
            return View("Remember");
        }
        public ActionResult verfy1Step(string LastName, string FirstName, string Patronymic)
        {
            newPerson = new Person();
            newPerson.lastName = LastName;
            newPerson.name = FirstName;
            newPerson.patronymic = Patronymic;
            return View("step2");
        }
        public ActionResult verfy2Step(DateTime birthday, string email, string number)
        {
            if(DateTime.Now.Year - birthday.Year < 6)
            {
                ViewBag.messageWrong = "Ваш возраст слишком мал для регистрации на данном сервисе!";
                return View("step2");
            }
            newPerson.birthday = birthday.Day + "." + birthday.Month + "." + birthday.Year;
            newPerson.email = email;
            if(!number.Contains("(29)")&& !number.Contains("(33)") && !number.Contains("(44)") && !number.Contains("(25)"))
            {
                ViewBag.messageWrong = $"Номер: {number} принадлежит неизвестному оператору";
                return View("step2");
            }
            newPerson.number = number;
            return View("step3");
        }
        public ActionResult verfy3Step(string status, string sex, string SecretWord)
        {
            newPerson.position = status;
            newPerson.sex = sex;
            newPerson.secretWord = SecretWord;
            return View("step4");
        }
        public ActionResult verfy4Step(string username, string password)
        {
            newPerson.username = username;
            newPerson.password = password;
            WorkWithDB workWithDB = new WorkWithDB();
            if (workWithDB.addUser(newPerson))
                return View("final");
            else
            {
                ViewBag.catchStatus = workWithDB.catchStatus;
                return View("Error");
            }
                
        }
    }
}
