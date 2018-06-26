using System.Web.Mvc;

namespace MvcAreaHosting.Areas.DomainArea1
{
    internal static class RouteConfig
    {
        internal static void RegisterRoutes(AreaRegistrationContext context)
        {
            context.MapRoute(
                "DomainArea1_default",
                "DomainArea1/{controller}/{action}/{id}",
                new
                {
                    controller = "Hello",
                    action = "Index",
                    id = UrlParameter.Optional,
                }
            );
        }
    }
}