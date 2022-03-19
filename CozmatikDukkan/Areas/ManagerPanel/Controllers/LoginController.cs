using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CozmatikDukkan.Areas.ManagerPanel.ViewModels;
using CozmatikDukkan.Models;

namespace CozmatikDukkan.Areas.ManagerPanel.Controllers
{
    public class LoginController : Controller
    {
        CozmatikModel db = new CozmatikModel();
        // GET: ManagerPanel/Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(ManagerLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                Manager m = db.Managers.FirstOrDefault(x=> x.Mail == model.Mail && x.Password == model.Password);
                if (m != null)
                {
                    Session["manager"] = m;
                    if (model.RememberMe)
                    {
                        HttpCookie userInfo = new HttpCookie("managerInfo");
                        userInfo["managermail"] = model.Mail;
                        userInfo["managerpassword"] = model.Password;
                        userInfo.Expires = DateTime.Now.AddDays(10);
                        Response.Cookies.Add(userInfo);
                    }
                    return RedirectToAction("Index", "Home");
                }
            }
            return View("Index");
        }
        
        public ActionResult LogOut()
        {
            if (Request.Cookies["managerInfo"] != null)
            {
                HttpCookie kurabiyem = new HttpCookie("managerInfo");
                kurabiyem.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(kurabiyem);
                Session["manager"] = null;
            }
            return RedirectToAction("Index","Login");
        }
    }
}