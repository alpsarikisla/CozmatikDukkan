using CozmatikDukkan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace CozmatikDukkan.Areas.ManagerPanel.Filters
{
    public class ManagerAuthenticationFilterAttribute : ActionFilterAttribute, IAuthenticationFilter
    {
        CozmatikModel db = new CozmatikModel();
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            if (string.IsNullOrEmpty(Convert.ToString(filterContext.HttpContext.Session["manager"])))
            {
                if (filterContext.HttpContext.Request.Cookies["managerInfo"] != null)
                {
                    HttpCookie savedCookie = filterContext.HttpContext.Request.Cookies["managerInfo"];
                    string mail = savedCookie.Values["managermail"];
                    string password = savedCookie.Values["managerpassword"];
                    //savedCookie.Expires = DateTime.Now.AddDays(10);

                    Manager m = db.Managers.First(x => x.Mail == mail && x.Password == password);
                    filterContext.HttpContext.Session["manager"] = m;
                }
                else
                {
                    filterContext.Result = new HttpUnauthorizedResult();
                }
                
            }
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            if (filterContext.Result == null || filterContext.Result is HttpUnauthorizedResult)
            {
                filterContext.Result = new RedirectResult("~/ManagerPanel/Login/Index");
            }
        }
    }
}
