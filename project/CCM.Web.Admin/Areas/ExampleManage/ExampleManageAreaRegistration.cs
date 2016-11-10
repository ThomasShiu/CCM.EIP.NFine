using System.Web.Mvc;

namespace CCM.Web.Admin.Areas.ExampleManage
{
    public class ExampleManageAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "ExampleManage";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                this.AreaName + "_Admin",
                this.AreaName + "/{controller}/{action}/{id}",
                new { area = this.AreaName, controller = "Home", action = "Index", id = UrlParameter.Optional },
                new string[] { "CCM.Web.Admin.Areas." + this.AreaName + ".Controllers" }
            );
        }
    }
}
