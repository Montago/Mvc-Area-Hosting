using System.Collections.Generic;
using System.Web.Mvc;
using MvcAreaHosting.BaseModels;
using MvcAreaHosting.Areas.DomainArea1.Models;

namespace MvcAreaHosting.Areas.DomainArea1.Controllers
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
        public string splat(int id)
        {
            return "hello this is " + id;
        }
    }

}