﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Data.Models
{
    public class Position
    {
        public int id { set; get; }
        public string name { set; get; }
        public int level { set; get; }

        public Position()
        {
            id = -1;
            name = "";
            level = -1;
        }

    }
}
