using BookStore.Context;
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

        [Route("criar")]
        public ActionResult Create()
        {
            var categorias = _db.Categorias.ToList();
            var viewModel = new CreateBookViewModel
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
        public ActionResult Create(CreateBookViewModel model)
        {
            return View();
        }
    }
}