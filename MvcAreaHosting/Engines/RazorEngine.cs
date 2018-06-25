using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAreaHosting.Engines
{
    public class RazorEngine : RazorViewEngine
    {
        public RazorEngine() : base()
        {
            #region Area Views
            AreaViewLocationFormats = new[] {
                "~/Areas/{2}/Views/%1/{1}/{0}.cshtml",
                "~/Areas/{2}/Views/%1/Shared/{0}.cshtml",
            };

            AreaMasterLocationFormats = new[] {
                "~/Areas/{2}/Views/%1/{1}/{0}.cshtml",
                "~/Areas/{2}/Views/%1/Shared/{0}.cshtml",
            };

            AreaPartialViewLocationFormats = new[] {
                "~/Areas/{2}/Views/%1/{1}/{0}.cshtml",
                "~/Areas/{2}/Views/%1/Shared/{0}.cshtml",
            };
            #endregion

            #region Root Views
            ViewLocationFormats = new[] {
                "~/Views/%1/{1}/{0}.cshtml",
                "~/Views/%1/Shared/{0}.cshtml",
            };

            MasterLocationFormats = new[] {
                "~/Views/%1/{1}/{0}.cshtml",
                "~/Views/%1/Shared/{0}.cshtml",
            };

            PartialViewLocationFormats = new[] {
                "~/Views/%1/{1}/{0}.cshtml",
                "~/Views/%1/Shared/{0}.cshtml",
            }; 
            #endregion
        }

        protected override IView CreatePartialView(ControllerContext controllerContext, string partialPath)
        {
            var nameSpace = controllerContext.Controller.GetType().Namespace;
            return base.CreatePartialView(controllerContext, partialPath.Replace("%1", nameSpace));
        }

        protected override IView CreateView(ControllerContext controllerContext, string viewPath, string masterPath)
        {
            var nameSpace = controllerContext.Controller.GetType().Namespace;
            return base.CreateView(controllerContext, viewPath.Replace("%1", nameSpace), masterPath.Replace("%1", nameSpace));
        }

        protected override bool FileExists(ControllerContext controllerContext, string virtualPath)
        {
            var nameSpace = controllerContext.Controller.GetType().Namespace;
            return base.FileExists(controllerContext, virtualPath.Replace("%1", nameSpace));
        }
    }
}