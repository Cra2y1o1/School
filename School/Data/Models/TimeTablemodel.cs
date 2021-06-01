using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Data.Models
{
    public class TimeTablemodel
    {
        public int id { set; get; }
        public string Day { set; get; }
        public int idtimeObj { set; get; }
        public string ScClass { set; get; }
        public string ScObj { set; get; }
        public string ClassRoom { set; get; }
        public string LastNameTeacher { set; get; }
        public string start { set; get; }
        public string end { set; get; }
        public string numb {set;get;}
        public TimeTablemodel()
        {
            id = -1;
            Day = "";
            ScClass = "";
            ScObj = "";
            ClassRoom = "";
            LastNameTeacher = "";
            idtimeObj = -1;
            start = "";
            end = "";
            numb = "";
        }
    }
}
