using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnotherProject.Models
{
    public class NStudent
    {
        public int nstudentID { get; set; }
        public string lastname { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }


        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}