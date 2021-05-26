using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Data.Models
{
    public class Classes
    {
        public int idClass { set; get; }
        public string Name { set; get; }

        public Classes()
        {
            idClass = 0;
            Name = "Неустановлен";
        }
    }
}
