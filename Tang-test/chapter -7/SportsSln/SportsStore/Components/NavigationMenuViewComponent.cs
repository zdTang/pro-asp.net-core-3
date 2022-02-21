using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Components
{
    /// <summary>
    /// Create a view component
    /// Notice the name convention
    /// this component will be "navigation-menu"
    /// </summary>
    public class NavigationMenuViewComponent:ViewComponent
    {
        private IStoreRepository _repository;

        public NavigationMenuViewComponent(IStoreRepository repo)
        {
            _repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            // choose unique Category and order by Category
            // RouteData can be accessed from Request
            
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            
            // Here return a ViewViewComponentResult
            return View(_repository.Products
                .Select(x=>x.Category)
                .Distinct()
                .OrderBy(x=>x));
        }
    }
}