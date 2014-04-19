using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JustEatRAPPS.Models
{
    public class ProductViewModel
    {
        public string Name { get; set; }

        public string RestaurantMenuNumber { get; set; }

        public int RestaurantId { get; set; }

        public string ProductDescription{get{return String.Concat(Name, "-", RestaurantMenuNumber);}
        }
    }
}