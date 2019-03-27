using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace FoodDeliveryShop.Models
{
    /// <summary>
    /// Class that creates the Admin user, filling the database 
    /// with initial data when the application is started.
    /// </summary>
    public static class IdentitySeedData
    {
        private const string adminUser = "Admin";
        private const string adminPassword = "Secret123$";
        public static async Task EnsurePopulated(UserManager<IdentityUser> userManager)
        {
            IdentityUser user = await userManager.FindByIdAsync(adminUser);
            if (user == null)
            {
                user = new IdentityUser("Admin");
                await userManager.CreateAsync(user, adminPassword);
            }
        }
    }
}
