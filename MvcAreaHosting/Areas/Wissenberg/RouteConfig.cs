using System.Web.Mvc;

namespace MvcAreaHosting.Areas.Wissenberg
{
    internal static class RouteConfig
    {
        internal static void RegisterRoutes(AreaRegistrationContext context)
        {
            context.MapRoute(
                "wissenberg_default",
                "wissenberg/{controller}/{action}/{id}",
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