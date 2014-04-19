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
using MenuModel = JustEatRAPPS.Models.MenuModels;
using ProductCategoryModel = JustEatRAPPS.Models.ProductCategoryModels;
using ProductModel = JustEatRAPPS.Models.ProductModels;

namespace JustEatRAPPS.Service
{
   public class RestaurantServiceClient : IRestaurantServiceClient
   {
       public async Task<List<RestaurantViewModel>>  GetRestaurants(string postCode)
        {
            //using (var client = new HttpClient())
            //{
            //    try
            //    {
            //        AttachHeaders(client);
            //        var restaurantQueryUrl = GetRestaurantsQueryUrl(postCode);
            //        var response = await client.GetStringAsync(restaurantQueryUrl);
            //        RestModel.RestaurantModel items = JsonConvert.DeserializeObject<RestModel.RestaurantModel>(response);
            //        return Mapper.Map<List<RestModel.Restaurant>, List<RestaurantViewModel>>(items.Restaurants.ToList());
            //    }
            //    catch (Exception ex)
            //    {
            //        // log error
            //        return null;
            //    }
            //}


            string path = System.AppDomain.CurrentDomain.BaseDirectory + "App_Data";
            string filePath = Path.Combine(path, "jsondata.dat");
            if (File.Exists(filePath))
            {
                
                RestModel.RestaurantModel restaurantModel = await ReadJsonRestaurant(filePath);
                var results = Mapper.Map<List<RestModel.Restaurant>, List<RestaurantViewModel>>(restaurantModel.Restaurants.ToList());
                return results;
            }
            return null;
        }

      

       public async Task<List<MenuModel.Menu>> GetMenus(string restaurantId)
       {
           //using (var client = new HttpClient())
           //{
           //    try
           //    {
           //        AttachHeaders(client);
           //        var menusQueryUrl = GetMenusQueryUrl(restaurantId);
           //        var response = await client.GetStringAsync(menusQueryUrl);
           //        RestModel.RestaurantModel items = JsonConvert.DeserializeObject<RestModel.RestaurantModel>(response);
           //        return Mapper.Map<List<RestModel.Restaurant>, List<RestaurantViewModel>>(items.Restaurants.ToList());
           //    }
           //    catch (Exception ex)
           //    {
           //        // log error
           //        return new List<RestaurantViewModel>();
           //    }
           //}
           string path = System.AppDomain.CurrentDomain.BaseDirectory + "App_Data";
           string filePath = Path.Combine(path, "jsondata2.dat");
           if (File.Exists(filePath))
           {
               //string result = await ReadTextAsync(filePath);
               MenuModels.Menu[] menus = await ReadJsonRestaurantMenu(filePath);
               
              
           }
           return null;
       }

       private string GetMenusQueryUrl(string restaurantId)
       {
           return string.Concat(ServicePaths.QUERY_PATH, restaurantId, "/Menus");
       }

        private string GetRestaurantsQueryUrl(string postCode)
        {
            return string.Concat(ServicePaths.RESTAURANT_QUERY_PATH, postCode);
        }

        private void AttachHeaders(HttpClient client)
        {
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "VGVjaFRlc3RBUEk6dXNlcjI=");
            client.DefaultRequestHeaders.Add("Accept-Tenant", "uk");
            client.DefaultRequestHeaders.Add("Accept-Language", "en-GB");
            client.DefaultRequestHeaders.Add("Accept-Charset", "utf-8");
        }

        private async Task<RestModel.RestaurantModel> ReadJsonRestaurant(string filePath)
        {

            using (StreamReader r = new StreamReader(filePath))
            {
                string json = await r.ReadToEndAsync();
                RestModel.RestaurantModel items = JsonConvert.DeserializeObject<RestModel.RestaurantModel>(json);
                return items;
            }
        }

        private async Task<MenuModels.Menu[]> ReadJsonRestaurantMenu(string filePath)
        {

            using (StreamReader r = new StreamReader(filePath))
            {
                string json = await r.ReadToEndAsync();
                MenuModels.Menu[] items = JsonConvert.DeserializeObject<MenuModels.Menu[]>(json);
                return items;
            }
        }

        private async Task<ProductCategoryModel.ProductCategoryModel> ReadJsonProductCategoryModel(string filePath)
        {

            using (StreamReader r = new StreamReader(filePath))
            {
                string json = await r.ReadToEndAsync();
                ProductCategoryModel.ProductCategoryModel items = JsonConvert.DeserializeObject<ProductCategoryModel.ProductCategoryModel>(json);
                return items;
            }
        }

        private async Task<ProductModel.ProductModel> ReadJsonProductCategory(string filePath)
        {

            using (StreamReader r = new StreamReader(filePath))
            {
                string json = await r.ReadToEndAsync();
                ProductModel.ProductModel items = JsonConvert.DeserializeObject<ProductModel.ProductModel>(json);
                return items;
            }
        }

       
        private async Task<string> ReadTextAsync(string filePath)
        {
            using (FileStream sourceStream = new FileStream(filePath,
                FileMode.Open, FileAccess.Read, FileShare.Read,
                bufferSize: 4096, useAsync: true))
            {
                StringBuilder sb = new StringBuilder();

                byte[] buffer = new byte[0x1000];
                int numRead;
                while ((numRead = await sourceStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                {
                    string text = Encoding.Unicode.GetString(buffer, 0, numRead);
                    sb.Append(text);
                }

                return sb.ToString();
            }
        }

    }
}