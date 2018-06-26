using System.Web.Mvc;
using System.Web.Optimization;

namespace MvcAreaHosting.Areas.DomainArea1
{
    public class DomainArea1AreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "DomainArea1";
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