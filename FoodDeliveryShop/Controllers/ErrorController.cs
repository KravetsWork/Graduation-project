using Microsoft.AspNetCore.Mvc;

namespace FoodDeliveryShop.Controllers
{
    /// <summary>
    /// The controller that is responsible for displaying errors.
    /// </summary>
    public class ErrorController : Controller
    {
        public ViewResult Error() => View();
    }
}
