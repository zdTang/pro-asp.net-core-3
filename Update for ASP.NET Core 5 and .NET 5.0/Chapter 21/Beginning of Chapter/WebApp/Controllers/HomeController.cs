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
        public async Task<IActionResult> Index(long id=1)
        {
            
            //View will generate a IActionResult by which Response can be generated 
            return View(await context.Products.FindAsync(id));
        }
    }
}