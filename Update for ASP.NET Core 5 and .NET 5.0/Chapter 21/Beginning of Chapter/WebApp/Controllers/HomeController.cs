using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private DataContext context;
        public HomeController(DataContext ctx)
        {
            context = ctx;
        }
        // GET
        public async Task<IActionResult> Index(long id = 1)
        {
            Product prod = await context.Products.FindAsync(id);
            if (prod.CategoryId == 1)
            {
                return View("WaterSports", prod);
            }
            else
            {
                return View(prod);
            }
        }
    }
}