using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EsgereMektub.Models;

namespace EsgereMektub.Controllers
{
    public class HomeController : Controller
    {
        private readonly esgeremektubEntities db = new esgeremektubEntities();

        public ActionResult Index()
        {
            VwHome data = new VwHome
            {

                Setting = db.Setting.FirstOrDefault(),
                Slider = db.Slider.ToList(),
                Counter = db.Counter.FirstOrDefault(),
                FightMemory = db.FightMemory.Take(3).ToList()
            };
            return View(data);
        }
    }
}