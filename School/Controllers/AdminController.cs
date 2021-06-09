using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using School.Data.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace School.Controllers
{
    public class AdminController : Controller
    {
        public static Person person;
        private readonly IHostingEnvironment _environment;
        public AdminController(IHostingEnvironment IHostingEnvironment)
        {
            _environment = IHostingEnvironment;
        }

        public IActionResult toEdit()
        {
            if (!(AccountController.current.level == 7)) return Redirect("/Home/error403");
            return View();
        }
        [HttpPost]
        public IActionResult editor(int id)
        {
            WorkWithDB workWithDB = new WorkWithDB();
            person = workWithDB.getFullInformation(id);
            return View();
        }
        public async Task<IActionResult> ChangeInfo(string LastName, string FirstName, string Patronymic, DateTime birthday, IFormFile upload)
        {
            person.lastName = LastName;
            person.name = FirstName;
            person.patronymic = Patronymic;

            if (upload != null)
            {
                string newName = $"avatar{person.id}";
                // путь к папке Files
                string path = "/avatars/" + newName + Path.GetExtension(upload.FileName);
                // сохраняем файл в папку Files в каталоге wwwroot
                using (var fileStream = new FileStream(_environment.WebRootPath + path, FileMode.Create))
                {
                    await upload.CopyToAsync(fileStream);
                }
                person.avatar = path;
            }

            WorkWithDB workWithDB = new WorkWithDB();
            try
            {
                workWithDB.updateUser(person);
                if (!person.email.Equals(""))
                {
                    string message = "<h2>Администратор изменил ваши персональные данные!</h2>" +
                        $"<p> Фамилия: <b>{person.lastName}</b> </p> " +
                        $"<p> Имя: <b>{person.name}</b> </p>" +
                        $"<p> Отчество: <b>{person.patronymic}</b> </p>" +
                        $"<p> Дата рождения: <b>{person.birthday}</b> </p>" +
                        $"<h3>Если это ошибка срочно обратитесь к разработчику ответив на это письмо</h3>" +
                         $"<hr><p>Дата и время изменений: {DateTime.Now.ToString()}</p> " +
                         $"<p></p>";
                    mailbot.send(person.email, "Изменение данных", message);
                }
            }
            catch (Exception ex)
            {
                ViewBag.message = ex.Message == null ? workWithDB.catchStatus : ex.Message;
            }
            return View("editor");
        }
        public ViewResult changePassword(string password)
        {
            string message = "";

            try
            {
                WorkWithDB workWithDB = new WorkWithDB();
                workWithDB.UpdatePassword(AccountController.current.id, password);
                ViewBag.message = "Пароль успешно изменен!";
                AccountController.current.password = password;
                message = "<h2>Администратор изменил пароль на вашем аккаунте</h2>" +
                    $"<p> Ваш новый пароль: <b>{password}</b> </p> " +
                    $"<h3>Если это ошибка срочно обратитесь к разработчику ответив на это письмо</h3>" +
                     $"<hr><p>Дата и время изменения пароля: {DateTime.Now.ToString()}</p> " +
                     $"<p></p>";

            }
            catch (Exception ex)
            {
                ViewBag.message = ex.Message;
            }

            if (!person.email.Equals(""))
            {
                mailbot.send(AccountController.current.email, "Изменение пароля", message);
            }
            return View("editor");
        }
        public ViewResult changeLogIn(string email, string number, string SecretWord)
        {
            person.email = email == null ? "" : email;
            person.number = number;
            person.secretWord = SecretWord;
            WorkWithDB work = new WorkWithDB();
            try
            {
                work.updateUser(person);
                if (!person.email.Equals(""))
                {
                    string message = "<h2>Изменение данных для восстановления пароля прошло успешно!</h2>" +
                        $"<p> E-mail: <b>{ person.email}</b> </p> " +
                        $"<p> Номер телефона: <b>{ person.number}</b> </p>" +
                        $"<p> Секретное слово: <b>{ person.secretWord}</b> </p>" +
                        $"<p> После прочтения данного сообщения пожалуйста удалите его. Тут содержиться очень важная информация</p>" +
                        $"<h3>Если это были не вы срочно обратитесь к разработчику ответив на это письмо</h3>" +
                         $"<hr><p>Дата и время изменений: {DateTime.Now.ToString()}</p> " +
                         $"<p></p>";
                    mailbot.send(person.email, "Изменение данных", message);
                }
            }
            catch (Exception e)
            {
                ViewBag.message = e.Message;
            }
            return View("editor");
        }
    }
}
