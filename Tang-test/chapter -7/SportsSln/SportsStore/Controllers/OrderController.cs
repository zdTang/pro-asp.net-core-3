using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Controllers
{
    public class OrderController : Controller
    {
        // Be aware here the "Order" we passed to view will be converted to Dynamic
        // So that we need a @model in the razor to mapping a type
        public IActionResult Checkout()=>View(new Order());
        
    }
}
