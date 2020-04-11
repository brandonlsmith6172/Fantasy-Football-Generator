using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace FootballCalc.Models
{
    public class ApplicationDbContext : DbContext
    {


            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options) { }

        public DbSet<UserModel> Users { get; set; }
       
    }
    }

