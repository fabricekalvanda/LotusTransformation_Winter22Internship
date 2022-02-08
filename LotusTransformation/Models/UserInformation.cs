using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LotusTransformation.Models
{
    
    public class UserInformation
    {
#nullable enable
        /// <summary>
        /// User Key is auto generated based upon the information provided by the user from the sign-up form. Each key needs to be unique. The key is checked against the database.
        /// If it is duplicated, it will be shifted over to the next available value. In a sense, this is the user's "Account number" and is used as the primary key in the 
        /// database
        /// </summary>
        [Required]
        [Key]
        public long UserID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter your first name")]
        [RegularExpression("^((?!^First Name$)[a-zA-Z '])+$", ErrorMessage = "Please only use letters in your name")]
        [MinLength(2)]
        [MaxLength(25)]
        public string? FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter your last name")]
        [RegularExpression("^((?!^Last Name$)[a-zA-Z '])+$", ErrorMessage = "Please only use letters in your name")]
        [MinLength(2)]
        [MaxLength(25)]
        public string? LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A valid mailing address is required")]
        public string? Address1 { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A valid City is required")]
        public string? City { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A valid State, Province or Region is required")]
        public string? StateOrProvince { get; set; }
        

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter your ZIP or Postal Code")]
        [MinLength(2)][MaxLength(8)]
        public string? ZIPorPostal{ get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A Valid Country is required")]
        public string? Country { get; set; }
        [Required(ErrorMessage = "Please create a username")]
        public string? UserName { get; set; }
        [Required(ErrorMessage = "A Password is required")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Please enter at least one email address")]
        [RegularExpression("^[A-Za-z0-9._%+-]*@[A-Za-z0-9.-]*\\.[A-Za-z0-9-]{2,}$",
        ErrorMessage = "Email is required and must be properly formatted.")]
        [EmailAddress]
        public string? PrimaryEmail { get; set; }

        [Required(ErrorMessage = "Please enter a Primary Phone Number")]
        [Phone]
        public string? PrimaryPhoneNumber { get; set; }
        [Required]
        public string? PrimaryPhoneType { get; set; }

 // Optional user information, not required
        /// <summary>
        /// Below Fields are optional. They should still have the same Regex restrictions as the above form fields to prevent SQL Injects XSS attacks
        /// </summary>
        [RegularExpression("^[A-Za-z0-9._%+-]*@[A-Za-z0-9.-]*\\.[A-Za-z0-9-]{2,}$",
        ErrorMessage = "Email is required and must be properly formatted.")]
        [EmailAddress]
        public string? SecondaryEmail { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [Phone]
        public string? SecondaryPhoneNumber { get; set; }

        public string? SecondaryPhoneType { get; set; }
        
        public char? MiddleInitial { get; set; }

        public string? Address2 { get; set; }









    }
}
