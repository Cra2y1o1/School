using Microsoft.AspNetCore.Mvc;
using School.Data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Controllers
{
    public class PersonsController : Controller
    {
        private readonly IAllPersons allPersons;

        public PersonsController(IAllPersons allPersons)
        {
            this.allPersons = allPersons; 
        }

        public ViewResult List()
        {
            var persons = allPersons.Persons;
            return View(persons);
        }
    }
}
