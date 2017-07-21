using AutoMapper;
using System.Collections.Generic;
using System.Web.Mvc;
using Vendas.Application.Interface;
using Vendas.Domain;
using Vendas.Presentation.Web.ViewModels;

namespace Vendas.Presentation.Web.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ICategoriaApplication _categoriaApplication;

        // GET: Categoria
        public ActionResult Index()
        {
            var _categoriaViewModel = Mapper.Map<IEnumerable<Categoria>, IEnumerable<CategoriaViewModel>>(_categoriaApplication.GetAll());
            return View(_categoriaViewModel);
        }

        // GET: Categoria/Details/5
        public ActionResult Details(int id)
        {
            var _categoriaViewModel = Mapper.Map<Categoria, CategoriaViewModel>(_categoriaApplication.GetById(id));
            return View(_categoriaApplication);
        }

        // GET: Categoria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categoria/Create
        [HttpPost]
        public ActionResult Create(CategoriaViewModel categoriaViewModel)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {

                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Categoria/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Categoria/Edit/5
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

        // GET: Categoria/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Categoria/Delete/5
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
