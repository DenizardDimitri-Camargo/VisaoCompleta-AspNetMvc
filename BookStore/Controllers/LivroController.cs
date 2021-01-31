using BookStore.Context;
using BookStore.Domain;
using BookStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    [RoutePrefix("livros")]
    public class LivroController : Controller
    {
        BookStoreDataContext _db = new BookStoreDataContext();

        [Route("listar")]
        public ActionResult Index()
        {
            return View(_db.Livros.ToList());
        }

        [Route("criar")]
        public ActionResult Create()
        {
            var categorias = _db.Categorias.ToList();
            var viewModel = new EditorBookViewModel
            {
                Titulo = "",
                ISBN = "",
                CategoriaId = 0,
                Categoriaoptions = new SelectList(categorias, "Id", "Nome") //SelectList é um tipo chave/valor
            };

            return View(viewModel);
        }

        [Route("criar")]
        [HttpPost]
        public ActionResult Create(EditorBookViewModel model)
        {
            var livro = new Livro();
            livro.Titulo = model.Titulo;
            livro.ISBN = model.ISBN;
            livro.DataLancamento = model.DataLancamento;
            livro.CategoriaId = model.CategoriaId;
            _db.Livros.Add(livro);
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [Route("editar")]
        public ActionResult Edit(int id)
        {
            var categorias = _db.Categorias.ToList();
            var livro = _db.Livros.Find(id);

            var viewModel = new EditorBookViewModel
            {
                Titulo = livro.Titulo,
                ISBN = livro.ISBN,
                CategoriaId = livro.CategoriaId,
                Categoriaoptions = new SelectList(categorias, "Id", "Nome") //SelectList é um tipo chave/valor
            };

            return View(viewModel);
        }

        [Route("editar")]
        [HttpPost]
        public ActionResult Edit(EditorBookViewModel model)
        {
            var livro = _db.Livros.Find(model.Id);
            _db.Entry<Livro>(livro).State = System.Data.Entity.EntityState.Modified;
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}