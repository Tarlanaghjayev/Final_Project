using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EsgereMektub.Areas.AdminPanel.Controllers
{
    public class HomeController : Controller
    {
        // GET: AdminPanel/Home
        public ActionResult Index()
        {
            if (Session["AdminLog"]==null)
            {
                return RedirectToAction("index", "login");
            }
            return View();
        }
    }
}