using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class SecondController : Controller
    {
        public IActionResult Common()
        {
            return View("Common");
        }
    }
}