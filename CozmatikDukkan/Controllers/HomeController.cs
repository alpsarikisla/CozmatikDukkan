using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CozmatikDukkan.Models;

namespace CozmatikDukkan.Controllers
{
    public class HomeController : Controller
    {
        CozmatikModel db = new CozmatikModel();
        // GET: Home
        public ActionResult Index()
        {
            return View(db.Products.Where(x=> x.ProductStatus == true).ToList());
        }
    }
}