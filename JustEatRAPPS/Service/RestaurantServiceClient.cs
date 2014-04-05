using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace JustEatRAPPS.Service
{
    public class RestaurantServiceClient : IRestaurantServiceClient
    {
        //http://api.just-eat.com/restaurants?q=se19
        private const string SERVICE_BASE_PATH = "http://api.just-eat.com/restaurants";
        
        public async Task<string>  GetRestaurants(string postCode)
        {
            string servicePath  = new UriBuilder(SERVICE_BASE_PATH) {Query = string.Concat("q=", postCode)}.ToString();
            using (var client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "VGVjaFRlc3RBUEk6dXNlcjI=");
                    client.DefaultRequestHeaders.Add("Accept-Tenant", "uk");
                   // client.DefaultRequestHeaders.Add("Accept-Language", "en-GB");
                   // client.DefaultRequestHeaders.Add("Accept-Charset", "utf-8");

                    var response = await client.GetStringAsync("http://api.just-eat.com/restaurants?q=se19");

                    return response;


                }
                catch (Exception exception)
                {

                    System.Diagnostics.Debug.WriteLine(exception.Message);
                    // log error message with 
                    return null;

                }
              


            }
        }

        private string GetServicePath(string postCode)
        {
            return new UriBuilder(SERVICE_BASE_PATH) {Query = string.Concat("q=", postCode)}.ToString();

        }
    }

  
}