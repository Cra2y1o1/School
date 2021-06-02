using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Data.Models
{
    public class ClassRoom
    {
        public int id { set; get; }
        public int number { set; get; }
        public int floor { set; get; }
        public ClassRoom()
        {
            id = -1;
            number = -1;
            floor = -1;
        }
    }
}
