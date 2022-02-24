using System.Linq;
using SportsStore.Models;
using Xunit;

namespace SportsStore.Tests
{
    public class CartTests
    {
        [Fact]
        public void Can_Add_New_Lines()
        {
            //arrange
            var p1 = new Product {ProductId = 1,Name = "P1"};
            var p2 = new Product {ProductId = 2,Name = "P1"};
            var cart = new Cart();
            //action
            cart.AddItem(p1,1);
            cart.AddItem(p2,1);
            cart.AddItem(p2,2);
            //assert
            Assert.Equal(2,cart.Lines.Count);
            Assert.Equal(3,cart?.Lines.Where(x=>x.Product.ProductId==2)?.FirstOrDefault()?.Quantity);
            Assert.Equal(1,cart?.Lines.Where(x=>x.Product.ProductId==1)?.FirstOrDefault()?.Quantity);
        }

        [Fact]
        public void Can_Remove_Line()
        {
            //arrange
            var p1 = new Product {ProductId = 1,Name = "P1"};
            var p2 = new Product {ProductId = 2,Name = "P2"};
            var cart = new Cart();
            //action
            cart.AddItem(p1,1);
            cart.AddItem(p2,1);
            cart.AddItem(p2,2);
            cart.RemoveLine(p1);
            var result = cart?.Lines.ToArray();
            
            //assert
            Assert.Single(cart.Lines);
            Assert.Equal(2,result[0].Product.ProductId);
            Assert.Equal(3,result[0].Quantity);
        }
        
        [Fact]
        public void Can_Calculate_Cart_Total()
        {
            //arrange
            var p1 = new Product {ProductId = 1,Name = "P1",Price = 100};
            var p2 = new Product {ProductId = 2,Name = "P1",Price = 20};
            var cart = new Cart();
            //action
            cart.AddItem(p1,1);
            cart.AddItem(p2,1);
            cart.AddItem(p2,2);
            decimal result = cart.ComputedTotalValue();
            
            //assert

            Assert.Equal(160,result);

        }
        
        [Fact]
        public void Can_Clear_Cart()
        {
            //arrange
            var p1 = new Product {ProductId = 1,Name = "P1",Price = 100};
            var p2 = new Product {ProductId = 2,Name = "P1",Price = 20};
            var cart = new Cart();
            //action
            cart.AddItem(p1,1);
            cart.AddItem(p2,1);
            cart.AddItem(p2,2);
            cart.Clear();
            
            //assert

            Assert.Equal(0,cart?.Lines.Count);
            Assert.Empty(cart?.Lines);

        }
    }
}