using CtrlUpEmploye.Models;
using System;
using System.Linq;

namespace CtrlUpEmploye.DAL
{
    public static class DbInitializer
    {
        public static void Initialize(CtrlUpContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Employees.Any())
            {
                return;   // DB has been seeded
            }

            var employees = new Employee[]
            {
             new Employee{FirstMidName="Alexandre",LastName="Ecormier",EnrollmentDate=DateTime.Parse("2022-04-01")},
            new Employee{FirstMidName="Kevin",LastName="Helm-Smith",EnrollmentDate=DateTime.Parse("2020-09-01")},
            new Employee{FirstMidName="Valentin",LastName="Barit",EnrollmentDate=DateTime.Parse("202-09-01")},
            new Employee{FirstMidName="Quentin",LastName="Korti",EnrollmentDate=DateTime.Parse("2021-09-01")},
            new Employee{FirstMidName="Jean",LastName="Dupont",EnrollmentDate=DateTime.Parse("2021-11-01")},
            };
            foreach (Employee e in employees)
            {
                context.Employees.Add(e);
            }
            context.SaveChanges();

            var specialites = new Specialite[]
                {
            new Specialite { SpecialiteID = 1010, Title = "C#", },
            new Specialite { SpecialiteID = 4022, Title = "Java", },
            new Specialite { SpecialiteID = 4041, Title = "Angular", },
            new Specialite { SpecialiteID = 1045, Title = "React", },
            new Specialite { SpecialiteID = 2543, Title = "Ingénieur D'affaire", },
            };
            foreach (Specialite s in specialites)
            {
                context.Specialites.Add(s);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
           new Enrollment{StudentID=1,SpecialiteID=1010,Grade=Grade.INTERMEDIAIRE},
            new Enrollment{StudentID=1,SpecialiteID=4041,Grade=Grade.JUNIOR},
            new Enrollment{StudentID=2,SpecialiteID=1045,Grade=Grade.EXPERT},
            new Enrollment{StudentID=3,SpecialiteID=2543,Grade=Grade.EXPERT},
            new Enrollment{StudentID=4,SpecialiteID=4022,Grade=Grade.INTERMEDIAIRE},
            new Enrollment{StudentID=4,SpecialiteID=1045,Grade=Grade.JUNIOR},
            new Enrollment{StudentID=5,SpecialiteID=4041,Grade=Grade.INTERMEDIAIRE},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}