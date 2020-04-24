using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Bible_Application
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute(
                name: "HomePage",
                url: "home/",
                defaults: new { controller = "Application", action = "Home", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "EntryPage",
                url: "entry",
                defaults: new { controller = "Application", action = "BibleVerseEntry", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "SearchPage",
                url: "search",
                defaults: new { controller = "Application", action = "BibleVerseSearch", id = UrlParameter.Optional }
            );

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Application", action = "Home", id = UrlParameter.Optional }
            );
        }
    }
}
