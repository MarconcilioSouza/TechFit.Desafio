using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechFit.Desafio.API.Controllers;
using TechFit.Desafio.Aplicacao.AutoMapper;
using TechFit.Desafio.Aplicacao.Interfaces;
using TechFit.Desafio.Aplicacao.ViewModels;
using TechFit.Desafio.Infra.CrossCutting.IoC.Modulos;

namespace TechFit.Desafio.API.Teste
{
    [TestClass]
    public class TesteAlimentosController
    {
        private readonly IAppServiceAlimento serviceAlimento;
        IKernel kernel = new StandardKernel(new ModulosNinject());

        public TesteAlimentosController()
        {
            AutoMapperConfig.RegisterMappings();

            serviceAlimento = kernel.Get<IAppServiceAlimento>();
           
        }

        [TestMethod]
        public void ObterTodosAlimentoTeste()
        {
            var controller = new AlimentosController(serviceAlimento);
            var result = controller.Get() as IEnumerable<AlimentosViewModel>;

            Assert.IsTrue(result.Any());
        }

        [TestMethod]
        public void ObterPorNomeAlimentoTeste()
        {
            var controller = new AlimentosController(serviceAlimento);
            var result = controller.Get("Feijão") as AlimentosViewModel;

            Assert.IsTrue(result != null);
        }

        [TestMethod]
        public void AddAlimentoTeste()
        {
            var alimento = new AlimentosViewModel() { Nome = "teste sem mais" };

            serviceAlimento.Adicionar(alimento);
            Assert.IsTrue(alimento.IdAlimento == null);
        }
    }
}
