using Ninject.Modules;
using TechFit.Desafio.Aplicacao.Interfaces;
using TechFit.Desafio.Aplicacao.Services;
using TechFit.Desafio.Dominio.Interfaces.Repositorios;
using TechFit.Desafio.Dominio.Interfaces.Services;
using TechFit.Desafio.Dominio.Services;
using TechFit.Desafio.Infra.Data.Repositorios;

namespace TechFit.Desafio.Infra.CrossCutting.IoC.Modulos
{
    public class ModulosNinject : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            Bind<IAppServiceAlimento>().To<AppServiceAlimento>();

            Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            Bind<IServicoAlimento>().To<ServiceAlimento>();


            Bind(typeof(IRepositorioBase<>)).To(typeof(IRepositorioBase<>));
            Bind<IRepositorioAlimento>().To<RepositorioAlimento>();

        }
    }
}
