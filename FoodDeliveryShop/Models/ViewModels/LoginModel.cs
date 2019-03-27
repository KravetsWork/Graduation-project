using System.ComponentModel.DataAnnotations;

namespace FoodDeliveryShop.Models.ViewModels
{
    /// <summary>
    /// View model for user credentials.
    /// </summary>
    public class LoginModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [UIHint("password")]
        public string Password { get; set; }

        public string ReturnUrl { get; set; } = "/";
    }
}
