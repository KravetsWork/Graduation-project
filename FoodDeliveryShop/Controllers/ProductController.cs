using System.Linq;
using FoodDeliveryShop.Models;
using FoodDeliveryShop.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FoodDeliveryShop.Controllers
{
    /// <summary>
    /// The controller that is responsible for displaying the products.
    /// </summary>
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public int PageSize = 4;

        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }

        public ViewResult List(string category, int productPage = 1)
             => View(new ProductsListViewModel
             {
                 Products = repository.Products
                    .Where(p => category == null || p.Category == category)
                    .OrderBy(p => p.ProductID)
                    .Skip((productPage - 1) * PageSize)
                    .Take(PageSize),
                 PagingInfo = new PagingInfo
                 {
                     CurrentPage = productPage,
                     ItemsPerPage = PageSize,
                     TotalItems = category == null 
                        ? repository.Products.Count() 
                        : repository.Products.Where(e =>
                            e.Category == category).Count()
                 },

                 CurrentCategory = category
             });
    }
}
