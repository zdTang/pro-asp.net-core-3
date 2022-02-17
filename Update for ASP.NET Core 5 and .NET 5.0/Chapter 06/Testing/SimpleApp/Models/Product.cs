using System.Collections.Generic;

namespace SimpleApp.Models {

   // Remove the static method. so that to separate Controller from Product repository

    public class Product {
        public string Name { get; set; }
        public decimal? Price { get; set; }
        
    }

    // Here we re-create the repository. This approach, we use the repository via the interface
    // By accessing repository via Interface, we can leverage the interface to simualte or create a fake repository
    public class ProductDataSource : IDataSource {
       // this is a read-only property
        public IEnumerable<Product> Products =>
            new Product[] {
                new Product { Name = "Kayak", Price = 275M },
                new Product { Name = "Lifejacket", Price = 48.95M }
            };
    }
}
