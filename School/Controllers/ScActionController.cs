using Microsoft.AspNetCore.Mvc;
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
        public ViewResult show()
        {
            WorkWithDB workWithDB = new WorkWithDB();
            actions = workWithDB.getActions("%", "%", "%", "%", "%", "%", "%", "%", "%", "%");
            int i = 0;
            CountUniqueActions.Add(0);
            ScAction prev = new ScAction();
            foreach(var a in actions)
            {
                if(a.id.Equals(prev.id) || prev.id == -1)
                {
                    CountUniqueActions[i]++;
                }
                else
                {
                    i++;
                    CountUniqueActions.Add(1);
                }
                prev = a;

            }
            return View();
        }
    }
}
