﻿using System.Threading.Tasks;
using System.Web.Mvc;
using JustEatRAPPS.Models;
using JustEatRAPPS.Service;
using System.Web;
using JustEatRAPPS.Controllers;
using JustEatRAPPS.Common;
using System.Text.RegularExpressions;
using System;

[assembly: PreApplicationStartMethod(typeof(HomeController), "Initialize")]
namespace JustEatRAPPS.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantServiceClient restaurantServiceClient;

        public static void Initialize()
        {
            AutoMapperConfig.Configure();
        }
        public HomeController(IRestaurantServiceClient restaurantServiceClient)
        {
            this.restaurantServiceClient = restaurantServiceClient;
        }

        public ActionResult Index()
        {
            var mainRestaurantViewModel = new MainRestaurantViewModel() { PostCode = "se19" };
            return View(mainRestaurantViewModel);
        }

        [HttpPost]
        [ActionName("Index")]
        public async Task<ActionResult> Search(MainRestaurantViewModel mainRestaurantViewModel)
        {
            if (mainRestaurantViewModel == null || string.IsNullOrEmpty(mainRestaurantViewModel.PostCode))
            {
                throw new ArgumentNullException("MainRestaurantViewModel");
            }

            var result = await restaurantServiceClient.GetRestaurants(mainRestaurantViewModel.PostCode);
            mainRestaurantViewModel.Restaurants = result;
            return View(mainRestaurantViewModel);
        }

        [HttpPost]
        public async Task<ActionResult> Products(MainProductViewModel mainProductViewModel)
        {
            if (mainProductViewModel == null || string.IsNullOrEmpty(mainProductViewModel.RestaurantId))
            {
                throw new ArgumentNullException("MainProductViewModel");
            }

            var products = await restaurantServiceClient.GetProducts(mainProductViewModel.RestaurantId);
            mainProductViewModel.Products = products;
            return PartialView("_Products", mainProductViewModel);
        }
    }
}
