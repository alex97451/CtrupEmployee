using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CtrlUpEmploye.Models
{
	public class Specialite
	{

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SpecialiteID { get; set; }
        public string? Title { get; set; }
        

        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}

