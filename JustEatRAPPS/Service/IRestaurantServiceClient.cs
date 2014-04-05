using System.Threading.Tasks;

namespace JustEatRAPPS.Service
{
    public interface IRestaurantServiceClient
    {
        Task<string> GetRestaurants(string postCode);
    }
}
