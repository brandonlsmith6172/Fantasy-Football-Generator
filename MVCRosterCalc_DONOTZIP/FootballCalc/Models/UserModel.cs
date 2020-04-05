using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FootballCalc.Models
{
    public class UserModel
    {
        [Required]
        public int Userid { get; set; }
        [Required]
        public string First_Name { get; set; }
        [Required]
        public string Last_Name { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public DateTime Date_Of_Birth { get; set; }
        [Required]
        public string Email_Address { get; set; }
    }
}
