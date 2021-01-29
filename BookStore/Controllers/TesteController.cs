using BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    public class TesteController : Controller
    {        
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
    }
}