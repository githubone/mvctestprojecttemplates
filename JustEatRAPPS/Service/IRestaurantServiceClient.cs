using JustEatRAPPS.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JustEatRAPPS.Service
{
    public interface IRestaurantServiceClient
    {
        Task<List<RestaurantViewModel>> GetRestaurants(string postCode);
    }
}
