using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TelerikDrawerBug.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult WithBinding()
        {
            return View();
        }

        public ActionResult WithoutBinding()
        {
            return View();
        }
    }
}