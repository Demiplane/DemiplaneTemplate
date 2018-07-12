using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemiplaneTemplate.Rollers;
using DemiplaneTemplate.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DemiplaneTemplate.Controllers
{
    public class RollerController : Controller
    {
        private readonly IEnumerable<IDieRoller> rollers;

        public RollerController()
        {
            // HACK
            this.rollers = new List<IDieRoller>() { new ArbitraryDieAdapter(new RandomDieRoller()), new ArbitraryDieAdapter(new AllOrNothingDieRoller()) };
        }

        public IActionResult Index()
        {

            var rollerViewModel = new RollerViewModel();
            return View("RollerView", rollerViewModel);
        }
    }
}