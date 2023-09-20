namespace SetupYourProject_Filomeno.Models
{
    public enum Course
    {
        BSIT, BSCS, BSIS
    }
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateTime { get; set; }
        public DateTime AdmissionDate { get; set; }
        public Course Course { get; set; }
        public double GPA { get; set; }
        public string Email { get; set; }
    }
}
