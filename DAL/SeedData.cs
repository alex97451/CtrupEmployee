using Microsoft.EntityFrameworkCore;
using CtrlUpEmploye.DAL;
using CtrlUpEmploye.Models;

namespace CtrlUpEmploye.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CtrlUpContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CtrlUpContext>>()))
            {
                if (context == null || context.Employees == null || context.Enrollments == null || context.Specialites == null)
                {
                    throw new ArgumentNullException("No Context available");
                }

                // Look for any movies.
                if (context.Employees.Any())
                {
                    return;   // DB has been seeded
                }

                context.Employees.AddRange(
            new Employee { FirstMidName = "Alexandre", LastName = "Ecormier", EnrollmentDate = DateTime.Parse("2022-04-01") },
            new Employee { FirstMidName = "Kevin", LastName = "Helm-Smith", EnrollmentDate = DateTime.Parse("2020-09-01") },
            new Employee { FirstMidName = "Valentin", LastName = "Barit", EnrollmentDate = DateTime.Parse("202-09-01") },
            new Employee { FirstMidName = "Quentin", LastName = "Korti", EnrollmentDate = DateTime.Parse("2021-09-01") },
            new Employee { FirstMidName = "Jean", LastName = "Dupont", EnrollmentDate = DateTime.Parse("2021-11-01") }
                );
                context.SaveChanges();

                context.Specialites.AddRange(
            new Specialite { SpecialiteID = 1010, Title = "C#", },
            new Specialite { SpecialiteID = 4022, Title = "Java", },
            new Specialite { SpecialiteID = 4041, Title = "Angular", },
            new Specialite { SpecialiteID = 1045, Title = "React", },
            new Specialite { SpecialiteID = 2543, Title = "Ingénieur D'affaire", }

              );
                context.SaveChanges();

                context.Enrollments.AddRange(
                new Enrollment { StudentID = 1, SpecialiteID = 1010, Grade = Grade.INTERMEDIAIRE },
            new Enrollment { StudentID = 1, SpecialiteID = 4041, Grade = Grade.JUNIOR },
            new Enrollment { StudentID = 2, SpecialiteID = 1045, Grade = Grade.EXPERT },
            new Enrollment { StudentID = 3, SpecialiteID = 2543, Grade = Grade.EXPERT },
            new Enrollment { StudentID = 4, SpecialiteID = 4022, Grade = Grade.INTERMEDIAIRE },
            new Enrollment { StudentID = 4, SpecialiteID = 1045, Grade = Grade.JUNIOR },
            new Enrollment { StudentID = 5, SpecialiteID = 4041, Grade = Grade.INTERMEDIAIRE }

                  );


            }
        }
    }
}