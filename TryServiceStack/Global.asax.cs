using System;
using System.Web;
using Funq;
using ServiceStack.WebHost.Endpoints;

namespace TryServiceStack
{
    public class Global : HttpApplication
    {
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
        
        //Initialize your application singleton
        protected void Application_Start(object sender, EventArgs e)
        {
            new HelloAppHost().Init();
        }       
    }
}
