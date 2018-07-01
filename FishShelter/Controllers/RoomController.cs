using FishShelter.Models;
using FishShelter.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FishShelter.Controllers
{
    public class RoomController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail(string id)
        {
            RoomService RoomService = new RoomService();
            return View(string.Format("~/Views/Room/{0}.cshtml", id), RoomService.GetData().First(f => f.id == id));
        }
    }
}