using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FootballCalc.Controllers
{
    public class FootballCalcController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello" + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
