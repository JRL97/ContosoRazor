namespace ContosoRazor.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; } = String.Empty;
        public string FirstName { get; set; } = String.Empty;
        public DateTime EnrollmentDate { get; set; }

        //Navigation Properties
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
