using Microsoft.AspNetCore.Mvc;
using ModelViewNew.Models;
using System.Collections.Generic;
using System.Diagnostics;
using ModelViewNew.ViewModels;
using System.Linq;



namespace ModelViewNew.Controllers
{
    public class HomeController : Controller
    {

        List<Phone> phones;
        List<Company> companies;
        public HomeController()
        {
            Company apple = new() { Id = 1, Name = "Apple", Country = "США" };
            Company microsoft = new () { Id = 2, Name = "Samsung", Country = "Республика Корея" };
            Company google = new() { Id = 3, Name = "Google", Country = "США" };

            companies = new List<Company> { apple, microsoft, google };

            phones = new List<Phone>
            {
                new Phone { Id=1, Manufacturer= apple, Name="iPhone X", Price=56000 },
                new Phone { Id=2, Manufacturer= apple, Name="iPhone XZ", Price=41000 },
                new Phone { Id=3, Manufacturer= microsoft, Name="Galaxy 9", Price=9000 },
                new Phone { Id=4, Manufacturer= microsoft, Name="Galaxy 10", Price=40000 },
                new Phone { Id=5, Manufacturer= google, Name="Pixel 2", Price=30000 },
                new Phone { Id=6, Manufacturer= google, Name="Pixel XL", Price=50000 }
            };
        }

        public IActionResult Index(int? companyId)
        {
            List<CompanyModel> compModel = companies.Select(c => new CompanyModel { Id = c.Id, Name = c.Name }).ToList();

            compModel.Insert(0, new CompanyModel { Id = 0, Name = "Все" });

            IndexViewModel index = new() { Companies = compModel, Phones = phones };

            if (companyId != null && companyId > 0)
                index.Phones = phones.Where(p => p.Manufacturer.Id == companyId);

            return View(index);
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
