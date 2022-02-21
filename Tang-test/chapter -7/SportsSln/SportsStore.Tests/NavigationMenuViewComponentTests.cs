using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        [Fact]
        public void Indicates_Selected_Category()
        {
            //Arrange
            string categoryToSelect = "Apples";
            Mock<IStoreRepository> mock = new Mock<IStoreRepository>();
            var products = new Product[]
            {
                new Product { ProductId = 1, Name = "p1", Category = "Apples" },
                new Product { ProductId = 4, Name = "p2", Category = "Oranges" },
            };
            mock.Setup(x => x.Products).Returns(products.AsQueryable<Product>());
            
            var target = new NavigationMenuViewComponent(mock.Object);
            
            // make a fake "ViewComponentContext"
            target.ViewComponentContext = new ViewComponentContext
            {
                // Make a fake "ViewContext"
                ViewContext = new ViewContext
                {
                    // make a fake "RouteData"
                    RouteData = new Microsoft.AspNetCore.Routing.RouteData()
                }
            };
            // Here to understand, we are making a fake RouteDate.Values["category"], and let it equals to "Apple"
            target.RouteData.Values["category"] = categoryToSelect;
            
            //Action
            // in component: the value of "category" of the RouteData has been assigned to ViewBag.SelectedCategory 
            // ViewBag.SelectedCategory = RouteData?.Values["category"];  
            // So that Here we want to check after Invoke(), if the "SelectedCategory" value has been passed to ViewViewComponentResult
            string result = (string)(target?.Invoke() as ViewViewComponentResult)?.ViewData["SelectedCategory"];
            //Assert

            Assert.Equal(categoryToSelect, result);
        }
        
    }
}