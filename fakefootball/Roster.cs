using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace fakefootball
{
    public class Roster
    {
        public List<Player> Players { get; set; } = new List<Player>();

        public int TotalPrice() => Players.Count > 0 ? Players.Select(p => p.Salary).Sum() : 0;

        public int NumOfPlayersForPosition(int pos) => Players.Where(p => p.Position == pos).Count();
    }
}
