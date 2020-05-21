using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FootballCalc.Models
{
    public class DbApiContext : DbContext
    {
        public DbApiContext(DbContextOptions<DbApiContext> options) : base(options) { }

        public DbSet<Players> Players { get; set; }

        public DbSet<Roster> Rosters { get; set; }
    }
}
