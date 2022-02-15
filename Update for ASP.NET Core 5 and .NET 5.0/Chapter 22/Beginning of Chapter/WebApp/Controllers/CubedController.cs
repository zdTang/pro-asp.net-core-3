using System;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class CubedController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View("Cubed");
        }

        public IActionResult Cube(double num)
        {
            TempData["value"] = num.ToString();
            TempData["result"]=Math.Pow(num,3).ToString();
            // nameof() return a string constant
            return RedirectToAction(nameof(Index));
        }
    }
}