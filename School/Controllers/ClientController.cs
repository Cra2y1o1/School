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
            return View();
        }
        public ViewResult ParentsConnections()
        {
            return View();
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
            }
            catch(Exception ex)
            {
                ViewBag.catchStatus = ex.Message;
            }
            return View("myAccount");
        }
    }
}
