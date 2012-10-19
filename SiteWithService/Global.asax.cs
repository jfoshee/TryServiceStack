using System.Web.Mvc;
using System.Web.Routing;
using ServiceStack.WebHost.Endpoints;
using Funq;
using TryServiceStack;

namespace SiteWithService
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("servicestack/{*pathInfo}");
            routes.MapRoute(
                "Default",
                "{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = "" }
            );
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RegisterRoutes(RouteTable.Routes);
            new HelloAppHost().Init();
        }

        public class HelloAppHost : AppHostBase
        {
            //Tell Service Stack the name of your application and where to find your web services
            public HelloAppHost() : base("Hello Web Services", typeof(HelloService).Assembly)
            {
            }
            
            public override void Configure(Container container)
            {
                //register user-defined REST-ful urls
                Routes
                    .Add<Hello>("/hello")
                        .Add<Hello>("/hello/{Name}")
                        .Add<AddRequest>("/add");
            }
        } 
    }
}
