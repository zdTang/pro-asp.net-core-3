using System.Collections.Generic;

namespace SimpleApp.Models {

    public class Product {
        public string Name { get; set; }
        public decimal? Price { get; set; }
        
        // Add a static method which can return a bunch of data
        public static IEnumerable<Product> GetProducts()
        {
            return new Product[] {
                new Product { Name = "Kayak", Price = 275M },
                new Product { Name = "Lifejacket", Price = 48.95M }
            };
        }
    }

    public class ProductDataSource : IDataSource {
       // this is a read-only property
        public IEnumerable<Product> Products =>
            new Product[] {
                new Product { Name = "Kayak", Price = 275M },
                new Product { Name = "Lifejacket", Price = 48.95M }
            };
    }
}
