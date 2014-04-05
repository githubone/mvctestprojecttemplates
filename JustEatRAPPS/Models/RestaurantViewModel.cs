using System.Collections.Generic;

namespace JustEatRAPPS.Models
{
    public class RestaurantViewModel
    {
        public string Name { get; set; }

        public string AverageRating { get; set; }

        public string RestaurantLogo { get; set; }

        public string RestaurantLink { get; set; }

        public List<string> Products { get; set; }

    }
}