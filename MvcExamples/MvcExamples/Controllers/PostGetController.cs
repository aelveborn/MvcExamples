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
            ViewBag.GetPost = "HttpGet";
            return View();
        }

        [HttpPost]
        public ActionResult Index(string id)
        {
            ViewBag.GetPost = "HttpPost";
            ViewBag.Textbox = "Test1: " + id;
            return View();
        }

        [HttpPost]
        public ActionResult IndexTest2(string s1, string s2)
        {
            ViewBag.GetPost = "HttpPost";
            ViewBag.Textbox2 = "Test2: " + s1 + " " + s2;
            return View("Index");
        }

        [HttpGet]
        public ActionResult IndexTest3()
        {
            ViewBag.GetPost = "HttpGet";
            ViewBag.Textbox3 = "Test3: Sweet, the GET worked fine eyy";
            return View("Index");
        }

    }
}
