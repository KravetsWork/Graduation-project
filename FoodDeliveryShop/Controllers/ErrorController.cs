using Microsoft.AspNetCore.Mvc;

namespace FoodDeliveryShop.Controllers
{
    public class ErrorController : Controller
    {
        public ViewResult Error() => View();
    }
}
