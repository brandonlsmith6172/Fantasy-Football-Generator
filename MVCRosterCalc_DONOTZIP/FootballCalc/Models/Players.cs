using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballCalc.Models
{
    public class Players
    {
        [Key]
        public int PlayerID { get; set; }
        public int RosterID { get; set; }
        public string PlayerName { get; set; }
        [NotMapped]
        public string PlayerTeam { get; set; }
        public int PlayerSalary { get; set; }

    }
}
