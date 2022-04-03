using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using System.Linq;

namespace SportsStore.Components
{
    /// <summary>
    /// Create a view component
    /// Notice the name convention
    /// this component will be "navigation-menu"
    /// </summary>
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IStoreRepository _repository;

        // view component is very powerful and it can use DI
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
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}