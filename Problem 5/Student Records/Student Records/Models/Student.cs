using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student_Records.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RollNumber { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
    }
}