using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Moq;
using SportsStore.Controllers;
using SportsStore.Models;
using Xunit;

namespace SportsStore.Tests
{
    public class ProductControllerTests
    {
        [Fact]
        public void Can_Use_Repository()
        {
            // Arrange
            // List  => IQueryable
        IQueryable<Product> fakeProductList =
               (new List<Product> { new Product() { ProductId = 123, Description = "book" }, 
                new Product() { ProductId = 234, Description = "Bike" }
        }).AsQueryable<Product>();

        // Configure the Mock 
        var mock = new Mock<IStoreRepository>();                                // specify the Interface we want to mock
        
        mock.Setup(o=>o.Products).Returns(fakeProductList); // Mock the behavior based on Interface
            
        var controller = new HomeController(mock.Object);                      // feed controller the Mock object
           
            // Action
            // Here is the key, we need to cast data type so that we can operate
            // IS vs AS : https://www.geeksforgeeks.org/is-vs-as-operator-keyword-in-c-sharp/
            IEnumerable<Product> result=(controller.Index() as ViewResult)?.ViewData.Model as IEnumerable<Product>;
            
            // Assertion
            Product[] prodArray = result?.ToArray();
            Assert.True(prodArray?.Length==2);
            Assert.Equal("book",prodArray[0].Description);
            Assert.Equal("Bike",prodArray[1].Description);

        }

        [Fact]
        public void Can_Paginate()
        {
            //Arrange
            //create fake data
            var fake = new List<Product>
            {
                new Product() { ProductId = 1, Name = "p1" },
                new Product() { ProductId = 2, Name = "p2" },
                new Product() { ProductId = 3, Name = "p3" },
                new Product() { ProductId = 4, Name = "p4" },
                new Product() { ProductId = 5, Name = "p5" },
                new Product() { ProductId = 6, Name = "p6" },
                new Product() { ProductId = 7, Name = "p7" },
                new Product() { ProductId = 8, Name = "p8" },
                new Product() { ProductId = 9, Name = "p9" },
                new Product() { ProductId = 10, Name = "p10" },
                new Product() { ProductId = 11, Name = "p11" }
            };
            //Mock repository
            var mock = new Mock<IStoreRepository>();
            //Set up behavior
            mock.Setup(m => m.Products).Returns(fake.AsQueryable<Product>());
            // Use mock data
            var controller = new HomeController(mock.Object);
            controller.PageSize = 3;
            //Action
            var result = (controller.Index(2) as ViewResult)?.ViewData?.Model as IEnumerable<Product>;
            //Assertion
            var prodArray = result?.ToArray();
            Assert.True(prodArray?.Length==3);
            Assert.Equal("p4", prodArray[0].Name);
            Assert.Equal("p5", prodArray[1].Name);
        }
    }
}
