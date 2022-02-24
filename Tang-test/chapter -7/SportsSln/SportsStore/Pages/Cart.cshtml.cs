using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SportsStore.Infrastructure;
using SportsStore.Models;

namespace SportsStore.Pages
{
    public class CartModel : PageModel
    {
        private IStoreRepository repository;
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
        
        public CartModel(IStoreRepository repo)
        {
            repository = repo;
        }
        
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        public IActionResult OnPost(long productID, string returnUrl)
        {
            Product product = repository.Products.FirstOrDefault(p => p.ProductId == productID);
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            Cart.AddItem(product,1);
            HttpContext.Session.SetJson("cart",Cart);
            // Redirects (Status302Found) to the current page with the specified routeValues.
            // This post will update Session state
            // After that, we need redirect the request to an active Page
            return RedirectToPage(new {returnUrl = returnUrl});
        }
    }
}