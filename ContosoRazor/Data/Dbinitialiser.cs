using ContosoRazor.Models;

namespace ContosoRazor.Data
{
    public class Dbinitialiser
    {
        public static class DbInitialiser
        {
            public static void Initialise(ApplicationDbContext context)
            {
                // Look for any students.
                if (context.Students.Any())
                {
                    return;   // DB has been seeded
                }

                var students = new Student[]
                {
                new Student{FirstName="Jessica",LastName="Leach",EnrollmentDate=DateTime.Parse("2019-09-01")},
                new Student{FirstName="Alastair",LastName="Fox",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="William",LastName="Deeley",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Student{FirstName="Tom",LastName="Shirley",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Bethany",LastName="Kyffin",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Sarah",LastName="James",EnrollmentDate=DateTime.Parse("2016-09-01")},
                new Student{FirstName="Delilah",LastName="Soapman",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Student{FirstName="Charlie",LastName="Oliver",EnrollmentDate=DateTime.Parse("2019-09-01")}
                };

                context.Students.AddRange(students);
                context.SaveChanges();

                var Modules = new Module[]
                {
                new Module{Title="Web Applications",Credits=3},
                new Module{Title="Networking Systems",Credits=3},
                new Module{Title="Object-Oriented Systems Development",Credits=3},
                new Module{Title="Database Design",Credits=4},
                new Module{Title="Open Source Systems",Credits=4},
                new Module{Title="Introduction to Intelligent Systmes",Credits=3},
                new Module{Title="Software Engineering",Credits=4}
                };

                context.Modules.AddRange(Modules);
                context.SaveChanges();

                var enrollments = new Enrollment[]
                {
                new Enrollment{StudentID=1,ModuleID=1,Grade=Grade.A},
                new Enrollment{StudentID=1,ModuleID=2,Grade=Grade.C},
                new Enrollment{StudentID=1,ModuleID=3,Grade=Grade.B},
                new Enrollment{StudentID=2,ModuleID=1,Grade=Grade.B},
                new Enrollment{StudentID=2,ModuleID=2,Grade=Grade.F},
                new Enrollment{StudentID=2,ModuleID=4,Grade=Grade.F},
                new Enrollment{StudentID=3,ModuleID=5},
                new Enrollment{StudentID=4,ModuleID=6},
                new Enrollment{StudentID=4,ModuleID=7,Grade=Grade.F},
                new Enrollment{StudentID=5,ModuleID=3,Grade=Grade.C},
                new Enrollment{StudentID=6,ModuleID=2},
                new Enrollment{StudentID=7,ModuleID=5,Grade=Grade.A},
                };

                context.Enrollments.AddRange(enrollments);
                context.SaveChanges();
            }
        }
    }
}
