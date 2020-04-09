using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballCalc.Models
{
    public interface IFootballRepository
    {
        IQueryable<UserModel> User { get; }
        IQueryable<UserModel> PossibleRosters { get; }
        IQueryable<UserModel> NewRoster { get; }
        IQueryable<UserModel> SavedRosters { get; }
    }
}
