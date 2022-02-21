using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Moq;
using SportsStore.Controllers;
using SportsStore.Models;
using SportsStore.Models.ViewModels;
using Xunit;

namespace SportsStore.Tests
{
    public class ProductControllerTests
    {
        public ProductControllerTests()
        {
            // Put common used stuff here !
        }
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
            ProductsListViewModel result=(controller.Index(null) as ViewResult)?.ViewData.Model as ProductsListViewModel;
            
            // Assertion
            Product[] prodArray = result?.Products?.ToArray();
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
            var result = (controller.Index(null,2) as ViewResult)?.ViewData?.Model as ProductsListViewModel;
            //Assertion
            var prodArray = result?.Products?.ToArray();
            Assert.True(prodArray?.Length==3);
            Assert.Equal("p4", prodArray[0].Name);
            Assert.Equal("p5", prodArray[1].Name);
        }

        [Fact]
        public void Can_Send_Pagination_View_Model()
        {
            //Arrange
            var mock = new Mock<IStoreRepository>();
            var products = new Product[]
            {
                new Product() { ProductId = 1, Name = "p1" },
                new Product() { ProductId = 2, Name = "p2" },
                new Product() { ProductId = 3, Name = "p3" },
                new Product() { ProductId = 4, Name = "p4" },
                new Product() { ProductId = 5, Name = "p5" }
            };
            mock.Setup(m => m.Products).Returns(products.AsQueryable<Product>());
            
            // Arrange
            HomeController controller = new HomeController(mock.Object) { PageSize = 3 };
            
            // Act
            // Notice  if no "as", we cannot retrieve ViewData
            ProductsListViewModel result = (controller.Index(null, 2) as ViewResult)?.ViewData.Model as ProductsListViewModel;
            
            //Assert
            PagingInfo pageInfo = result?.PagingInfo;
            Assert.Equal(2, pageInfo?.CurrentPage);
            Assert.Equal(3, pageInfo?.ItemsPerPage);
            Assert.Equal(5, pageInfo?.TotalItems);
            Assert.Equal(2, pageInfo?.TotalPages);

        }

        [Fact]
        public void Can_Filter_Products()
        {
            //Arrange
            //Create the mock repository
            var mock = new Mock<IStoreRepository>();
            var fake = new Product[]
            {
                new Product() { ProductId = 1, Name = "p1",Category="Cat1" },
                new Product() { ProductId = 2, Name = "p2",Category="Cat2"},
                new Product() { ProductId = 3, Name = "p3",Category="Cat1" },
                new Product() { ProductId = 4, Name = "p4",Category="Cat2"},
                new Product() { ProductId = 5, Name = "p5",Category="Cat3" }
            };
            mock.Setup(x => x.Products).Returns(fake.AsQueryable<Product>());
            // Arrange - Create a controller and make the page size 3 items

            var controller = new HomeController(mock.Object);
            controller.PageSize = 3;
            //Action
            //Be aware the ViewResult is from ActionResult and has lots of extra properties 
            var result = ((controller?.Index("Cat2",1) as ViewResult)?.Model as ProductsListViewModel)?.Products.ToArray();
            //var result = (controller?.Index("Cat1",1).ViewData.Model as ProductsListViewModel).Products.ToArray();   // THIS IS FROM TEXTBOOK AND DOESN'T WORK
            
            //Assert
            Assert.Equal(2, result?.Length);
            Assert.True(result[0].Name == "p2" && result[0].Category == "Cat2");
            Assert.True(result[1].Name == "p4" && result[1].Category == "Cat2");
        }
    }
}
