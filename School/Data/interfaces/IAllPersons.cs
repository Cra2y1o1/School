using School.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Data.interfaces
{
    public interface IAllPersons
    {
        IEnumerable<Person> Persons {  get; }

        Person getPerson(int id);
    }
}
