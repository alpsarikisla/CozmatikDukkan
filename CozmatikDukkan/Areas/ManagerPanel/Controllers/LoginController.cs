using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CozmatikDukkan.Areas.ManagerPanel.ViewModels;

namespace CozmatikDukkan.Areas.ManagerPanel.Controllers
{
    public class LoginController : Controller
    {
        // GET: ManagerPanel/Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(ManagerLoginViewModel model)
        {
            return View();
        }
    }
}