using System.ComponentModel.DataAnnotations;

namespace SetupYourProject_Filomeno.Models
{
    public enum Course
    {
        BSIT, BSCS, BSIS
    }
    public class Student
    {
        public int Id { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Enter First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Enter Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Admission Date")]
        [Required(ErrorMessage = "Enter Admission Date")]
        public DateTime AdmissionDate { get; set; }
        [Display(Name = "Course")]
        [Required(ErrorMessage = "Enter Course")]
        public Course Course { get; set; }
        [Display(Name = "GPA")]
        [Required(ErrorMessage = "Enter GPA")]
        public double GPA { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Enter Email")]
        public string Email { get; set; }
    }
}
