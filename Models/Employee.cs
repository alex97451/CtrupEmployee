using System;
using System.Collections.Generic;

namespace CtrlUpEmploye.Models
{
	public class Employee
	{
        public int ID { get; set; }
        public string? LastName { get; set; }
        public string? FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}

