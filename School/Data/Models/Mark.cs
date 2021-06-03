using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Data.Models
{
    public class Mark
    {
        public int id { set; get; }
        public DateTime dateTime { set; get; }
        public ScObj scObj { set; get; }
        public int mark { set; get; }
        public Person Studier { set; get; }
        public Person Teacher { set; get; }
        public Classes ScClass{ set; get; }
        public Mark()
        {
            id = -1;
            dateTime = DateTime.Now;
            scObj = new ScObj();
            mark = -1;
            Studier = new Person();
            Teacher = new Person();
            ScClass = new Classes();
        }
    }
}
