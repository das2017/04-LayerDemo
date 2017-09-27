using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

using System.Text;

namespace Trip.Seller.MVCSite
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);           
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            // 在出现未处理的错误时运行的代码 
            Exception ex = Server.GetLastError().GetBaseException();

            StringBuilder sb = new StringBuilder();
            sb.Append(Environment.NewLine + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            sb.Append(Environment.NewLine + "====异常信息====");
            sb.Append(Environment.NewLine + "异常抛出源：" + ex.Source);
            sb.Append(Environment.NewLine + "异常方法：" + ex.TargetSite);
            sb.Append(Environment.NewLine + "异常信息：" + ex.Message);
            sb.Append(Environment.NewLine + "堆栈信息：" + ex.StackTrace);
            sb.Append(Environment.NewLine + "--------------------------------------------------------------------------------------------------");
            //Logging
            Server.ClearError();
            Response.Redirect("~/error.html");
        }
    }
}
