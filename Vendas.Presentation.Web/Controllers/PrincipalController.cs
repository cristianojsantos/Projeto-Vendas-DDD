using System.Web.Mvc;
using Vendas.Application.Interface;

namespace Vendas.Presentation.Web.Controllers
{
    public class PrincipalController : Controller
    {
        private readonly IVendaApplication _vendaApplication;
        private readonly IVendaItemApplication _vendaItemApplication;

        public PrincipalController(IVendaApplication _vendaApplication, IVendaItemApplication _vendaItemApplication)
        {

        }

        // GET: Principal
        public ActionResult Index()
        {
            return View();
        }

        // GET: Principal/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Principal/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Principal/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Principal/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Principal/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Principal/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Principal/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
