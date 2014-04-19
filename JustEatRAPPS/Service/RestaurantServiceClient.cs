using AutoMapper;
using JustEatRAPPS.Common;
using JustEatRAPPS.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using RestModel = JustEatRAPPS.Models.RestaurantModels;
using ProductModel = JustEatRAPPS.Models.ProductModels;

namespace JustEatRAPPS.Service
{
   public class RestaurantServiceClient : IRestaurantServiceClient
   {
       public async Task<List<RestaurantViewModel>>  GetRestaurants(string postCode)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    AttachHeaders(client);
                    var restaurantQueryUrl = GetRestaurantsQueryUrl(postCode);
                    var response = await client.GetStringAsync(restaurantQueryUrl);
                    RestModel.RestaurantModel items = JsonConvert.DeserializeObject<RestModel.RestaurantModel>(response);
                    return Mapper.Map<List<RestModel.Restaurant>, List<RestaurantViewModel>>(items.Restaurants.ToList());
                }
                catch (Exception ex)
                {
                    // log error
                    return null;
                }
            }
        }

       public async Task<List<ProductViewModel>> GetProducts(string restaurantId)
       {
           // NOTE:
           // There should be three calls to the Api to retrieve all products for a restaurant 
           // (1) http://api-interview.just-eat.com/restaurants/17266/menus
           // (2) http://api-interview.just-eat.com/menus/57443/productcategories
           // (3) http://api-interview.just-eat.com/menus/57443/productcategories/5/products
           // I have omitted calls (1)  and (2) due to time constraint
           // This method now only illustrate the retrieval of producsts using hard code queries


           using (var client = new HttpClient())
           {
               try
               {
                   AttachHeaders(client);
                   var productsQueryUrl = GetProductsQueryUrl(restaurantId);
                   var response = await client.GetStringAsync(productsQueryUrl);
                   ProductModel.ProductModel items = JsonConvert.DeserializeObject<ProductModel.ProductModel>(response);
                   return Mapper.Map<List<ProductModel.Product>, List<ProductViewModel>>(items.Products.ToList());
               }
               catch (Exception ex)
               {
                   // log error
                   return null;
               }

           }

       }

       private string GetProductsQueryUrl(string restaurantId)
       {
           return "http://api-interview.just-eat.com/menus/112991/productcategories/5/products";
       }

       private string GetRestaurantsQueryUrl(string postCode)
       {
           return string.Concat("http://api-interview.just-eat.com/restaurants?q=", postCode);
       }

       private void AttachHeaders(HttpClient client)
        {
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "VGVjaFRlc3RBUEk6dXNlcjI=");
            client.DefaultRequestHeaders.Add("Accept-Tenant", "uk");
            client.DefaultRequestHeaders.Add("Accept-Language", "en-GB");
            client.DefaultRequestHeaders.Add("Accept-Charset", "utf-8");
        }
    }
}