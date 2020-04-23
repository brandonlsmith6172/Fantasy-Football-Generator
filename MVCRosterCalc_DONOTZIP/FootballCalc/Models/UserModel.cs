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
        public int UserID { get; set; }
        [Required(ErrorMessage = "First name is required.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "UserName is required.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        public string UserPassword { get; set; }
        [Required(ErrorMessage = "Date of Birth is required.")]
        [DisplayFormat(DataFormatString ="{0:MM.dd.yyyy}")]
        [DataType(DataType.DateTime)]
        public DateTime Date_Of_Birth { get; set; }
        [Required(ErrorMessage = "Email Address is required.")]
        public string Email { get; set; }
    }
}
