﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace SetupYourProject_Filomeno.Models
{
    public class RegisterViewModel
    {
        [Display(Name = "User Name")]
        [Required(ErrorMessage = "a username is required")]
        public string? UserName { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "a password is required")]
        public string? Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "you must confirm your password")]
        public string? ConfirmPassword { get; set; }

        [Display(Name = "First Name")]
        public string? FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "email address is required")]
        public string? Email { get; set; }

        // [RegularExpression("[0-9{3} - [0-9]{3} - [0-9]{4}", ErrorMessage = "you must follow the format 000-000-0000!")]
        [Display(Name = "Phone Number")]
        public string? Phone { get; set; }
    }
}
