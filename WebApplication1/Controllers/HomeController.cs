using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SDV2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult cart()
        {
            return View();
        }

        public ActionResult recherche()
        {
            return View();
        }
        public ActionResult AllShows()
        {
            return View();
        }
    }
}
