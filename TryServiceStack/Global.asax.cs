using System;
using System.Web;
using HelloServices;

namespace TryServiceStack
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            new HelloAppHost().Init();
        }       
    }
}
