using Louw.PublicSuffix;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcAreaHosting.Engines
{
    public class DomainRouter : Route
    {
        public DomainRouter(string domain, string url, RouteValueDictionary defaults) : this(domain, url, defaults, new MvcRouteHandler())
        {

        }

        public DomainRouter(string domain, string url, object defaults) : this(domain, url, new RouteValueDictionary(defaults), new MvcRouteHandler())
        {

        }

        public DomainRouter(string domain, string url, object defaults, IRouteHandler routeHandler) : this(domain, url, new RouteValueDictionary(defaults), routeHandler)
        {

        }

        public DomainRouter(string domain, string url, RouteValueDictionary defaults, IRouteHandler routeHandler) : base(url, defaults, routeHandler)
        {
            this.Domain = domain;
        }

        public string Domain { get; set; }

        public override RouteData GetRouteData(HttpContextBase httpContext)
        {
            var routeData = base.GetRouteData(httpContext);

            var domainParser = new DomainParser(new WebTldRuleProvider());
            var info = domainParser.ParseAsync(httpContext.Request.Url.Host).Result;

            routeData.Values.Add("area", info.Domain);
            routeData.DataTokens.Add("area", info.Domain);
            routeData.DataTokens.Add("tld", info.Tld);
            routeData.DataTokens.Add("sub", info.SubDomain);

            return routeData;
        }
    }
}