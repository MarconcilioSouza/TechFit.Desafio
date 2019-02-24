using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechFit.Desafio.Aplicacao.Interfaces;
using TechFit.Desafio.Aplicacao.ViewModels;

namespace TechFit.Desafio.API.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAppServiceAlimento serviceAlimento;
        public HomeController(IAppServiceAlimento appServiceAlimento)
        {
            serviceAlimento = appServiceAlimento;
        }

        // GET:  api/alimentos
        public IEnumerable<AlimentosViewModel> Get()
        {
            return serviceAlimento.ObterTotos();
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
