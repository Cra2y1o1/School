using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Data.Models
{
    public class Child
    {
        public int id;
        public string lastName { set; get; }
        public string name { set; get; }
        public string patronymic { set; get; }
        public string ScClass { set; get; }
        public Child()
        {
            id = -1;
            lastName = "";
            name = "";
            patronymic = "";
            ScClass = "";
        }
    }
}
