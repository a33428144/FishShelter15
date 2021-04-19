using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace FishShelter.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Room()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Notice()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Location()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }

        [HttpGet]
        public ActionResult TV()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ZOCHA()
        {
            return View();
        }
    }
}