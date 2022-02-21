using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Moq;
using SportsStore.Components;
using SportsStore.Models;
using Xunit;

namespace SportsStore.Tests
{
    public class NavigationMenuViewComponentTests
    {
        [Fact]
        public void Can_Select_Categories()
        {
            //arrange
            var fake = new Product[]
            {
                new Product { ProductId = 1, Name = "p1", Category = "Apples" },
                new Product { ProductId = 2, Name = "p2", Category = "oranges" },
                new Product { ProductId = 3, Name = "p3", Category = "plums" },
                new Product { ProductId = 4, Name = "p4", Category = "Apples" },
            };
            var mock = new Mock<IStoreRepository>();
            mock.Setup(x => x.Products).Returns(fake.AsQueryable<Product>());

            //action
            var controller = new NavigationMenuViewComponent(mock.Object);
            var results = ((controller.Invoke() as ViewViewComponentResult)?.ViewData.Model) as IEnumerable<string>; 
            //assert

            Assert.True(Enumerable.SequenceEqual<string>(new string[] { "Apples", "oranges", "plums" }, results));

        }
        
    }
}