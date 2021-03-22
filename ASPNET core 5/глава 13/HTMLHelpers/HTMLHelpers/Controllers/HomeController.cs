using HTMLHelpers.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HTMLHelpers.Controllers
{
    public class HomeController : Controller
    {
        List<User> users = new List<User>
            {
                new User {Id=1, Name="Tom", Age=35 },
                new User {Id=2, Name="Alice", Age=29 },
                new User {Id=3, Name="Sam", Age=36 },
                new User {Id=4, Name="Bob", Age=31 }
            };
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(users);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Create()
        {
            
            ViewBag.Users = new SelectList(users, "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult Create(int userid)
        {
            return Content(userid.ToString());
        }
    }
}
