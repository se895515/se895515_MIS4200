using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace se895515_MIS4200.Models
{
    public class CourseDetail
    {
        public int courseDetailID { get; set; }
        public int numberOfStudents { get; set; }
        public string courseProfessor { get; set; }

        // the next two properties link the courseDetail to the student
        public int studentID { get; set; }
        public virtual Student Student { get; set; }

        // the next two properties link the courseDetail to the course
        public int courseID { get; set; }
        public virtual Course Course { get; set; }
    }
}