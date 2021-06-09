﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School.Data.Models;

namespace School.Controllers
{
    public class ScActionController : Controller
    {
        public static List<ScAction> actions;
        public static List<int> CountUniqueActions;
        public ScActionController()
        {
            actions = new List<ScAction>();
            CountUniqueActions = new List<int>();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult show()
        {
            
            WorkWithDB workWithDB = new WorkWithDB();
            actions = workWithDB.getActions("%", "%", "%", "%", "%", "%");
            
            return View();
        }
        [HttpPost]
        public ViewResult show(string ActionName, string ActionPlace, string ActionDate, string MemberLname, string MemberPosition, string MemberRole)
        {
            WorkWithDB workWithDB = new WorkWithDB();
            actions = workWithDB.getActions(HomeController.TranformForSearch(ActionName),HomeController.TranformForSearch(ActionPlace), HomeController.TranformForSearch(ActionDate),
                HomeController.TranformForSearch(MemberLname), HomeController.TranformForSearch(MemberPosition), HomeController.TranformForSearch(MemberRole));
            List<ScAction> RealAction = new List<ScAction>();
            foreach(var a in actions)
            {
                if (a.persons.Count > 0) RealAction.Add(a);
            }
            actions = RealAction;
            return View();
        }
    }
}
