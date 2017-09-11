using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using AutoMapper;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModelo.Domain.Entities;
using ProjetoModelo.MVC.ViewModels;

namespace ProjetoModelo.MVC.Controllers
{
    public class TipoMaoObraController : Controller
    {
        private readonly ITipoMaoObraAppService _tipoMaoObraApp;
        public TipoMaoObraController(ITipoMaoObraAppService tipoMaoObraApp)
        {
            _tipoMaoObraApp = tipoMaoObraApp;
        }
        // GET: TipoMaoObra
        public ActionResult Index()
        {
            var tipoMaoObraViewModel = Mapper.Map<IEnumerable<TipoMaoObra>, IEnumerable<TipoMaoObraViewModel>>(_tipoMaoObraApp.GetAll());
            return View(tipoMaoObraViewModel);
        }

        // GET: TipoMaoObra/Details/5
        public ActionResult Details(int id)
        {
            var tipoMaoObra = _tipoMaoObraApp.GetByID(id);
            var tipoMaoObraViewModel = Mapper.Map<TipoMaoObra, TipoMaoObraViewModel>(tipoMaoObra);

            return View(tipoMaoObraViewModel);
        }

        // GET: TipoMaoObra/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoMaoObra/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TipoMaoObraViewModel tipoMaoObra)
        {
            if (ModelState.IsValid)
            {
                var config = new AutoMapper.AutoMapperConfig().Configure();
                var iMapper = config.CreateMapper();

                var tipoMaoObraDomain = iMapper.Map<TipoMaoObraViewModel, TipoMaoObra>(tipoMaoObra);
                _tipoMaoObraApp.Add(tipoMaoObraDomain);

                return RedirectToAction("Index");
            }

            return View(tipoMaoObra);
        }

        // GET: TipoMaoObra/Edit/5
        public ActionResult Edit(int id)
        {
            var tipoMaoObra = _tipoMaoObraApp.GetByID(id);
            var tipoMaoObraViewModel = Mapper.Map<TipoMaoObra, TipoMaoObraViewModel>(tipoMaoObra);

            return View(tipoMaoObraViewModel);

        }

        // POST: TipoMaoObra/Edit/5
        [HttpPost]
        public ActionResult Edit(TipoMaoObraViewModel tipoMaoObra)
        {
            if (ModelState.IsValid)
            {
                var tipoMaoObraDomain = Mapper.Map<TipoMaoObraViewModel, TipoMaoObra>(tipoMaoObra);
                _tipoMaoObraApp.Update(tipoMaoObraDomain);

                return RedirectToAction("Index");
            }

            return View(tipoMaoObra);
        }

        // GET: TipoMaoObra/Delete/5
        public ActionResult Delete(int id)
        {
            var tipoMaoObra = _tipoMaoObraApp.GetByID(id);
            var tipoMaoObraViewModel = Mapper.Map<TipoMaoObra, TipoMaoObraViewModel>(tipoMaoObra);

            return View(tipoMaoObraViewModel);
        }

        /// POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var tipoMaoObra = _tipoMaoObraApp.GetByID(id);
            _tipoMaoObraApp.Remove(tipoMaoObra);

            return RedirectToAction("Index");

        }
    }
}
