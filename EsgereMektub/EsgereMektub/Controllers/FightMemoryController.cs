using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EsgereMektub.Models;

namespace EsgereMektub.Controllers
{
    public class FightMemoryController : Controller
    {
        private readonly esgeremektubEntities db = new esgeremektubEntities();

        public ActionResult Index()
        {

            //VwModel FMmodel = new VwModel { FightMemory = db.FightMemory.ToList() };

            VwFightMemory data = new VwFightMemory
            {
                FightMemory = db.FightMemory.ToList(),
                FMtext = db.FMtext.FirstOrDefault()

            };

            return View(data);
        }
    }
}