using API_Domain.Repository;
using API_Domain.Services;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace API_Front
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IStoreApiService, StoreApiService>();
            container.RegisterType<IStoreApiRepository, StoreApiRepository>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}