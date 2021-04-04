using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
                return new List<Person>
                {
                    new Person{ id = 0, lastName = "Krigin"}
                };
            }
             
        }

        
        public Person getPerson(int id)
        {
            throw new NotImplementedException();
        }
    }
}
