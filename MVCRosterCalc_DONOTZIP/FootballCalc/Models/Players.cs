using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FootballCalc.Models
{
    public class Players
    {
        [Key]
        public string PlayerName { get; set; }
        public string PlayerTeam { get; set; }
        public int PlayerCost { get; set; }
    }
}
