using Newtonsoft.Json;

 
namespace JustEatRAPPS.Models
{
    /// <summary>
    /// Note:
    /// Auto Generated using JSON c# Class generator
    /// </summary>
    public class RestaurantModels
    {
        internal class RestaurantModel
        {

            [JsonProperty("ShortResultText")]
            public string ShortResultText { get; set; }

            [JsonProperty("Restaurants")]
            public Restaurant[] Restaurants { get; set; }
        }

        internal class Restaurant
        {

            [JsonProperty("Id")]
            public int Id { get; set; }

            [JsonProperty("Name")]
            public string Name { get; set; }

            [JsonProperty("Address")]
            public string Address { get; set; }

            [JsonProperty("Postcode")]
            public string Postcode { get; set; }

            [JsonProperty("City")]
            public string City { get; set; }

            [JsonProperty("CuisineTypes")]
            public CuisineType[] CuisineTypes { get; set; }

            [JsonProperty("Url")]
            public string Url { get; set; }

            [JsonProperty("IsOpenNow")]
            public bool IsOpenNow { get; set; }

            [JsonProperty("IsSponsored")]
            public bool IsSponsored { get; set; }

            [JsonProperty("IsNew")]
            public bool IsNew { get; set; }

            [JsonProperty("IsTemporarilyOffline")]
            public bool IsTemporarilyOffline { get; set; }

            [JsonProperty("ReasonWhyTemporarilyOffline")]
            public string ReasonWhyTemporarilyOffline { get; set; }

            [JsonProperty("UniqueName")]
            public string UniqueName { get; set; }

            [JsonProperty("IsCloseBy")]
            public bool IsCloseBy { get; set; }

            [JsonProperty("IsHalal")]
            public bool IsHalal { get; set; }

            [JsonProperty("DefaultDisplayRank")]
            public int DefaultDisplayRank { get; set; }

            [JsonProperty("IsOpenNowForDelivery")]
            public bool IsOpenNowForDelivery { get; set; }

            [JsonProperty("IsOpenNowForCollection")]
            public bool IsOpenNowForCollection { get; set; }

            [JsonProperty("RatingStars")]
            public double RatingStars { get; set; }

            [JsonProperty("Logo")]
            public Logo[] Logo { get; set; }

            [JsonProperty("Deals")]
            public Deal[] Deals { get; set; }

            [JsonProperty("NumberOfRatings")]
            public int NumberOfRatings { get; set; }
        }

        internal class CuisineType
        {

            [JsonProperty("Id")]
            public int Id { get; set; }

            [JsonProperty("Name")]
            public string Name { get; set; }

            [JsonProperty("SeoName")]
            public object SeoName { get; set; }
        }

        internal class Deal
        {

            [JsonProperty("Description")]
            public string Description { get; set; }

            [JsonProperty("DiscountPercent")]
            public string DiscountPercent { get; set; }

            [JsonProperty("QualifyingPrice")]
            public string QualifyingPrice { get; set; }
        }

        internal class Logo
        {

            [JsonProperty("StandardResolutionURL")]
            public string StandardResolutionURL { get; set; }
        }

    }


}