using CtrlUpEmploye.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CtrlUpEmploye.DAL
{
	public class CtrlUpContext : DbContext
	{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public CtrlUpContext(DbContextOptions<CtrlUpContext> options) : base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
		}
		
		

		public DbSet<Employee> Employees { get; set; }
		public DbSet<Enrollment> Enrollments { get; set; }
		public DbSet<Specialite> Specialites { get; set; }

		

	}
}

