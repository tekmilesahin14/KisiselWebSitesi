﻿using KisiselWebSitesi.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KisiselWebSitesi.Controllers
{
    public class AnaSayfaController : Controller
    {
        // GET: AnaSayfa
        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.Anasayfas.ToList();
            return View(deger);
        }
        public PartialViewResult ikonlar()
        {
            var deger = c.ikonlars.ToList();
            return PartialView(deger);
        }
        public ActionResult YeniIkon()
        {
            return View();
        }
 
    }
}