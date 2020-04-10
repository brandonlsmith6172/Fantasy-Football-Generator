using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FootballCalc.Models;

namespace FootballCalc.Controllers
{
    public class RegisterController : Controller
    {
        private IFootballRepository repository;
        public RegisterController(IFootballRepository repo)
        {
            repository = repo;
        }

        public ViewResult List() => View(repository.UserModels);
        
    }
}