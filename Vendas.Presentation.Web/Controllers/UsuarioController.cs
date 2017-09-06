using System;
using System.Web.Mvc;
using Vendas.Application;
using Vendas.Presentation.Web.ViewModels;
using AutoMapper;
using Vendas.Domain;

namespace Vendas.Presentation.Web.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly PessoaoUsuarioApplication _usuarioApplication;

        public UsuarioController(PessoaoUsuarioApplication usuarioApplication)            
        {
            _usuarioApplication = usuarioApplication;
        }

        public ActionResult Login()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw;
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken()]
        public ActionResult Login(PessoaUsuarioViewModel obj)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw;
            }
            return View();
        }

        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        public ActionResult Create(PessoaUsuarioViewModel obj)
        {
            try
            {
                // TODO: Add insert logic here
                var _usuarioDomain = Mapper.Map<PessoaUsuarioViewModel, PessoaUsuario>(obj);
                _usuarioApplication.Add(_usuarioDomain);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult NewUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewUser(PessoaUsuarioViewModel obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return View();
                }
                else
                    return View();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Usuario/Edit/5
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

        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Usuario/Delete/5
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
