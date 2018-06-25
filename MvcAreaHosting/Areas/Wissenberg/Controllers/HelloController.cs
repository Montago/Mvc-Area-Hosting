using System.Collections.Generic;
using System.Web.Mvc;
using MvcAreaHosting.BaseModels;
using MvcAreaHosting.Areas.Wissenberg.Models;

namespace MvcAreaHosting.Areas.Wissenberg.Controllers
{
    public class HelloController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test()
        {
            return View();
        }
    }
}