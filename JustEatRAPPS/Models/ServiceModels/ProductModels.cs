using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JustEatRAPPS.Models
{
    public class ProductModels
    {
        internal class ProductModel
        {
            [JsonProperty("Products")]
            public Product[] Products { get; set; }
        }

        internal class Product
        {

            [JsonProperty("Id")]
            public int Id { get; set; }

            [JsonProperty("Name")]
            public string Name { get; set; }

            [JsonProperty("Synonym")]
            public string Synonym { get; set; }

            [JsonProperty("Description")]
            public string Description { get; set; }

            [JsonProperty("RestaurantMenuNumber")]
            public int RestaurantMenuNumber { get; set; }

            [JsonProperty("RestaurantMenuNumberCode")]
            public string RestaurantMenuNumberCode { get; set; }

            [JsonProperty("Price")]
            public double Price { get; set; }

            [JsonProperty("HasComboOptions")]
            public bool HasComboOptions { get; set; }

            [JsonProperty("HasAccessories")]
            public bool HasAccessories { get; set; }

            [JsonProperty("HasRequiredAccessories")]
            public bool HasRequiredAccessories { get; set; }

            [JsonProperty("ComboOptions")]
            public object ComboOptions { get; set; }

            [JsonProperty("Accessories")]
            public object Accessories { get; set; }

            [JsonProperty("ContainsNuts")]
            public bool ContainsNuts { get; set; }

            [JsonProperty("IsVegetarian")]
            public bool IsVegetarian { get; set; }

            [JsonProperty("IsSpicy")]
            public bool IsSpicy { get; set; }

            [JsonProperty("RequireOtherProducts")]
            public bool RequireOtherProducts { get; set; }
        }
    }

}