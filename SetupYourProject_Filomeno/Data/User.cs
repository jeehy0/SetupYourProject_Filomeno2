using Microsoft.AspNetCore.Identity;

namespace SetupYourProject_Filomeno.Data
{
    public class User : IdentityUser
    {
        public string? FirstName {  get; set; }
        public string? LastName { get; set;}
    }
}
