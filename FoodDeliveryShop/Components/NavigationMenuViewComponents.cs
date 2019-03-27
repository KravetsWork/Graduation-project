using Microsoft.AspNetCore.Mvc;
using System.Linq;
using FoodDeliveryShop.Models;

namespace FoodDeliveryShop.Components
{
    /// <summary>
    /// Class responsible for the correct display of goods on the page.
    /// </summary>
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IProductRepository repository;

        public NavigationMenuViewComponent(IProductRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Products
            .Select(x => x.Category)
            .Distinct()
            .OrderBy(x => x));
        }
    }
}
