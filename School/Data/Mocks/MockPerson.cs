using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School.Controllers;
using School.Data.interfaces;
using School.Data.Models;
 
namespace School.Data.Mocks
{
    public class MockPerson : IAllPersons
    {
        public IEnumerable<Person> Persons
        {
            get
            {
                WorkWithDB workWithDB = new WorkWithDB();
                return workWithDB.getActualDB();
                
            }
             
        }

        
        public Person getPerson(int id)
        {
            throw new NotImplementedException();
        }
    }
}
