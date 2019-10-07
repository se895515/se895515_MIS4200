using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace se895515_MIS4200.Models
{
    public class Course
    {
        public int courseID { get; set; }
        [Display(Name = "Course")]
        [Required(ErrorMessage ="Course name is required")]
        [StringLength(50)]
        public string courseName { get; set; }
        [Display(Name = "Course Description")]
        [Required(ErrorMessage = "Course description is required")]
        [StringLength(150)]
        public string description { get; set; }
        [Display(Name = "Date and Time of First Class")]
        [Required]
        public DateTime courseDate { get; set; }


        public int studentID { get; set; }
        public virtual Student Student { get; set; }

        public int professorID { get; set; }
        public virtual Professor Professor { get; set; }
    }
}