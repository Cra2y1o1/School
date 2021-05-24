using Microsoft.AspNetCore.Mvc;
using School.Data.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using Microsoft.Net.Http.Headers;

namespace School.Controllers
{
    public class ClientController : Controller
    {
        private int id;
        private static Person thisAccount;
        public static List<Person> FindedParents;
        private readonly IHostingEnvironment _environment;

        public ClientController(IHostingEnvironment IHostingEnvironment)
        {
            _environment = IHostingEnvironment;
        }
       
        public ViewResult Index()
        {
            this.id = AccountController.id;
            thisAccount = AccountController.current;
            ViewBag.thisAccount = thisAccount;
            return View();
        }
        public ViewResult Parents()
        {
            WorkWithDB workWithDB = new WorkWithDB();
            FindedParents = workWithDB.getParents();
            return View();
        }
        public ViewResult ParentsConnections()
        {
            WorkWithDB workWithDB = new WorkWithDB();
            FindedParents = workWithDB.getParents();
            return View();
        }
        public ViewResult setConnection(int idParent, int idChild)
        {
            WorkWithDB workWithDB = new WorkWithDB();
            workWithDB.UpdateParentChild(idParent, idChild);
            FindedParents = workWithDB.getParents();
            return View("ParentsConnections");
        }
        public ViewResult getExFindedParent(string LastName, string idParent, string LastNameChild, string idchild)
        {
            LastName = LastName == null ? "%" : LastName;
            idParent = idParent == null ? "%" : idParent;
            LastNameChild = LastNameChild == null ? "%" : LastNameChild;
            idchild = idchild == null ? "%" : idchild;
            WorkWithDB workWithDB = new WorkWithDB();
            FindedParents = workWithDB.getParents(LastName, idParent, LastNameChild, idchild);
            return View("ParentsConnections");
        }
        public ViewResult myAccount()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ChangeInfo(string LastName, string FirstName, string Patronymic, DateTime birthday, IFormFile upload)
        {
            thisAccount.lastName = LastName;
            thisAccount.name = FirstName;
            thisAccount.patronymic = Patronymic;

            if (upload != null)
            {
                string newName = $"avatar{id}";
                // путь к папке Files
                string path = "/avatars/" + newName + Path.GetExtension(upload.FileName);
                // сохраняем файл в папку Files в каталоге wwwroot
                using (var fileStream = new FileStream(_environment.WebRootPath + path, FileMode.Create))
                {
                    await upload.CopyToAsync(fileStream);
                }
                thisAccount.avatar = path;
            }
           
            WorkWithDB workWithDB = new WorkWithDB();
            try
            {
                workWithDB.updateUser(thisAccount);
                if (!AccountController.current.email.Equals(""))
                {
                    string message = "<h2>Изменение персанальных данных прошло успешно!</h2>" +
                        $"<p> Фамилия: <b>{AccountController.current.lastName}</b> </p> " +
                        $"<p> Имя: <b>{AccountController.current.name}</b> </p>" +
                        $"<p> Отчество: <b>{AccountController.current.patronymic}</b> </p>" +
                        $"<p> Дата рождения: <b>{AccountController.current.birthday}</b> </p>" +
                        $"<h3>Если это были не вы срочно обратитесь к разработчику ответив на это письмо</h3>" +
                         $"<hr><p>Дата и время изменений: {DateTime.Now.ToString()}</p> " +
                         $"<p></p>";
                    mailbot.send(AccountController.current.email, "Изменение данных", message);
                }
            }
            catch(Exception ex)
            {
                ViewBag.message = ex.Message == null ? workWithDB.catchStatus : ex.Message;
            }
            return View("myAccount");
        }
        public ViewResult changePassword(string oldpassword, string password)
        {
            string message = "";
            if (AccountController.current.password.Equals(oldpassword))
            {
                try
                {
                    WorkWithDB workWithDB = new WorkWithDB();
                    workWithDB.UpdatePassword(AccountController.current.id, password);
                    ViewBag.message = "Пароль успешно изменен!";
                    AccountController.current.password = password;
                    message = "<h2>Был изменен пароль на вашем аккаунте</h2>" +
                        $"<p> Ваш новый пароль: <b>{password}</b> </p> " +
                        $"<h3>Если это были не вы срочно обратитесь к разработчику ответив на это письмо</h3>" +
                         $"<hr><p>Дата и время изменения пароля: {DateTime.Now.ToString()}</p> " +
                         $"<p></p>";

                }
                catch(Exception ex)
                {
                    ViewBag.message = ex.Message;
                }
                
            }
            else
            {
                message = "<h2>Была неудачная попытка изменения пароля в аккаунте</h2>" +
                       $"<p>Если это были не вы срочно обратитесь к разработчику ответив на это письмо</p>" +
                        $"<hr><p>Дата и время попытки изменения пароля: {DateTime.Now.ToString()}</p>";
                ViewBag.message = "Старый пароль введен не верно!";
            }
            if (!AccountController.current.email.Equals(""))
            {
                mailbot.send(AccountController.current.email, "Изменение пароля", message);
            }
            return View("myAccount");
        }
        public ViewResult changeLogIn(string email, string number, string SecretWord)
        {
            AccountController.current.email = email;
            AccountController.current.number = number;
            AccountController.current.secretWord = SecretWord;
            WorkWithDB work = new WorkWithDB();
            try
            {
                work.updateUser(AccountController.current);
                if (!AccountController.current.email.Equals(""))
                {
                    string message = "<h2>Изменение данных для восстановления пароля прошло успешно!</h2>" +
                        $"<p> E-mail: <b>{AccountController.current.email}</b> </p> " +
                        $"<p> Номер телефона: <b>{AccountController.current.number}</b> </p>" +
                        $"<p> Секретное слово: <b>{AccountController.current.secretWord}</b> </p>" +
                        $"<p> После прочтения данного сообщения пожалуйста удалите его. Тут содержиться очень важная информация</p>" +
                        $"<h3>Если это были не вы срочно обратитесь к разработчику ответив на это письмо</h3>" +
                         $"<hr><p>Дата и время изменений: {DateTime.Now.ToString()}</p> " +
                         $"<p></p>";
                    mailbot.send(AccountController.current.email, "Изменение данных", message);
                }
            }
            catch(Exception e)
            {
                ViewBag.message = e.Message;
            }
            return View("myAccount");
        }
        public ViewResult getFindedParent(string LastName, string FirstName, string Patronymic)
        {
            LastName = LastName == null ? "%" : LastName;
            FirstName = FirstName == null ? "%" : FirstName;
            Patronymic = Patronymic == null ? "%" : Patronymic;
            WorkWithDB workWithDB = new WorkWithDB();
            FindedParents = workWithDB.getParents(LastName, FirstName, Patronymic);
            return View("Parents");
        }
        public IActionResult getStatements()
        {
            WorkWithDocs doc = new WorkWithDocs();
            return doc.CreateStatementsChange(thisAccount.lastName + thisAccount.id +"_"+ DateTime.Now.ToString("dd_mm_yyyy HH:mm"), thisAccount);
        }
        
    }
}
