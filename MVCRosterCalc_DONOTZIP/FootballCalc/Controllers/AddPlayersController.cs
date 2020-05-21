using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FootballCalc.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace FootballCalc.Controllers
{
    public class AddPlayersController : Controller
    {
        private readonly DbApiContext _context;

        public AddPlayersController(DbApiContext context)
        {
            _context = context;
        }

        List<Players> PlayersList;

        // GET: AddPlayers
        private void GetPlayerList()
        {
            var value = HttpContext.Session.GetString("Players");
            if (value == null)
            {
                PlayersList = new List<Players>();
            }
            else
            {
                PlayersList = JsonConvert.DeserializeObject<List<Players>>(value);
            }
        }


        public IActionResult Index()
        {
            GetPlayerList();
            return View(PlayersList);
            //return View(await _context.players.ToListAsync());
        }

        [HttpPost, ActionName("Index")]
        public IActionResult AddPlayer(string name, int position, string team, int salary)
        {
            GetPlayerList();
            Players player = new Players
            {
                PlayerID = PlayersList.Any() ? PlayersList.Max(p => p.PlayerID) + 1 : 1,
                PlayerName = name,
                PlayerPosition = position,
                PlayerTeam = team,
                PlayerSalary = salary
            };
            PlayersList.Add(player);
            HttpContext.Session.SetString("Players", JsonConvert.SerializeObject(PlayersList));
            return RedirectToAction("Index");
        }

        [ActionName("Index")]
        [HttpGet("{id}")]
        public ActionResult RemovePlayer(int id)
        {
            GetPlayerList();
            PlayersList.Remove(PlayersList.FirstOrDefault(p => p.PlayerID == id));
            HttpContext.Session.SetString("Players", JsonConvert.SerializeObject(PlayersList));
            return RedirectToAction("Index");
        }


        // GET: AddPlayers/Delete
        public IActionResult Delete()
        {
            GetPlayerList();
            if (PlayersList == null)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        // POST: AddPlayers/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed()
        {
            PlayersList = new List<Players>();
            HttpContext.Session.SetString("Players", JsonConvert.SerializeObject(PlayersList));
            return RedirectToAction("Index");
        }

        private bool PlayersExists(int id)
        {
            return _context.Players.Any(e => e.PlayerID == id);
        }

        [HttpPost]
        public IActionResult CreateRosters(int budget, int qb, int wr, int te, int rb, int flex, int dsp)
        {
            GetPlayerList();
            List<Roster> rosters = new List<Roster>();

            var rand = new Random();
            List<int> positionNumbers = new List<int>();
            positionNumbers.Add(qb);
            positionNumbers.Add(wr);
            positionNumbers.Add(te);
            positionNumbers.Add(rb);
            positionNumbers.Add(flex);
            positionNumbers.Add(dsp);

            PlayersList = PlayersList.OrderBy(p => p.PlayerSalary).ToList();

            for (int i = 0; i < PlayersList.Count; i++)
            {
                bool cont = true;
                Roster roster = new Roster();

                for (int y = i; y < PlayersList.Count; y++)
                {
                    Players player = PlayersList[y];

                    if (roster.TotalPrice() + player.PlayerSalary > budget) continue;
                    if (roster.NumOfPlayersForPosition(player.PlayerPosition) >= positionNumbers[player.PlayerPosition]) continue;

                    roster.players.Add(player);
                }

                for (int x = 0; x < positionNumbers.Count(); x++)
                {
                    if (roster.NumOfPlayersForPosition(x) < positionNumbers[x])
                        cont = false;
                }

                if (!cont) break;
                else rosters.Add(roster);
            }


            HttpContext.Session.SetString("Rosters", JsonConvert.SerializeObject(rosters));

            return RedirectToAction("Index", "Roster");
        }
    }
}
