using System.Collections.Generic;
using System.Linq;

namespace FoodDeliveryShop.Models
{
    /// <summary>
    /// The Cart class uses the CartLine class, which is defined in the same file.
    /// and represents the product selected by the user, as well as the quantity purchased. 
    /// We defined methods for adding an item to the cart, deleting an item
    /// that of the basket, calculating the total cost of items in the basket and emptying the basket
    /// by removing all items.We also provided a property that allows
    /// access the contents of the cart using IEnumerable <CartLine>.
    /// </summary>
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();
        public virtual void AddItem(Product product, int quantity)
        {
            CartLine line = lineCollection
            .Where(p => p.Product.ProductID == product.ProductID)
            .FirstOrDefault();
            if (line == null)
            {
                lineCollection.Add(new CartLine
                {
                    Product = product,
                    Quantity = quantity
                });
            }

            else
            {
                line.Quantity += quantity;
            }
        }

        public virtual void RemoveLine(Product product) =>
        lineCollection.RemoveAll(l => l.Product.ProductID == product.ProductID);

        public virtual decimal ComputeTotalValue() =>
        lineCollection.Sum(e => e.Product.Price * e.Quantity);

        public virtual void Clear() => lineCollection.Clear();

        public virtual IEnumerable<CartLine> Lines => lineCollection;
    }

    public class CartLine
    {
        public int CartLineID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
