using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballCalc.Models
{
    public interface IFootballRepository
    {
        IQueryable<UserModel> Users { get; }
        //IQueryable<UserModel> UserName { get; }
        //IQueryable<UserModel> Password { get; }
        //IQueryable<UserModel> FirstName { get; }
        //IQueryable<UserModel> LastName { get; }
        //IQueryable<UserModel> Date_Of_Birth { get; }
        //IQueryable<UserModel> Email { get; }

        //IQueryable<UserModel> PossibleRosters { get; }
        //IQueryable<UserModel> NewRoster { get; }
        //IQueryable<UserModel> SavedRosters { get; }
        IQueryable<Roster> rosters { get; set; }
        IQueryable<Players> players { get; set; }
    }
}
