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
    public class ProdutosController : Controller
    {
        // GET: Produtos
        private readonly IProdutoAppService _produtoApp;
        private readonly IClienteAppService _clienteApp;

        public ProdutosController(IProdutoAppService produtoApp, IClienteAppService clienteApp)
        {
            _produtoApp = produtoApp;
            _clienteApp = clienteApp;
        }

        // GET: Cliente
        public ActionResult Index()
        {
            var produtoViewModel = Mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(_produtoApp.GetAll());
            return View(produtoViewModel);
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            var produto = _produtoApp.GetByID(id);
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);

            return View(produtoViewModel);
        }

        // GET: Cliente/Creaate
        public ActionResult Create()
        {
            ViewBag.ClienteId = new SelectList(_clienteApp.GetAll(), "ClienteID", "Nome");
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProdutoViewModel produto)
        {
            if (ModelState.IsValid)
            {
                var produtoDomain = Mapper.Map<ProdutoViewModel, Produto>(produto);
                _produtoApp.Add(produtoDomain);

                return RedirectToAction("Index");
            }

            ViewBag.ClienteId = new SelectList(_clienteApp.GetAll(), "ClienteID", "Nome", produto.ClienteID);
            return View(produto);
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            var produto = _produtoApp.GetByID(id);
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);

            ViewBag.ClienteId = new SelectList(_clienteApp.GetAll(), "ClienteID", "Nome", produtoViewModel.ClienteID);
            return View(produtoViewModel);

        }

        // POST: Clientes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProdutoViewModel produto)
        {
            if (ModelState.IsValid)
            {
                var produtoDomain = Mapper.Map<ProdutoViewModel, Produto>(produto);
                _produtoApp.Update(produtoDomain);

                return RedirectToAction("Index");
            }

            ViewBag.ClienteId = new SelectList(_clienteApp.GetAll(), "ClienteID", "Nome", produto.ClienteID);
            return View(produto);
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            var produto = _produtoApp.GetByID(id);
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);

            return View(produtoViewModel);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var produto = _produtoApp.GetByID(id);
            _produtoApp.Remove(produto);

            return RedirectToAction("Index");

        }
    }
}