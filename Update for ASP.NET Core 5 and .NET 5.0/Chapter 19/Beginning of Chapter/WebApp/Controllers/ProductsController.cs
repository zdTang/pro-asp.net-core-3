using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApp.Models;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        // Here return an Array of Product
        // don't serialize it manually, just return the Object Collection
        // Framework will serialize it for you.
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return new Product[]
            {
                new Product(){Name="Product #1"},
                new Product(){Name="Product #2"}
            };
        }

        // Here return a JSON, We don't need to Serialize Object
        // The WebAPI controller will handle this !

        [HttpGet("{id}")]
        public Product GetProduct()
        {
            return new Product()
            {
                ProductId = 1,
                Name = "Test Product"
            };
        }
    }
}
