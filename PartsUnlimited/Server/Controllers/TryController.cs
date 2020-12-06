using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartsUnlimited.Server.Controllers
{
    public class TryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
