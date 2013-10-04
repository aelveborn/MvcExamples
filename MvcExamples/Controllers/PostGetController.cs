using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcExamples.Controllers
{
    public class PostGetController : Controller
    {
        //
        // GET: /PostGet/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendId(string id)
        {
            ViewBag.Textbox = "You sent id: " + id;
            return View("Index");
        }

        [HttpPost]
        public ActionResult SendMoreValues(string surname, string lastname)
        {
            ViewBag.Textbox2 = "Your name: " + surname + " " + lastname;
            return View("Index");
        }

        [HttpGet]
        public ActionResult ActionLinkTest()
        {
            ViewBag.Textbox3 = "Sweet, the GET worked fine eyy";
            return View("Index");
        }

    }
}
