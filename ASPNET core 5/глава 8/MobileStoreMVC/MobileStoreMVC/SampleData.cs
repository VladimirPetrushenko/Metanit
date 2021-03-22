using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MobileStoreMVC.Models;

namespace MobileStoreMVC
{
    public static class SampleData
    {
        public static void Initialize(MobileContext context)
        {
            if (!context.Phones.Any())
            {
                context.Phones.AddRange(
                    new Phone
                    {
                        Name = "iPhone X",
                        Company = "Apple",
                        Price = 800
                    },
                    new Phone
                    {
                        Name = "S10",
                        Company = "Samsung",
                        Price = 800
                    },
                    new Phone
                    {
                        Name = "Pixel 4",
                        Company = "Google",
                        Price = 800
                    },
                    new Phone
                    {
                        Name = "P20",
                        Company = "Huawei",
                        Price = 800
                    }
                    );
            }
            context.SaveChanges();
        }
    }
}
