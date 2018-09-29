using System.Web.Http;

namespace DotNetWebApi.App_Start
{
    public class Bootstrapper
    {
        public static void Run()
        {
            // Configure Autofac Dependency Resolver
            DependencyResolver.Initialize(GlobalConfiguration.Configuration);
        }
    }
}