using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballCalc.Models
{
    public class FakeFootballRepository : IFootballRepository
    {
        public IQueryable<UserModel> Users => new List<UserModel>
        {
            new UserModel{ First_Name = "Brandon", Last_Name = "Smith", Date_Of_Birth = "11/11/1997", Email_Address="nunya", Username = "brando123", Password="fuckface123"}
        }.AsQueryable<UserModel>();
    }
}