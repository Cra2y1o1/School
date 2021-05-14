using Microsoft.AspNetCore.Mvc;
using School.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Controllers
{
    public class ClientController : Controller
    {
        private int id;
        private static Person thisAccount;
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
        public ViewResult changeFIO(string LastName, string FirstName, string Patronymic)
        {
            thisAccount.lastName = LastName;
            thisAccount.name = FirstName;
            thisAccount.patronymic = Patronymic;
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
