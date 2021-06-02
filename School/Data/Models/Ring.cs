using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Data.Models
{
    public class Ring
    {
        public int id { set; get; }
        public int number { set; get; }
        public string start { set; get; }
        public string end { set; get; }
        public Ring()
        {
            id = -1;
            number = -1;
            start = "";
            end = "";
        }
    }
}
