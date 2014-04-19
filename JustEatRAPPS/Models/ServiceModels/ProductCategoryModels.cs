using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JustEatRAPPS.Models
{
    public class ProductCategoryModels
    {
        internal class ProductCategoryModel
        {

            [JsonProperty("Categories")]
            public Category[] Categories { get; set; }
        }

        internal class Category
        {

            [JsonProperty("Bogof")]
            public bool Bogof { get; set; }

            [JsonProperty("Bogohp")]
            public bool Bogohp { get; set; }

            [JsonProperty("Id")]
            public int Id { get; set; }

            [JsonProperty("Name")]
            public string Name { get; set; }

            [JsonProperty("Notes")]
            public string Notes { get; set; }

            [JsonProperty("BackgroundImageUrl")]
            public object BackgroundImageUrl { get; set; }

            [JsonProperty("Sort")]
            public int Sort { get; set; }

            [JsonProperty("Columns")]
            public int Columns { get; set; }
        }
    }
}

