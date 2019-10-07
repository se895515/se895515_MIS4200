using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace se895515_MIS4200.Models
{
    public class Student
    {
        [Display (Name ="Student ID")]
        public int studentID { get; set; }
        [Display (Name="First Name")]
        [Required(ErrorMessage = "Student's first name is required")]
        [StringLength(50)]
        public string firstName { get; set; }
        [Display (Name="Last Name")]
        [Required(ErrorMessage = "Professor's last name is required")]
        [StringLength(50)]
        public string lastName { get; set; }
        [Display (Name ="Email")]
        [Required]
        [EmailAddress(ErrorMessage = "Enter your school email")]
        public string email { get; set; }
        [Display (Name ="Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$", ErrorMessage = "Phone numbers must be in the format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        public string phone { get; set; }


        public ICollection<Course> Course { get; set; }

    }
}