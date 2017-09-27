using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

using System.Text;
using ServiceStack;
using ServiceStack.Host;
using ServiceStack.Text;
using ServiceStack.Api.Swagger;
using Trip.Order.DTO;

namespace Trip.Order.Services
{
    public class Global : System.Web.HttpApplication
    {
        public class ServiceAppHost : AppHostBase
        {
            public ServiceAppHost()
                : base("MSA API", typeof(ServiceAppHost).Assembly)
            {
                //配置路由规则：
                Routes.Add<SearchOrderRequest>("/OrderService/SearchOrder", "GET,POST", "查询订单");
                Plugins.Add(new SwaggerFeature());
            }

            public override void Configure(Funq.Container container)
            {             
            }
        }

        protected void Application_Start(object sender, EventArgs e)
        {
            new ServiceAppHost().Init();
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}