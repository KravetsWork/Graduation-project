using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryShop.Models.ViewModels
{
    /// <summary>
    /// The view model class that is used to transfer data between the controller 
    /// and the view. And conveys information about the number of pages available, 
    /// current page and total number of items in the repository.
    /// </summary>
    public class PagingInfo
    {
        public int TotalItems { get; set; }  
	    public int ItemsPerPage { get; set; }  
	    public int CurrentPage { get; set; }  
	    public int TotalPages =>
            (int)Math.Ceiling((decimal) TotalItems / ItemsPerPage);  
    }
}
