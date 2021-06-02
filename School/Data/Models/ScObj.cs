using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Data.Models
{
    public class ScObj
    {
        public int id { set; get; }
        public string name { set; get; }
        public int start { set; get; }
        public int end { set; get; }

        public ScObj()
        {
            id = -1;
            name = "";
            start = -1;
            end = -1;
        }
    }
}
