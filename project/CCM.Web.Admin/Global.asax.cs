using CCM.Code;
using System.Web.Mvc;
using System.Web.Routing;

namespace CCM.Web.Admin
{
    public class MvcApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// 启动应用程序
        /// </summary>
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //啟用壓縮
            //BundleTable.EnableOptimizations = true;
            //BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}