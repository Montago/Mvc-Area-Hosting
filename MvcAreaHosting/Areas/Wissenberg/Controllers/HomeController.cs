using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAreaHosting.Areas.Wissenberg.Controllers
{
    public class HomeController : Controller
    {
        // GET: Wissenberg/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}