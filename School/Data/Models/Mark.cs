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
        public string ScObj { set; get; }
        public int mark { set; get; }
        public string LastNameStudier { set; get; }
        public string LastNameTeacher { set; get; }
        public string ScClass{ set; get; }
    }
}
