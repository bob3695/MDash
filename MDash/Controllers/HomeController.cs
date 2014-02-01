using MDash.Data;
using MDash.Data.Contracts;
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
        private IUnitOfWork UoW;

        public HomeController(IUnitOfWork UoW)
        {
            this.UoW = UoW;
        }

        public ActionResult Index()
        {
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