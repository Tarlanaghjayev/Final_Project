using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EsgereMektub.Models;

namespace EsgereMektub.Controllers
{
    public class ContactController : Controller
    {
        private readonly esgeremektubEntities db = new esgeremektubEntities();

        public ActionResult Index()
        {
            Contact contact = db.Contact.FirstOrDefault();

            return View(contact);
        }

        [HttpPost]
        public ActionResult AddContact(string Name, string Mail, string Phone, string Text)
        {
            Contact contact = new Contact()
            {
                Name = Name,
                Mail = Mail,
                Text = Text,
                Phone=Phone
            };

            db.Contact.Add(contact);
            db.SaveChanges();
            return RedirectToAction("index", "contact");
        }
    }
}