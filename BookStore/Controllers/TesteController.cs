﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    public class TesteController : Controller
    {
        public string Teste()
        {
            return "Testado";
        }


        // GET: Teste
        public ActionResult Index()
        {
            return View();
        }
    }
}