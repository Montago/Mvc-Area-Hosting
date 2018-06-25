using System.Web;
using System.Web.Optimization;

namespace MvcAreaHosting
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // by default this looks at build config... 
            // BundleTable.EnableOptimizations = true;

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/BaseScripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/BaseScripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/Modernizr").Include(
                        "~/BaseScripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/BaseScripts/bootstrap.js",
                      "~/BaseScripts/respond.js"));

            bundles.Add(new LessBundle("~/BaseStyle").Include(
                      "~/BaseStyling/bootstrap.less",
                      "~/BaseStyling/root.less"));
        }
    }
}
