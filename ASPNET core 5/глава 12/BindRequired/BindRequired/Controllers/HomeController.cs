using BindRequired.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace BindRequired.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index(User user)
        {
            if (ModelState.IsValid)
            {
                string userInfo = $"Id: {user.Id}  Name: {user.Name}  Age: {user.Age}  HasRight: {user.HasRight}";
                return Content(userInfo);
            }
            return Content($"Количество ошибок: {ModelState.ErrorCount} " + Request.HttpContext.Request.Path);
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
    }
}
