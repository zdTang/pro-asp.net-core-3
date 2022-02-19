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
    }
}
