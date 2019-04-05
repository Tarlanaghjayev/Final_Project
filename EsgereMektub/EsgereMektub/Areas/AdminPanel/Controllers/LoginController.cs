using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EsgereMektub.Models;
using System.Web.Helpers;

namespace EsgereMektub.Areas.AdminPanel.Controllers
{
    public class LoginController : Controller
    {
        esgeremektubEntities db = new esgeremektubEntities();
        // GET: AdminPanel/Login
        
        [HttpGet]
        public ActionResult LoginAdmin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginAdmin( string Name, string Password ) {
            
                if (Crypto.VerifyHashedPassword(db.Admin.First(a => a.Name == Name).Password, Password)){
                    Session["AdminLog"] = true;
                    return RedirectToAction("Index", "Contacts");
                }
                else
                {
                ViewBag.Wrong = "Daxil etdiyiniz məlumatlardan hər hansı biri yanlışdır!";
                    return View();
                }
            
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("LoginAdmin", "Login");
        }
    }
}