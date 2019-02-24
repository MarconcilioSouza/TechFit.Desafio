using System;
using System.Collections.Generic;
using System.Web.Http;
using TechFit.Desafio.Aplicacao.Interfaces;
using TechFit.Desafio.Aplicacao.ViewModels;

namespace TechFit.Desafio.API.Controllers
{
    public class AlimentosController : ApiController
    {
        private readonly IAppServiceAlimento serviceAlimento;
        public AlimentosController(IAppServiceAlimento appServiceAlimento)
        {
            serviceAlimento = appServiceAlimento;
        }

        // GET:  api/alimentos
        public IEnumerable<AlimentosViewModel> Get()
        {
            return serviceAlimento.ObterTotos();
        }

        // GET: api/alimentos/5
        public AlimentosViewModel Get(int id)
        {
            return serviceAlimento.ObterPorId(id);
        }

        // GET: api/alimentos/5
        public AlimentosViewModel Get(string nome)
        {
            return serviceAlimento.ObterPorNome(nome);
        }
    }
}
