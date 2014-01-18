using MDash.Data;
using MDash.Data.Models;
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
            UnitOfWork uow = new UnitOfWork();

            PlexServer plexServer = new PlexServer();
            plexServer.Ip = "1291313";
            uow.PlexServerRepository.Insert(plexServer);
            uow.Save();

            var servers = uow.PlexServerRepository.Get();

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