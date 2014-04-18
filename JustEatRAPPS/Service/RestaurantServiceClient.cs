using System.Text.RegularExpressions;
using AutoMapper;
using JustEatRAPPS.Models;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using RestModel = JustEatRAPPS.Models.RestaurantModels;
using System.Linq;
using System.Collections.Generic;


namespace JustEatRAPPS.Service
{
    public class RestaurantServiceClient : IRestaurantServiceClient
    {
        //http://api.just-eat.com/restaurants?q=se19
        private const string SERVICE_BASE_PATH = "http://api.just-eat.com/restaurants";
        
        public async Task<List<RestaurantViewModel>>  GetRestaurants(string postCode)
        {
            //if (ValidatePostcode(postCode))
            //{

            //}

            // string servicePath  = new UriBuilder(SERVICE_BASE_PATH) {Query = string.Concat("q=", postCode)}.ToString();
            //using (var client = new HttpClient())
            //{
            //    try
            //    {
            //        client.DefaultRequestHeaders.Add("Accept", "application/json");
            //        client.DefaultRequestHeaders.Add("Content-Type", "application/json");
            //        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "VGVjaFRlc3RBUEk6dXNlcjI=");
            //        client.DefaultRequestHeaders.Add("Accept-Tenant", "uk");
            //      client.DefaultRequestHeaders.Add("Accept-Language", "en-GB");
            //       client.DefaultRequestHeaders.Add("Accept-Charset", "utf-8");

            //        var response = await client.GetStringAsync("http://api.just-eat.com/restaurants?q=se19");


            //        return null;


            //    }
            //    catch (Exception exception)
            //    {

            //        System.Diagnostics.Debug.WriteLine(exception.Message);
            //         log error message with 
            //        return null;

            //    }



            //}
            //string path = System.AppDomain.CurrentDomain.BaseDirectory + "App_Data";
            //string filePath = Path.Combine(path, "jsondata.dat");
            //if (File.Exists(filePath))
            //{
            //    //string result = await ReadTextAsync(filePath);
            //    RestModel.RestaurantModel restaurantModel = await ReadJsonRestaurant(filePath);
            //    var results = Mapper.Map<List<RestModel.Restaurant>, List<RestaurantViewModel>>(restaurantModel.Restaurants.ToList());
            //    return results;
            //}
            //return null;

            //using (var client = new HttpClient())
            //{
            //   try
            //    {

            //        client.BaseAddress = new Uri("http://api.just-eat.com/");
            //        client.DefaultRequestHeaders.Add("Accept", "application/json");
            //        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "VGVjaFRlc3RBUEk6dXNlcjI=");
            //        client.DefaultRequestHeaders.Add("Accept-Tenant", "uk");
            //        client.DefaultRequestHeaders.Add("Accept-Language", "en-GB");
            //        client.DefaultRequestHeaders.Add("Accept-Charset", "utf-8");

            //        HttpResponseMessage response = await client.GetAsync("restaurants?q=se19");
            //        response.EnsureSuccessStatusCode();
            //        var result = await response.Content.ReadAsStringAsync();
            //        return null;
                    
            //    }
            //    catch (HttpRequestException exception)
            //    {
            //        System.Diagnostics.Debug.WriteLine(exception.Message);
            //         log error

            //        return null;

            //    }
            //}

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

        private string GetServicePath(string postCode)
        {
            return new UriBuilder(SERVICE_BASE_PATH) {Query = string.Concat("q=", postCode)}.ToString();
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

        private bool ValidatePostcode(string postcode)
        {
            Regex regex = new Regex("^(GIR 0AA|[A-PR-UWYZ]([0-9]{1,2}|([A-HK-Y][0-9]|[A-HK-Y][0-9]([0-9]|[ABEHMNPRV-Y]))|[0-9][A-HJKPS-UW]) {0,1}[0-9][ABD-HJLNP-UW-Z]{2})$");
            return regex.IsMatch(postcode.ToUpper().Trim());
        }

    }

  
}