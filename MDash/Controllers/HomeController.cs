using MDash.Data;
using MDash.Data.Models;
using MDash.Plex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MDash.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            PlexAPI api = new PlexAPI();

            api.GetNowPlaying("192.168.30.202", "32400");

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}