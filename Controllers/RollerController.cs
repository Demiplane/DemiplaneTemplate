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
            rollers = new List<IDieRoller>() { new ArbitraryDieAdapter(new RandomDieRoller()), new ArbitraryDieAdapter(new AllOrNothingDieRoller()), new ArbitraryDieAdapter(new DMDieRoller()) };
        }

        public IActionResult Index()
        {
            var rollerViewModel = new RollerViewModel
            {
                RollerNames = rollers.Select(r => r.Name).ToList()
            };

            return View("RollerView", rollerViewModel);
        }

        public int RollD4(string rollerName)
        {
            return this.rollers.First((roller) => rollerName.Trim() == roller.Name).RollD4();
        }

        public int RollD6(string rollerName)
        {
            return this.rollers.First((roller) => rollerName.Trim() == roller.Name).RollD6();
        }

        public int RollD8(string rollerName)
        {
            return this.rollers.First((roller) => rollerName.Trim() == roller.Name).RollD8();
        }

        public int RollD10(string rollerName)
        {
            return this.rollers.First((roller) => rollerName.Trim() == roller.Name).RollD10();
        }

        public int RollD12(string rollerName)
        {
            return this.rollers.First((roller) => rollerName.Trim() == roller.Name).RollD12();
        }

        public int RollD20(string rollerName)
        {
            return this.rollers.First((roller) => rollerName.Trim() == roller.Name).RollD20();
        }

        public int RollD100(string rollerName)
        {
            return this.rollers.First((roller) => rollerName.Trim() == roller.Name).RollD100();
        }
    }
}