using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EsgereMektub.Models;

namespace EsgereMektub.Controllers
{
    public class AboutController : Controller
    {
        private readonly esgeremektubEntities db = new esgeremektubEntities();

        public ActionResult Index()
        {

            VwAbout Amodel = new VwAbout { About = db.About.FirstOrDefault() };

            return View(Amodel);
        }
    }
}