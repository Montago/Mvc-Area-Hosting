using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAreaHosting.Areas.DomainArea1.Controllers
{
    public class HomeController : Controller
    {
        // GET: DomainArea1/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}