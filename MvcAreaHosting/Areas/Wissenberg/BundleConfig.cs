using System.Web.Optimization;

namespace MvcAreaHosting.Areas.Wissenberg
{
    internal static class BundleConfig
    {
        internal static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new LessBundle("~/Wissenberg")
                .IncludeDirectory("~/Areas/Wissenberg", "*.less", true)
            );
        }
    }
}