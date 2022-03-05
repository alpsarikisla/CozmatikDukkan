using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CozmatikDukkan.Areas.ManagerPanel.Filters;

namespace CozmatikDukkan.Areas.ManagerPanel.Controllers
{
    [ManagerAuthenticationFilter]
    public class HomeController : Controller
    {
        // GET: ManagerPanel/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}