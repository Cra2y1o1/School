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
        private Person thisAccount;
        public ViewResult Index()
        {
            this.id = AccountController.id;
            WorkWithDB workWithDB = new WorkWithDB();
            thisAccount = workWithDB.getFullInformation(id);
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
    }
}
