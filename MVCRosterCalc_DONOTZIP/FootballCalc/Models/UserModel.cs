using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballCalc.Models
{
    public class UserModel
    {
        public int Userid { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EmailAddress { get; set; }
    }
}
