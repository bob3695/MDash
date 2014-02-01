using MDash.Data.Contracts;
using MDash.Data.EF;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using System.Web.Mvc;

namespace MDash
{
    public class InjectorConfig
    {
        /// <summary>
        /// Sets all the injectors for the web project up!
        /// </summary>
        public static void RegisterInjector()
        {
            var container = new Container();

            container.Register<IUnitOfWork, EFUnitOfWork>();

            container.Verify();
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}