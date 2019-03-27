using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FoodDeliveryShop.Models
{
    /// <summary>
    /// The database context class acts as a gateway between the database
    /// and the Identity model objects that provide access to it.
    /// </summary>
    public class AppIdentityDbContext : IdentityDbContext<IdentityUser>
    {
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options)
        : base(options) { }
    }
}
