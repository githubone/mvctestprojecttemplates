using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JustEatRAPPS.Models
{
    public class MenuModels
    {
        [JsonProperty("Menus")]
        public Menu[] Menus { get; set; }

        public class Menu
        {

            [JsonProperty("Id")]
            public int Id { get; set; }

            [JsonProperty("RestaurantId")]
            public int RestaurantId { get; set; }

            [JsonProperty("Title")]
            public string Title { get; set; }

            [JsonProperty("Description")]
            public string Description { get; set; }

            [JsonProperty("Type")]
            public Type Type { get; set; }

            [JsonProperty("PickupOrDeliveryTime")]
            public PickupOrDeliveryTime PickupOrDeliveryTime { get; set; }

            [JsonProperty("AvailableDuring")]
            public AvailableDuring AvailableDuring { get; set; }

            [JsonProperty("DeliveryCostBelowThreshold")]
            public double DeliveryCostBelowThreshold { get; set; }

            [JsonProperty("DeliveryCostAboveThreshold")]
            public double DeliveryCostAboveThreshold { get; set; }

            [JsonProperty("DeliveryThresholdOrderAmount")]
            public double DeliveryThresholdOrderAmount { get; set; }

            [JsonProperty("ClosingWorkTime")]
            public string ClosingWorkTime { get; set; }

            [JsonProperty("DeliveryCostExamples")]
            public object DeliveryCostExamples { get; set; }

            [JsonProperty("CustomerReviewsSummary")]
            public object CustomerReviewsSummary { get; set; }

            [JsonProperty("Categories")]
            public object Categories { get; set; }

            [JsonProperty("Products")]
            public object Products { get; set; }
        }

        public class AvailableDuring
        {

            [JsonProperty("Monday")]
            public Monday Monday { get; set; }

            [JsonProperty("Tuesday")]
            public Tuesday Tuesday { get; set; }

            [JsonProperty("Wednesday")]
            public Wednesday Wednesday { get; set; }

            [JsonProperty("Thursday")]
            public Thursday Thursday { get; set; }

            [JsonProperty("Friday")]
            public Friday Friday { get; set; }

            [JsonProperty("Saturday")]
            public Saturday Saturday { get; set; }

            [JsonProperty("Sunday")]
            public Sunday Sunday { get; set; }
        }

        public class PickupOrDeliveryTime
        {

            [JsonProperty("Monday")]
            public string Monday { get; set; }

            [JsonProperty("Tuesday")]
            public string Tuesday { get; set; }

            [JsonProperty("Wednesday")]
            public string Wednesday { get; set; }

            [JsonProperty("Thursday")]
            public string Thursday { get; set; }

            [JsonProperty("Friday")]
            public string Friday { get; set; }

            [JsonProperty("Saturday")]
            public string Saturday { get; set; }

            [JsonProperty("Sunday")]
            public string Sunday { get; set; }
        }

        public class Monday
        {

            [JsonProperty("OpeningTime")]
            public string OpeningTime { get; set; }

            [JsonProperty("ClosingTime")]
            public string ClosingTime { get; set; }

            [JsonProperty("Status")]
            public int Status { get; set; }
        }

        public class Tuesday
        {

            [JsonProperty("OpeningTime")]
            public string OpeningTime { get; set; }

            [JsonProperty("ClosingTime")]
            public string ClosingTime { get; set; }

            [JsonProperty("Status")]
            public int Status { get; set; }
        }

        public class Wednesday
        {

            [JsonProperty("OpeningTime")]
            public string OpeningTime { get; set; }

            [JsonProperty("ClosingTime")]
            public string ClosingTime { get; set; }

            [JsonProperty("Status")]
            public int Status { get; set; }
        }

        public class Thursday
        {

            [JsonProperty("OpeningTime")]
            public string OpeningTime { get; set; }

            [JsonProperty("ClosingTime")]
            public string ClosingTime { get; set; }

            [JsonProperty("Status")]
            public int Status { get; set; }
        }

        public class Friday
        {

            [JsonProperty("OpeningTime")]
            public string OpeningTime { get; set; }

            [JsonProperty("ClosingTime")]
            public string ClosingTime { get; set; }

            [JsonProperty("Status")]
            public int Status { get; set; }
        }

        public class Saturday
        {

            [JsonProperty("OpeningTime")]
            public string OpeningTime { get; set; }

            [JsonProperty("ClosingTime")]
            public string ClosingTime { get; set; }

            [JsonProperty("Status")]
            public int Status { get; set; }
        }

        public class Sunday
        {

            [JsonProperty("OpeningTime")]
            public string OpeningTime { get; set; }

            [JsonProperty("ClosingTime")]
            public string ClosingTime { get; set; }

            [JsonProperty("Status")]
            public int Status { get; set; }
        }

    }
}


