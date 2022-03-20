using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using System.Linq;

namespace SportsStore.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository _orderRepository;
        private Cart _cart;

        public OrderController(IOrderRepository orderRepository,Cart cart)
        {
            _orderRepository = orderRepository;
                _cart = cart;
        }
        
        // Be aware here the "Order" we passed to view will be converted to Dynamic
        // So that we need a @model in the razor to mapping a type    
        public IActionResult Checkout()=>View(new Order());

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            if (_cart.Lines.Count() == 0)
            {
                ModelState.AddModelError(string.Empty, "Sorry, your cart is empty");
            }
            if (ModelState.IsValid)
            {
                order.Lines = _cart.Lines.ToArray();
                _orderRepository.SaveOrder(order);
                _cart.Clear();
                return RedirectToPage("/Completed",new {orderId=order.OrderId});
            }
            else
            {
                return View();
            }
        }
        
    }
}
