using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballCalc.Data
{
    public class PlayersContext : DbContext
    {
        public PlayersContext (DbContextOptions<PlayersContext> options) 
            : base(options)
        {
        }
        public DbSet<Models.Players> Players { get; set; }
    }
}
