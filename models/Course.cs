using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace DAB2.Data
{
    public class Course
    {
        //[Key] alternativ måde at definere primary key
        public int courseId { get; set; }
        public string name { get; set; }
    }
}
