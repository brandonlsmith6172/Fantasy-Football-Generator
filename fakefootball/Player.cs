using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fakefootball
{
    public class Player
    {
        //public PlayerPosition Position { get; set; }
        public int Position { get; set; }
        public string PlayerName { get; set; }

        public string PlayerTeam { get; set; }

        public int Salary { get; set; }

        public override string ToString()
        {
            StringBuilder player = new StringBuilder();
            player.AppendLine($"Player name: {PlayerName}");
            player.AppendLine($"Player team: {PlayerTeam}");
            player.AppendLine($"Player Position: {Position}");
            player.AppendLine($"Player Salary: {Salary}");
            return player.ToString();
        }
    }
    public enum PlayerPosition { QB, WR, TE, RB, Flex, DSP }
}
