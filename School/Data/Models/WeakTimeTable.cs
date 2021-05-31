using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Data.Models
{
    public class WeakTimeTable
    {
        public List<TimeTablemodel> monday;
        public List<TimeTablemodel> tuesday;
        public List<TimeTablemodel> wednesday;
        public List<TimeTablemodel> thursday;
        public List<TimeTablemodel> friday;
        public List<TimeTablemodel> saturday;
        public WeakTimeTable()
        {
            monday = new List<TimeTablemodel>();
            tuesday = new List<TimeTablemodel>();
            wednesday = new List<TimeTablemodel>();
            thursday = new List<TimeTablemodel>();
            friday = new List<TimeTablemodel>();
            saturday = new List<TimeTablemodel>();
        }
        public void AddPerDay(TimeTablemodel day)
        {

        }
    }
}
