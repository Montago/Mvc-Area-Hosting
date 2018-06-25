using System.Web.Mvc;
using System.Web.Optimization;

namespace MvcAreaHosting.Areas.Wissenberg
{
    public class WissenbergAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "wissenberg";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            RegisterBundles();
            RegisterRoutes(context);
        }

        private void RegisterRoutes(AreaRegistrationContext context)
        {
            RouteConfig.RegisterRoutes(context);
        }

        private void RegisterBundles()
        {
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}