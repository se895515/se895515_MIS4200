﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace se895515_MIS4200.Models
{
    public class Student
    {
        public int studentID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }


        // add any other fields as appropriate
        // a customer can have any number of orders, a 1:M relationship,
        // We represent this in the model with an ICollection
        // The syntax says we are creating an ICollection of Order objects,
        // (the name inside the <> is the object name),
        // and the local name of the collection will be Order
        // (the object name and the local name do not have to be the same)
        public ICollection<Course> Course { get; set; }

    }
}