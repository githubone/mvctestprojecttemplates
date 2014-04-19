using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JustEatRAPPS.Models
{
    public class MainProductViewModel
    {
        public List<ProductViewModel> Products { get; set; }
        
        public string RestaurantId { get; set; }
    }
}