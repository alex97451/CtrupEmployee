using System;
using System.ComponentModel.DataAnnotations;

namespace CtrlUpEmploye.Models.EmployeeViewModels
{
	public class EnrollmentDate
	{
        [DataType(DataType.Date)]
        public DateTime? EnrollmentDatation { get; set; }

		public int EmployeeCount { get; set; }
	}
}

