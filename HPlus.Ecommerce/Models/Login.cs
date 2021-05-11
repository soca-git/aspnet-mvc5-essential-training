using HPlus.Ecommerce.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HPlus.Ecommerce.Models
{
    public class Login
    {
        // Of course, custom annotations can be created aswell.
        // This is done by extending the DataAnnotations.ValidationAttribute class.
        // Data validation annotations include default parameters.
        [Required]
        // You can include custom arguments in the data validation annotations.
        [EmailAddress(ErrorMessage = "Usernames must be valid email addresses!")]
        public string Username { get; set; }
        [Required]
        [MinLength(8)]
        [CommonPasswords(ErrorMessage = "This password is too common!")]
        public string Password { get; set; }
    }
}