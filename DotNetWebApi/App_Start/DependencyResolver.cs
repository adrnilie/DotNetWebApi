using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using DotNetWebApi.Core.DataAccess;
using DotNetWebApi.Repositories;

namespace DotNetWebApi.App_Start
{
    public class DependencyResolver
    {
        private static IContainer container;

        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }

        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // Register needed components
            builder.RegisterType<ConnectionRepository>().As<IConnectionRepository>();
            builder.RegisterType<UsersRepository>().As<IUsersRepository>();

            // Set the dependency to Autofac
            container = builder.Build();

            return container;
        }
    }
}