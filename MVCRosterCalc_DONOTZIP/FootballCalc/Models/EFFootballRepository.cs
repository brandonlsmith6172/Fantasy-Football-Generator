using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballCalc.Models
{
    public class EFFootballRepository : IFootballRepository
    {
            private ApplicationDbContext context;

            public EFFootballRepository(ApplicationDbContext ctx)
            {
                context = ctx;
            }

            //public IQueryable<UserModel> users => context.users;

        public IQueryable<UserModel> Users => context.Users;

        //public IQueryable<UserModel> Password => throw new NotImplementedException();

        //public IQueryable<UserModel> First_Name => throw new NotImplementedException();

        //public IQueryable<UserModel> Last_Name => throw new NotImplementedException();

        //public IQueryable<UserModel> Date_Of_Birth => throw new NotImplementedException();

        //public IQueryable<UserModel> Email => throw new NotImplementedException();
    }
}
