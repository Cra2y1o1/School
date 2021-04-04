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
                return View("Error");
            }
            
            
        }
    }
}
