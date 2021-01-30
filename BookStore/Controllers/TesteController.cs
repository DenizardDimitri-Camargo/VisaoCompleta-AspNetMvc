using BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    [RoutePrefix("teste")] //coloca um prefixo de rota
    [Route("{action=Dados}")] //seta a action principal
    public class TesteController : Controller
    {     
        public ViewResult Dados(int id)
        {
            var autor = new Autor
            {
                Id = 1,
                Nome = "dede"
            };

            ViewBag.Categoria = "Produtos de limpeza";
            ViewData["Categoria"] = "Produtos de Informática";
            TempData["Categoria"] = "Produtos de Escritório";
            Session["Categoria"] = "Móveis";

            return View(autor);
        }

        // GET: Teste
        public string Index(int id)
        {
            return "Index do " + id.ToString();
        }

        public JsonResult UmaAction(int id, string nome)
        {
            var autor = new Autor
            {
                //Id = id.Value,
                Nome = nome
            };

            return Json(autor, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [ActionName("Autor")]
        public JsonResult ActionDois(Autor autor)
        {
            return Json(autor);
        }

        [Route("minharota/{id:int}")]
        public string MinhaAction(int id)
        {
            return "Ok! Cheguei na rota";
        }

        [Route("~/rotaignorada/{id:int}")] //~ remove o prefixo de rota
        public string MinhaAction2(int id)
        {
            return "Ok! Cheguei na rota";
        }
    }
}