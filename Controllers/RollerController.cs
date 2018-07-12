using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DemiplaneTemplate.Controllers
{
    public class RollerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}