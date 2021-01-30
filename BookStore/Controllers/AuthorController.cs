using BookStore.Domain;
using BookStore.Filters;
using BookStore.Repositories;
using BookStore.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    [RoutePrefix("autores")]
    //[LogActionFilter()] //filtra em todas as actions
    public class AuthorController : Controller
    {
        private IAuthorRepository repository;

        public AuthorController()
        {
            repository = new AuthorRepository();
        }

        [Route("listar")]
        //[LogActionFilter()] //filtra nesta action
        public ActionResult Index()
        {
            var autores = repository.Get();
            return View(autores);
        }

        [Route("criar")]
        public ActionResult Create()
        {
            return View(); 
        }

        [Route("criar")]
        [HttpPost]
        public ActionResult Create(Autor autor)
        {
            if (repository.Create(autor))
                return RedirectToAction(nameof(Index));

            return View(autor); //se der erro no if ele vem aqui
        }

        [Route("editar/{id:int}")]
        public ActionResult Edit(int id)
        {
            var author = repository.Get(id);
            return View(author);
        }

        [Route("editar/{id:int}")]
        [HttpPost]
        public ActionResult Edit(Autor autor)
        {
            if (repository.Update(autor))
                return RedirectToAction(nameof(Index));

            return View(autor); //se der erro no if ele vem aqui
        }

        [Route("excluir/{id:int}")]
        public ActionResult Delete(int id)
        {
            var author = repository.Get(id);
            return View(author);
        }

        [Route("excluir/{id:int}")]
        [HttpPost]
        [ActionName("Delete")] //serve para manter a convenção de nome na url
        public ActionResult DeleteConfirm(int id)
        {
            repository.Delete(id);

            return RedirectToAction(nameof(Index));
        }
    }
}