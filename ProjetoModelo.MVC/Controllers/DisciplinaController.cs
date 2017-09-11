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
    public class DisciplinaController : Controller
    {
        private readonly IDisciplinaAppService _disciplinaApp;

        public DisciplinaController(IDisciplinaAppService disciplinaApp)
        {
            _disciplinaApp = _disciplinaApp;
        }
        // GET: Disciplina
        public ActionResult Index()
        {
            var disciplinaViewModel = Mapper.Map<IEnumerable<Disciplina>, IEnumerable<DisciplinaViewModel>>(_disciplinaApp.GetAll());
            return View(disciplinaViewModel);

        }

        // GET: Disciplina/Details/5
        public ActionResult Details(int id)
        {
            var disciplinaApp = _disciplinaApp.GetByID(id);
            var disciplinaViewModel = Mapper.Map<Disciplina, DisciplinaViewModel>(disciplinaApp);

            return View(disciplinaViewModel);

        }

        // GET: Disciplina/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Disciplina/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DisciplinaViewModel disciplina)
        {
            if (ModelState.IsValid)
            {
                var config = new AutoMapper.AutoMapperConfig().Configure();
                var iMapper = config.CreateMapper();

                var disciplinaDomain = iMapper.Map<DisciplinaViewModel, Disciplina>(disciplina);
                _disciplinaApp.Add(disciplinaDomain);

                return RedirectToAction("Index");
            }

            return View(disciplina);
        }

        // GET: Disciplina/Edit/5
        public ActionResult Edit(int id)
        {
            var disciplina = _disciplinaApp.GetByID(id);
            var disciplinaViewModel = Mapper.Map<Disciplina, DisciplinaViewModel>(disciplina);

            return View(disciplinaViewModel);
        }

        // POST: Disciplina/Edit/5
        [HttpPost]
        public ActionResult Edit(DisciplinaViewModel disciplina)
        {
            if (ModelState.IsValid)
            {
                var disciplinaDomain = Mapper.Map<DisciplinaViewModel, Disciplina>(disciplina);
                _disciplinaApp.Update(disciplinaDomain);

                return RedirectToAction("Index");
            }

            return View(disciplina);
        }

        // GET: Disciplina/Delete/5
        public ActionResult Delete(int id)
        {
            var disciplina = _disciplinaApp.GetByID(id);
            var disciplinaViewModel = Mapper.Map<Disciplina, DisciplinaViewModel>(disciplina);

            return View(disciplinaViewModel);
        }

        // POST: Disciplina/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var disciplina = _disciplinaApp.GetByID(id);
            _disciplinaApp.Remove(disciplina);

            return RedirectToAction("Index");

        }
    }
}
