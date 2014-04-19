using System.Web.Mvc;
using JustEatRAPPS.Service;
using Microsoft.Practices.Unity;
using Unity.Mvc4;
using JustEatRAPPS.Common;

namespace JustEatRAPPS
{
  public static class Bootstrapper
  {
    public static IUnityContainer Initialise()
    {
      var container = BuildUnityContainer();

      DependencyResolver.SetResolver(new UnityDependencyResolver(container));

      return container;
    }

    private static IUnityContainer BuildUnityContainer()
    {
        var container = new UnityContainer();
      
        RegisterTypes(container);

        return container;
    }

    public static void RegisterTypes(IUnityContainer container)
    {
        container.RegisterType<IRestaurantServiceClient, RestaurantServiceClient>();
        container.RegisterType<ISearchValidator, SearchValidator>();
    }
  }
}