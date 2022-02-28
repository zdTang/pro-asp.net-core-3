using System.Collections.Generic;
using System.Linq;

namespace SportsStore.Models
{
    /// <summary>
    /// This class represents a Cart
    /// A data collection is used as Container
    /// A bunch of methods are created for modifying the Container
    /// Is this the best practice ???
    /// </summary>
    
    public class Cart
    {
        public List<CartLine> Lines { set; get; } = new List<CartLine>();

        // For adding a new Item, check if the item was in the List
        // if No, then add the new Item 
        // if Yes, means the user want more same items so that increase the quantity
        public virtual void AddItem(Product product, int quantity)
        {
            CartLine line = Lines.Where(p => p.Product.ProductId == product.ProductId)?.FirstOrDefault();
            if (line == null) // not in the List so that we put it in.
            {
                Lines.Add(new CartLine{Product = product,Quantity = quantity});
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public virtual void RemoveLine(Product product) => Lines.RemoveAll(l => l.Product.ProductId == product.ProductId);

        public decimal ComputedTotalValue() => Lines.Sum(e => e.Quantity * e.Product.Price);

        public virtual void Clear() => Lines.Clear();
    }

    
    /// <summary>
    /// This class represents a product selected by the customer
    /// </summary>
    public class CartLine
    {
        public int CartLineId { set; get; }
        public Product Product { set; get; }
        public int Quantity { set; get; }
    }
}