using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EsgereMektub.Models;

namespace EsgereMektub.Controllers
{
    public class LettersController : Controller
    {
        private readonly esgeremektubEntities db = new esgeremektubEntities();

        public ActionResult Index()
        {
            VwLetters Lmodel = new VwLetters { Letters = db.Letters.Where(l=>l.Status==true).ToList() };


            return View(Lmodel);
        }

        [HttpPost]
        public ActionResult WriteLetter(string Name, string Mail,string Text)
        {
            Letters letter = new Letters()
            {
                Status = false,
                Name = Name,
                Mail=Mail,
                Text= Text
            };

            db.Letters.Add(letter);
            db.SaveChanges();
            return RedirectToAction("index", "home");
        }
    }
}