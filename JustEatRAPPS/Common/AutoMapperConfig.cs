using AutoMapper;
using JustEatRAPPS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestModel = JustEatRAPPS.Models.RestaurantModels;
using ProductModel = JustEatRAPPS.Models.ProductModels;

namespace JustEatRAPPS.Common
{
    public static class AutoMapperConfig
    {
        public static void Configure() 
        {
            Mapper.CreateMap<RestModel.Restaurant, RestaurantViewModel>()
                .ForMember(m => m.RestaurantLogo, o => o.MapFrom(s => s.Logo[0].StandardResolutionURL));
            Mapper.CreateMap<ProductModel.Product, ProductViewModel>();
        }
    }
}