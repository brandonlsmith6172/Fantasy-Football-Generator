using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FootballCalc.Models;


namespace FootballCalc.Controllers
{
    public class AddPlayersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AddPlayersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AddPlayers
        public IActionResult Index()
        {
            List<Players> Players = new List<Players>();
            Players player = new Players();
            player.PlayerID = 1;
            player.PlayerName = "Aj";
            player.PlayerSalary = 11111;
            player.PlayerTeam = "MSSA";
            Players.Add(player);
            //object Session = null;
            //Session["Players"] = Players;
            return View(Players);
            //return View(await _context.players.ToListAsync());
        }

        // GET: AddPlayers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var players = await _context.player
                .FirstOrDefaultAsync(m => m.PlayerID == id);
            if (players == null)
            {
                return NotFound();
            }

            return View(players);
        }

        // GET: AddPlayers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AddPlayers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PlayerID,RosterID,PlayerName,PlayerSalary")] Players players)
        {
            if (ModelState.IsValid)
            {
                _context.Add(players);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(players);
        }

        // GET: AddPlayers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var players = await _context.player.FindAsync(id);
            if (players == null)
            {
                return NotFound();
            }
            return View(players);
        }

        // POST: AddPlayers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PlayerID,RosterID,PlayerName,PlayerSalary")] Players player)
        {
            if (id != player.PlayerID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(player);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlayersExists(player.PlayerID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(player);
        }

        // GET: AddPlayers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var players = await _context.player
                .FirstOrDefaultAsync(m => m.PlayerID == id);
            if (players == null)
            {
                return NotFound();
            }

            return View(players);
        }

        // POST: AddPlayers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var players = await _context.player.FindAsync(id);
            _context.player.Remove(players);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlayersExists(int id)
        {
            return _context.player.Any(e => e.PlayerID == id);
        }
    }
}
