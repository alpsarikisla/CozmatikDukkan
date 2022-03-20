using System.Web.Mvc;

namespace CozmatikDukkan.Areas.ManagerPanel
{
    public class ManagerPanelAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "ManagerPanel";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "ManagerPanel_default",
                "ManagerPanel/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                 new[] { "CozmatikDukkan.Areas.ManagerPanel.Controllers" }
            );
        }
    }
}