using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Controllers {
    public class HomeController : Controller {

        public ViewResult Index()
        {
            var results = new List<string>();
            foreach (Product p in Product.GetProducts())
            {
                // Using Null conditional operator to avoid NullReferenceException
                string name = p?.Name;
                decimal? price = p?.Price;
                string relatedName = p?.Related?.Name;   //chain Null Conditional operator
                results.Add(string.Format("Name:{0},Price:{1},Related:{2}", name, price,relatedName));
            }

            return View(results);

            //return View(new string[] {"c#","Language","Features"});
            /*var products = new[] {
                new { Name = "Kayak", Price = 275M },
                new { Name = "Lifejacket", Price = 48.95M },
                new { Name = "Soccer ball", Price = 19.50M },
                new { Name = "Corner flag", Price = 34.95M }
            };*/

            // Notice how to use "nameof"
            /*return View(products.Select(p =>
                $"{nameof(p.Name)}: {p.Name}, {nameof(p.Price)}: {p.Price}"));*/
        }
    }
}
                      