using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FootballCalc.Models;

namespace FootballCalc.Data
{
    public class FootballCalcContext : DbContext
    {
        public FootballCalcContext (DbContextOptions<FootballCalcContext> options)
            : base(options)
        {
        }

        public DbSet<FootballCalc.Models.Players> Players { get; set; }
    }
}
