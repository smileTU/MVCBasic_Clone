using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCBasic_Clone
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
               name: "MacRoute",
               url: "mac",
               defaults: new { controller = "Mac", action = "MacPage", id = UrlParameter.Optional }
           );
            routes.MapRoute(
                name: "iPhoneRoute",
                url: "iphone",
                defaults: new { controller = "iPhone", action = "IPhonePage", id = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "iPadRoute",
               url: "ipad",
               defaults: new { controller = "iPad", action = "IPadPage", id = UrlParameter.Optional }
           );
            routes.MapRoute(
                name: "WatchRoute",
                url: "watch",
                defaults: new { controller = "Watch", action = "WatchPage", id = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "EmployeeRoute",
               url: "watch",
               defaults: new { controller = "Employees", action = "Index", id = UrlParameter.Optional }
           );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
