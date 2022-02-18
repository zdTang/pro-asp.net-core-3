using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SimpleApp.Controllers;
using SimpleApp.Models;
using Xunit;
using Moq;

namespace SimpleApp.Tests {
    public class HomeControllerTests {


        // This class inherit the IDataSource interface, so that we can use it for testing
        //class FakeDataSource : IDataSource
        //{
        //    public FakeDataSource(params Product[] data) => Products = data;
        //    public IEnumerable<Product> Products { get; set; }
        //}

        [Fact]
        public void IndexActionModelIsComplete() {
                
            
            // Arrange
            // There are fake data for testing, we cannot use product date for testing
            Product[] testData = new Product[] {
                new Product { Name = "P1", Price = 75.10M },
                new Product { Name = "P2", Price = 120M },
                new Product { Name = "P3", Price = 110M }         
            };

            //IDataSource data =new FakeDataSource(testData);
            var mock = new Mock<IDataSource>();
            mock.SetupGet(x=>x.Products).Returns(testData);

            var controller = new HomeController();
            // because controller has a "IDataSource" type property.
            // assign the fake data to the controller
            // mock.Object has lots of stuff, including the mocking data
            controller.dataSource = mock.Object;


            // Act
            // Go to the Controller-Index, we will see the controller take "dataSource.Products" from the Fake data
            // By doing this, we can isolate the controller and do not touch the genuin repository.
            var model = (controller.Index() as ViewResult)?.ViewData.Model
                as IEnumerable<Product>;

            // Assert
            Assert.Equal(testData, model,
                Comparer.Get<Product>((p1, p2) => p1.Name == p2.Name
                    && p1.Price == p2.Price));
            // varify a property has been read on the mock
            mock.VerifyGet(x => x.Products,Times.Once);    

        }
    }
}
