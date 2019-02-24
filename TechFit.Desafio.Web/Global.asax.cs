using Ninject;
using Ninject.Modules;
using Ninject.Web.Common.WebHost;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TechFit.Desafio.Aplicacao.AutoMapper;
using TechFit.Desafio.Infra.CrossCutting.IoC.Modulos;

namespace TechFit.Desafio.Web
{
    public class MvcApplication : NinjectHttpApplication
    {
        protected override void OnApplicationStarted()
        {
            base.OnApplicationStarted();

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AutoMapperConfig.RegisterMappings();
        }
        protected override IKernel CreateKernel()
        {
            var modules = new NinjectModule[] { new ModulosNinject() };
            return new StandardKernel(modules);
        }
    }
}
