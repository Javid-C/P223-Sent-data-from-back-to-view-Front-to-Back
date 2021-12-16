using DataTransfer.Models;
using DataTransfer.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTransfer.Controllers
{
    public class HomeController:Controller
    {
        public ActionResult Index(string name,string surname,int age)
        {
            //TempData["Name"] = name;
            //TempData["Surname"] = surname;
            //TempData["Age"] = age;
            List<Product> products = new List<Product>
            {
                new Product()
                {
                    Id = 1,
                    Name = "Air Jordan",
                    Price = 100,
                    Size = 42,
                    Count = 80,
                    Color = "Red"

                },
                new Product()
                {
                    Id = 2,
                    Name = "Air Max",
                    Price = 200,
                    Size = 40,
                    Count = 10,
                    Color = "Blue"

                },
                new Product()
                {
                    Id = 3,
                    Name = "Air Force",
                    Price = 150,
                    Size = 47,
                    Count = 35,
                    Color = "Pink"

                },
                new Product()
                {
                    Id = 4,
                    Name = "Blazer mid 77 vintage",
                    Price = 10,
                    Size = 40,
                    Count = 80,
                    Color = "Hot pink"

                },
                new Product()
                {
                    Id = 5,
                    Name = "Air Jordan DIOR",
                    Price = 300,
                    Size = 41,
                    Count = 0,
                    Color = "Black"

                }

            };
            //ViewBag.Products = products;
            return View(products);

            //return RedirectToAction(nameof(About));
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Detail()
        {
            Product product =new Product
            {
                Id = 1,
                Name = "Air Jordan",
                Price = 100,
                Size = 42,
                Count = 80,
                Color = "Red"

            };

            List<Card> cards = new List<Card>
            {
                new Card
                {
                    Id = 1,
                Name = "Kapital Bank",
                ExpiredDate = "07/2024",
                CVC = 629
                },
                 new Card
                {
                    Id = 2,
                Name = "Pasha Bank",
                ExpiredDate = "07/2023",
                CVC = 999
                },
                  new Card
                {
                    Id = 3,
                Name = "Goyezen Bank",
                ExpiredDate = "07/2560",
                CVC = 620
                }

            };

            ProductCardVM model = new ProductCardVM
            {
                Product = product,
                Cards = cards
            };

            return View(model);
        }
    }
}
