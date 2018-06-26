using System.Web.Optimization;

namespace MvcAreaHosting.Areas.DomainArea1
{
    internal static class BundleConfig
    {
        internal static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new LessBundle("~/DomainArea1")
                .IncludeDirectory("~/Areas/DomainArea1", "*.less", true)
            );
        }
    }
}