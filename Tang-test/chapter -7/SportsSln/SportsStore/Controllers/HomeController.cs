using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;


namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;
        public int PageSize { get; set; } = 4;          

        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }
        /// <summary>
        /// This method demonstrate how to do pagination
        /// </summary>
        /// <param name="productPage"></param>
        /// <returns></returns>
        // GET
        public IActionResult Index(int productPage = 1)
        {
            var model = repository
                .Products.OrderBy(o => o.ProductId)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize);
            return View(model);
        }
        
    }
}