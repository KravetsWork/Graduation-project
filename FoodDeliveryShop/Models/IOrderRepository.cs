using System.Collections.Generic;

namespace FoodDeliveryShop.Models
{
    /// <summary>
    /// The interface uses IEnumerable <T> to allow the calling code to obtain a sequence 
    /// of Product objects without reporting  how or where data is stored or retrieved.
    /// </summary>
    public interface IOrderRepository
    {
        IEnumerable<Order> Orders { get; }

        void SaveOrder(Order order);
    }
}
