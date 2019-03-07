using FoodDeliveryShop.Models;  
using Microsoft.AspNetCore.Mvc;  
  
namespace FoodDeliveryShop.Controllers  
{  
    public class OrderController : Controller  
    {  
        public ViewResult Checkout() => View(new Order());  
    }  
} 
