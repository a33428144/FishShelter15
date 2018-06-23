using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FishShelter.Controllers
{
    public class RoomController : Controller
    {
        //[Route("room/{id}")]
        public ActionResult Index(string id)
        {
            return View(string.Format("~/Views/Room/{0}.cshtml", id));
        }


    }
}