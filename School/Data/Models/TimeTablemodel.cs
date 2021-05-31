using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Data.Models
{
    public class TimeTablemodel
    {
        public int id { set; get; }
        public int idDay { set; get; }
        public int idtimeObj{ set; get; }
        public string ScClass { set; get; }
        public string ScObj { set; get; }
        public string ClassRoom { set; get; }
        public string LastNameTeacher { set; get; }
        public TimeTablemodel()
        {
            id = -1;
            ScClass = "";
            ScObj = "";
            ClassRoom = "";
            LastNameTeacher = "";
        }
    }
}
