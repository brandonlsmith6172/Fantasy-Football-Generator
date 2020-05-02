using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fakefootball
{
    class Program
    {
        static void Main(string[] args)
        {

            IList<Player> Players = new List<Player>();
            var rand = new Random();
            int salarycap, position;
            string name = "", possibleposition;
            int salary = 0;
            int qb = 0, wr = 0, rb = 0, def = 0, flex = 0, te = 0;
            Console.WriteLine("Enter your salary cap");
            string possiblecap = Console.ReadLine();
            int.TryParse(possiblecap, out salarycap);
            Console.WriteLine("How many of each position do you need in your roster?");
            Console.Write("QB:");
            possibleposition = Console.ReadLine();
            int.TryParse(possibleposition, out qb);
            Console.Write("WR:");
            possibleposition = Console.ReadLine();
            int.TryParse(possibleposition, out wr);
            Console.Write("RB:");
            possibleposition = Console.ReadLine();
            int.TryParse(possibleposition, out rb);
            Console.Write("Def:");
            possibleposition = Console.ReadLine();
            int.TryParse(possibleposition, out def);
            Console.Write("Flex:");
            possibleposition = Console.ReadLine();
            int.TryParse(possibleposition, out flex);
            Console.Write("TE:");
            possibleposition = Console.ReadLine();
            int.TryParse(possibleposition, out te);
            Console.WriteLine("Perfect, now we will create a list of all possible players.");
            
            do
            {
                Player player = new Player();
                Console.WriteLine("Enter the name of a possible player. Type 'exit' to exit.");
                player.PlayerName = Console.ReadLine();
                Console.WriteLine("Enter the team of the player.");
                player.PlayerTeam = Console.ReadLine();
                Console.WriteLine("Enter the salary of the player.");
                int.TryParse(Console.ReadLine(), out salary);
                player.Salary = salary;
                Console.WriteLine("Enter the Position of the player.");
                Console.WriteLine("QB = 0 | WR = 1 | TE = 2 | RB = 3 | Flex = 4 | DSP = 5");
                int.TryParse(Console.ReadLine(), out position);
                player.Position = (PlayerPosition)position;
                Players.Add(player);
                Console.WriteLine("Hit enter to continue, or type 'exit' to go to the rosters.");
                name = Console.ReadLine();
            } while (name != "exit");        

            Console.WriteLine();

            IList<Player> QBPlayer = Players.Where(x => x.Position == PlayerPosition.QB).ToList<Player>();
            IList<Player> RBPlayer = Players.Where(x => x.Position == PlayerPosition.RB).ToList<Player>();
            IList<Player> WRPlayer = Players.Where(x => x.Position == PlayerPosition.WR).ToList<Player>();
            IList<Player> TEPlayer = Players.Where(x => x.Position == PlayerPosition.TE).ToList<Player>();
            IList<Player> DSPPlayer = Players.Where(x => x.Position == PlayerPosition.DSP).ToList<Player>();
            IList<Player> FlexPlayer = Players.Where(x => x.Position == PlayerPosition.Flex).ToList<Player>();
            IList<Player> Roster = new List<Player>();
            int i = 0;
            for(i = 0; i < qb; i++)
            {
                Roster.Add(QBPlayer[i]);
            }
            for (i = 0; i < rb; i++)
            {
                Roster.Add(RBPlayer[i]);
            }
            for (i = 0; i < wr; i++)
            {
                Roster.Add(WRPlayer[i]);
            }
            for (i = 0; i < te; i++)
            {
                Roster.Add(TEPlayer[i]);
            }
            for (i = 0; i < def; i++)
            {
                Roster.Add(DSPPlayer[i]);
            }
            for (i = 0; i < flex; i++)
            {
                Roster.Add(FlexPlayer[i]);
            }

            foreach (var roster in Roster)
            {
                Console.WriteLine(roster.ToString());
                
            }
            Console.ReadLine();

        }
    }
}
