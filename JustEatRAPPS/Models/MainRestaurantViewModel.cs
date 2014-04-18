using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JustEatRAPPS.Models
{
    public class MainRestaurantViewModel
    {
        public List<RestaurantViewModel> Restaurants { get; set; }

        [Required(ErrorMessage = "Post Code required")]
        public string PostCode { get; set; }

    }
}