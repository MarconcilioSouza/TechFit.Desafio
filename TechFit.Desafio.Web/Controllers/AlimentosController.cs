using System.Web.Mvc;
using TechFit.Desafio.Aplicacao.Interfaces;
using TechFit.Desafio.Aplicacao.ViewModels;

namespace TechFit.Desafio.Web.Controllers
{
    public class AlimentosController : Controller
    {
        private readonly IAppServiceAlimento serviceAlimento;
        public AlimentosController(IAppServiceAlimento appServiceAlimento)
        {
            serviceAlimento = appServiceAlimento;
        }

        // GET: Alimentos
        public ActionResult Index()
        {
            var alimentos = serviceAlimento.ObterTotos();
            return View(alimentos);
        }

        // GET: Alimentos/Details/5
        public ActionResult Details(int id)
        {
            var alimento = serviceAlimento.ObterPorId(id);
            return View(alimento);
        }

        // GET: Alimentos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alimentos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AlimentosViewModel alimento)
        {
            if (ModelState.IsValid)
            {
                serviceAlimento.Adicionar(alimento);

                return RedirectToAction("Index");
            }

            return View(alimento);
        }

        // GET: Alimentos/Edit/5
        public ActionResult Edit(int id)
        {
            var alimento = serviceAlimento.ObterPorId(id);
            return View(alimento);
        }

        // POST: Alimentos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AlimentosViewModel alimento)
        {
            if (ModelState.IsValid)
            {
                serviceAlimento.Alterar(alimento);

                return RedirectToAction("Index");
            }

            return View(alimento);
        }

        // GET: Alimentos/Delete/5
        public ActionResult Delete(int id)
        {
            var alimento = serviceAlimento.ObterPorId(id);
            if (alimento == null)
            {
                return HttpNotFound();
            }
            return View(alimento);
        }

        // POST: Alimentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            serviceAlimento.Deletar(id);
            return RedirectToAction("Index");
        }
    }
}
