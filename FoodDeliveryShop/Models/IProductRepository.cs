using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryShop.Models
{
    /// <summary>
    /// The interface uses IEnumerable <T> to allow the calling code to obtain a sequence 
    /// of Product objects without reporting  how or where data is stored or retrieved.
    /// </summary>
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }

        void SaveProduct(Product product);

        Product DeleteProduct(int productId);
    }
}
