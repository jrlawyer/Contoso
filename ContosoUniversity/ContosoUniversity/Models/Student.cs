using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //enrollments is a navigation property, a list of enrollments which is tied to a single student.
        public virtual ICollection<Enrollment>Enrollments { get; set; }
    }
}