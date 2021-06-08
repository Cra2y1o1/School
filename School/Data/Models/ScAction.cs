using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Data.Models
{
    public class ScAction
    {
        public int id { set; get; }
        public string name { set; get; }
        public string place { set; get; }
        public DateTime dateTime { set; get; }
        public DateTime length { set; get; }
        public List<Person> persons { set; get; }
        public ScAction()
        {
            id = -1;
            name = "";
            place = "";
            dateTime = new DateTime();
            length = new DateTime();
            persons = new List<Person>();
        }
    }
}
