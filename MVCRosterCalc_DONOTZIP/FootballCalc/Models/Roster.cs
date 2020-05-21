using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FootballCalc.Models
{
    public class Roster
    {
        [Key]
        public int RosterID { get; set; }
        public List<Players> players { get; set; } = new List<Players>();

        public int TotalPrice() => players.Count > 0 ? players.Select(p => p.PlayerSalary).Sum() : 0;

        public int NumOfPlayersForPosition(int pos) => players.Where(p => p.PlayerPosition == pos).Count();
    }
}
