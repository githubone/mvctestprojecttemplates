using System.Collections.Generic;

namespace JustEatRAPPS.Models
{
    public class RestaurantViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public double RatingStars { get; set; }

        public string RestaurantLogo { get; set; }

        public string Url { get; set; }

        public List<string> ErrorMessages { get; set; }
    }
  
}