

using System.Threading.Tasks;
using System.Web.Mvc;
using JustEatRAPPS.Service;

namespace JustEatRAPPS.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantServiceClient restaurantServiceClient;
        public HomeController(IRestaurantServiceClient restaurantServiceClient)
        {
            this.restaurantServiceClient = restaurantServiceClient;
        }

        public async Task<ActionResult> Index()
        {
           // ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
           
            var result = await restaurantServiceClient.GetRestaurants("se19");
            return View();
        }

        public ActionResult Search()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

       
    }
}
