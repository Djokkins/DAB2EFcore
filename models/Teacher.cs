using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DAB2.Data
{ 
    public class Teacher
    {
        public int AuId { get; set; }
        public string name { get; set; }

        public List<Course> Courses { get; set; }
    }
}
