using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FootballCalc.Models
{
    public class Players
    {
        [Key]
        public int PlayerID { get; set; }
        public int RosterID { get; set; }
        public int Position { get; set; }
        public string PlayerName { get; set; }
        [StringLength(50)]
        [NotMapped]
        public string PlayerTeam { get; set; }
        [StringLength(50)]
        public int PlayerSalary { get; set; }

        public override string ToString()
        {
            StringBuilder player = new StringBuilder();
            player.AppendLine($"Player name: {PlayerName}");
            player.AppendLine($"Player team: {PlayerTeam}");
            player.AppendLine($"Player Position: {Position}");
            player.AppendLine($"Player Salary: {PlayerSalary}");
            return player.ToString();
        }
        public enum PlayerPosition { QB, WR, TE, RB, Flex, DSP }
    }
}
