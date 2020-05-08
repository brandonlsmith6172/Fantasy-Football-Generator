using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fakefootball
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates an empty roster list
            List<Roster> rosters = new List<Roster>();
            //creates an empty player list
            IList<Player> Players = new List<Player>();
            //creates random variable
            var rand = new Random();
            int salarycap;
            List<int> positionNumbers = new List<int>();

            do
            {
                Console.WriteLine("Enter your salary cap");

            } while (!int.TryParse(Console.ReadLine(), out salarycap) || salarycap < 0);

            Console.WriteLine("How many of each position do you need in your roster?");

            for (int i = 0; i < Enum.GetValues(typeof(enumPositions)).Length; i++)
            {
                int temp = 0;
                do
                {
                    Console.WriteLine($"{Enum.GetName(typeof(enumPositions), i)}");
                } while (!int.TryParse(Console.ReadLine(), out temp) || temp < 0);
                positionNumbers.Add(temp);
            }

            Console.WriteLine("Perfect, now we will create a list of all possible players.");
            Console.WriteLine("Enter the attributes of each player seperated by commas, or type exit to finish.");
            Console.WriteLine("Example: PLAYERNAME, PLAYERTEAM, POSITION, SALARY");
            Console.WriteLine("QB = 0 | WR = 1 | TE = 2 | RB = 3 | Flex = 4 | DSP = 5");

            while (true)
            {

                Player player = new Player();
                Console.Write("New Player:");
                string temp = Console.ReadLine();

                if (temp.Trim().ToLower() == "exit" || string.IsNullOrEmpty(temp)) break;

                List<string> tempAttributes = temp.Split(',').ToList();
                tempAttributes.ForEach(a => a.Trim());

                player.PlayerName = tempAttributes[0];
                player.PlayerTeam = tempAttributes[1];

                int tempNum = 0;
                if (!int.TryParse(tempAttributes[2], out tempNum) || !Enum.IsDefined(typeof(enumPositions), tempNum))
                    continue;
                else
                    player.Position = tempNum;

                if (!int.TryParse(tempAttributes[3], out tempNum) || tempNum < 0)
                    continue;
                else
                    player.Salary = tempNum;

                Players.Add(player);

            }

            Console.WriteLine();

            Players = Players.OrderBy(p => p.Salary).ToList();


            for (int i = 0; i < Players.Count(); i++)
            {
                bool cont = true;
                Roster roster = new Roster();

                for (int y = i; y < Players.Count; y++)
                {
                    Player player = Players[y];

                    if (roster.TotalPrice() + player.Salary > salarycap) continue;
                    if (roster.NumOfPlayersForPosition(player.Position) >= positionNumbers[player.Position]) continue;

                    roster.Players.Add(player);
                }

                for (int x = 0; x < positionNumbers.Count(); x++)
                {
                    if (roster.NumOfPlayersForPosition(x) < positionNumbers[x])
                        cont = false;
                }

                if (!cont) break;
                else rosters.Add(roster);
            }


            while (true)
            {
                Console.Clear();
                Console.WriteLine($"A total of {rosters.Count} were created.");
                int rosterNum = 0;
                do
                {
                    Console.WriteLine($"Enter a number between 0 - {rosters.Count - 1} to view that roster!");
                } while (!int.TryParse(Console.ReadLine(), out rosterNum) || rosterNum < 0 || rosterNum >= rosters.Count);

                Console.Clear();
                Console.WriteLine($"Roster: {rosterNum} - Total Price: {rosters[rosterNum].TotalPrice():c}");
                Console.WriteLine(String.Format("|{0,10}|{1,10}|{2,10}|{3,10}|", "Name", "Team", "Position", "Salary"));
                foreach (var item in rosters[rosterNum].Players)
                {
                    Console.WriteLine(String.Format("|{0,10}|{1,10}|{2,10}|{3,10}|", item.PlayerName, item.PlayerTeam, Enum.GetName(typeof(enumPositions), item.Position), item.Salary));
                }

                string temp;
                do
                {
                    Console.WriteLine("\nEnter 'back' to go back to your rosters, or type 'exit' to close the application");
                    temp = Console.ReadLine();
                } while (!(new List<string>() { "back", "exit" }).Contains(temp.ToLower()));

                if (temp == "exit") break;

                continue;
            }
        }
    }
}
