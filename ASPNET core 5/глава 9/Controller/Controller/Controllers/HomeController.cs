using Controller.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Controller.Util;
using System.Text.Json;
using Microsoft.AspNetCore.Http;

namespace Controller.Controllers
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public void Index()
        {
            string table = "";
            foreach (var header in Request.Headers)
            {
                table += $"<tr><td>{header.Key}</td><td>{header.Value}</td></tr>";
            }
            Response.WriteAsync($"<table>{table}</table>");
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
        public string Hello(int id, int d)
        {
            return id.ToString() + " " + d;
        }

        public IActionResult GetHtml()
        {
            string m = JsonSerializer.Serialize<Cow>(new Cow() { Name = "корова", Height = 12, Weight = 290 });
            return Json(new Cow() { Name = "корова", Height = 12, Weight = 290 }, new JsonSerializerOptions() { WriteIndented = true });
        }
    }
    public class Cow
    {
        public int Height { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }

    }
}
