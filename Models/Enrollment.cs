using System;
namespace CtrlUpEmploye.Models
{

        public enum Grade
        {
            JUNIOR, INTERMEDIAIRE , EXPERT
        }

        public class Enrollment
        {
            public int EnrollmentID { get; set; }
            public int SpecialiteID { get; set; }
            public int StudentID { get; set; }
            public Grade? Grade { get; set; }

            public Specialite? Specialite { get; set; }
            public Employee? Employee { get; set; }
        }
    
}

