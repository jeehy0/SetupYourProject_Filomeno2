using System.ComponentModel.DataAnnotations;

namespace SetupYourProject_Filomeno.Models
{
    public enum Rank
    { 
        Instructor, AssistantProfessor, AssociateProfessor, Professor 
    }
    public class Instructor
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Enter First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Enter Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Status")]
        [Required(ErrorMessage = "Enter Status")]
        public bool IsTenured { get; set; }
        [Display(Name = "Hiring Date")]
        [Required(ErrorMessage = "Enter Hiring Date")]
        public DateTime HiringDate { get; set; }
        [Display(Name = "Rank")]
        [Required(ErrorMessage = "Enter Rank")]
        public Rank Rank { get; set; }
    }
}
