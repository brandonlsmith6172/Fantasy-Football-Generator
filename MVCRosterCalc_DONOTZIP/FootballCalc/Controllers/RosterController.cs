using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FootballCalc.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace FootballCalc.Controllers
{
    public class RosterController : Controller
    {
        List<Roster> RosterList;

        private void GetRosterList()
        {
            var value = HttpContext.Session.GetString("Rosters");
            if (value == null)
            {
                RosterList = new List<Roster>();
            }
            else
            {
                RosterList = JsonConvert.DeserializeObject<List<Roster>>(value);
            }
        }

        public IActionResult Index()
        {
            GetRosterList();

            return View(RosterList);
        }

        public IActionResult Details(int id)
        {
            GetRosterList();
            return View(RosterList[id - 1]);
        }

        public IActionResult Remove(int id)
        {
            GetRosterList();
            RosterList.Remove(RosterList[id]);
            HttpContext.Session.SetString("Rosters", JsonConvert.SerializeObject(RosterList));
            return RedirectToAction("Index");
        }
    }
}