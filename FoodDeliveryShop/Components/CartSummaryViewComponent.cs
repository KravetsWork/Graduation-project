using FoodDeliveryShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodDeliveryShop.Components
{
    /// <summary>
    /// This view component is able to take advantage of the service to get 
    /// the Cart object, taking it as a constructor argument. The result is 
    /// a simple view component that passes the Cart object to the View () method.
    /// </summary>
    public class CartSummaryViewComponent : ViewComponent
    {
        private Cart cart;

        public CartSummaryViewComponent(Cart cartService)
        {
            cart = cartService;
        }

        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}
