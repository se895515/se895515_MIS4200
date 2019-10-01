using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace se895515_MIS4200.Models
{
    public class Course
    {
        public int courseID { get; set; }
        public string courseName { get; set; }
        public string description { get; set; }
        public DateTime courseDate { get; set; }


        public int studentID { get; set; }
        public virtual Student Student { get; set; }

        public int professorID { get; set; }
        public virtual Professor Professor { get; set; }
    }
}