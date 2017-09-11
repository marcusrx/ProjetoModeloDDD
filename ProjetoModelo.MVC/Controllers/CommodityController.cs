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
    public class CommodityController : Controller
    {
        // GET: Commodity
        private readonly ICommodityAppService _commodityApp;
        private readonly IDisciplinaAppService _disciplinaApp;
        private readonly ITipoMaoObraAppService _tipoMaoObraApp;
        

        public CommodityController(ICommodityAppService commodityApp, IDisciplinaAppService disciplinaApp, ITipoMaoObraAppService tipoMaoObraApp)
        {
            _commodityApp = commodityApp;
            _disciplinaApp = disciplinaApp;
            _tipoMaoObraApp = tipoMaoObraApp;
        }

        
        public ActionResult Index()
        {
            var commodityViewModel = Mapper.Map<IEnumerable<Commodity>, IEnumerable<CommodityViewModel>>(_commodityApp.GetAll());
            return View(commodityViewModel);
        }

        public ActionResult CommoditiesComPerformance()
        {
            var commodityViewModel = Mapper.Map<IEnumerable<Commodity>, IEnumerable<CommodityViewModel>>(_commodityApp.ObterCommoditiesComPerformance());
            return View(commodityViewModel);
        }


        // GET: Commodity/Details/5
        public ActionResult Details(int id)
        {
            var commodity = _commodityApp.GetByID(id);
            var commodityViewModel = Mapper.Map<Commodity, CommodityViewModel>(commodity);

            return View(commodityViewModel);
        }

        // GET: Commodity/Creaate
        public ActionResult Create()
        {
            ViewBag.DisciplinaID = new SelectList(_disciplinaApp.GetAll(), "DisciplinaID", "Nome");
            ViewBag.TipoMaoObraID = new SelectList(_tipoMaoObraApp.GetAll(), "ID", "Descricao");
            return View();
        }

        // POST: Commodity/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CommodityViewModel commodity)
        {
            if (ModelState.IsValid)
            {
                var commodityDomain = Mapper.Map<CommodityViewModel, Commodity>(commodity);
                _commodityApp.Add(commodityDomain);

                return RedirectToAction("Index");
            }

            ViewBag.DisciplinaID = new SelectList(_disciplinaApp.GetAll(), "DisciplinaID", "Nome", commodity.DisciplinaID);
            ViewBag.TipoMaoObraID = new SelectList(_commodityApp.GetAll(), "ID", "Descricao", commodity.TipoMaoObraID);

            return View(commodity);
        }

        // GET: Commodity/Edit/5
        public ActionResult Edit(int id)
        {
            var commodity = _commodityApp.GetByID(id);
            var commodityViewModel = Mapper.Map<Commodity, CommodityViewModel>(commodity);

            ViewBag.DisciplinaID = new SelectList(_disciplinaApp.GetAll(), "DisciplinaID", "Nome", commodity.DisciplinaID);
            ViewBag.TipoMaoObraID = new SelectList(_commodityApp.GetAll(), "ID", "Descricao", commodityViewModel.TipoMaoObraID);
            return View(commodityViewModel);

        }

        // POST: Commodity/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CommodityViewModel commodity)
        {
            if (ModelState.IsValid)
            {
                var commodityDomain = Mapper.Map<CommodityViewModel, Commodity>(commodity);
                _commodityApp.Update(commodityDomain);

                return RedirectToAction("Index");
            }

            ViewBag.DisciplinaID = new SelectList(_disciplinaApp.GetAll(), "DisciplinaID", "Nome", commodity.DisciplinaID);
            ViewBag.TipoMaoObraID = new SelectList(_commodityApp.GetAll(), "ID", "Descricao", commodity.TipoMaoObraID);
            return View(commodity);
        }

        // GET: Commodity/Delete/5
        public ActionResult Delete(int id)
        {
            var commodity = _commodityApp.GetByID(id);
            var commodityViewModel = Mapper.Map<Commodity, CommodityViewModel>(commodity);

            return View(commodityViewModel);
        }

        // POST: Commodity/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var commodity = _commodityApp.GetByID(id);
            _commodityApp.Remove(commodity);

            return RedirectToAction("Index");

        }
    }
}