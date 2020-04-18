using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FootballCalc.Models
{
    public class UserModel
    {
        [Key]
        [Required]
        public int Userid { get; set; }
        [Required(ErrorMessage = "First name is required.")]
        public string First_Name { get; set; }
        [Required(ErrorMessage = "Last name is required.")]
        public string Last_Name { get; set; }
        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Date of Birth is required.")]
        public string Date_Of_Birth { get; set; }
        [Required(ErrorMessage = "Email Address is required.")]
        public string Email_Address { get; set; }
    }
}
