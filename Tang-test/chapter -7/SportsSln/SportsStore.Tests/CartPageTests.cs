using Moq;

//using Newtonsoft.Json;  // Be aware this package provide different Serialize method
using SportsStore.Models;
using SportsStore.Pages;
using System.Linq;
using Xunit;

namespace SportsStore.Tests
{
    public class CartPageTests
    {
        // Test onGet
        [Fact]
        public void Can_Load_Cart()
        {
            // arrange
            // -create mock repository

            var p1 = new Product { ProductId = 1, Name = "P1" };
            var p2 = new Product { ProductId = 2, Name = "P2" };
            var p3 = new Product { ProductId = 3, Name = "P3" };
            var products = new Product[] { p1, p2, p3 };

            var mockRepo = new Mock<IStoreRepository>();
            mockRepo.Setup(i => i.Products).Returns(products.AsQueryable<Product>());
            // -create a cart
            var testCart = new Cart();
            testCart.AddItem(p1, 2);
            testCart.AddItem(p2, 1);
            /* We don't need to think about how to mock Session any more   ============
            // - create a mock page context and session
            var mockSession = new Mock<ISession>();
            //For implement ISession, we need a byte[] -- to use TryGetValue()
            //See "bool TryGetValue(string key, out byte[] value)"
            byte[] data = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(testCart));

            // In reality, the Session value should be provided by the server
            // Here we mock a Session value whether the user provide any KEY
            mockSession.Setup(c => c.TryGetValue(It.IsAny<string>(), out data));

            var mockContext = new Mock<HttpContext>();
            mockContext.SetupGet(c => c.Session).Returns(mockSession.Object);

            ============================================================================*/
            //action

            var cartModel = new CartModel(mockRepo.Object, testCart);
            /*===========================================================
             we don't need to reconstruct a PageContext as do will not handle HttpContext anymore
            {
                //should understand how PageContext comprised of
                PageContext = new PageContext(new ActionContext
                {
                    HttpContext = mockContext.Object,
                    RouteData = new RouteData(),
                    // PageActionDescriptor is sub-class of ActionContext
                    ActionDescriptor = new PageActionDescriptor()
                })
            };

            =======================================================*/
            cartModel.OnGet("myUrl");
            //assertion

            Assert.Equal(2, cartModel.Cart.Lines.Count());
            Assert.Equal("myUrl", cartModel.ReturnUrl);
        }

        /// <summary>
        /// Test onPost()
        /// In this test, we don't care the Return Value, Our concern is if the Session has been updated
        /// after executing onPost
        /// </summary>
        [Fact]
        public void Can_Update_Cart()
        {
            //Arrange
            //-Create a mock repository
            var mockRepo = new Mock<IStoreRepository>();
            mockRepo.Setup(x => x.Products).Returns((new Product[]
            {
                new Product {ProductId = 1, Name = "P1"}
            }).AsQueryable<Product>());

            var testCart = new Cart();
            //https://stackoverflow.com/questions/2833162/can-you-help-me-understand-moq-callback

            /*=============================

            var mockSession = new Mock<ISession>();

            // Try to understand how this Callback Works
            mockSession
                .Setup(s => s.Set(It.IsAny<string>(), It.IsAny<byte[]>()))
                .Callback<string, byte[]>((key, value) =>
                {
                    testCart = JsonSerializer.Deserialize<Cart>(Encoding.UTF8.GetString(value));
                });

            var mockContext = new Mock<HttpContext>();

            mockContext.SetupGet(c => c.Session).Returns(mockSession.Object);
            =========================================================================================*/

            //Action
            var cartModel = new CartModel(mockRepo.Object, testCart);
            /*====================================
            {
                PageContext = new PageContext(new ActionContext
                {
                    HttpContext = mockContext.Object,
                    RouteData = new RouteData(),
                    ActionDescriptor = new PageActionDescriptor()
                })
            };
            =====================================*/
            cartModel.OnPost(1, "myUrl");
            //Assert
            Assert.Single(testCart.Lines);
            Assert.Equal("P1", testCart.Lines.FirstOrDefault()?.Product.Name);
            Assert.Equal(1, testCart.Lines.FirstOrDefault()?.Quantity);
        }
    }
}