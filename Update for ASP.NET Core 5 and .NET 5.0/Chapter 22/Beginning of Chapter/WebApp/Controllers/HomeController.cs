using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Controllers {

    public class HomeController : Controller {
        private DataContext context;

        public HomeController(DataContext ctx) {
            context = ctx;
        }

        public async Task<IActionResult> Index(long id = 1)
        {
            ViewBag.AveragePrice = await context.Products.AverageAsync(P => P.Price);
            ViewBag.Title = "Mike is great!";
            return View(await context.Products.FindAsync(id));
        }

        public IActionResult List() {
            return View(context.Products);
        }
    }
}
