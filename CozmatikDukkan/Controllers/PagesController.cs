using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CozmatikDukkan.Models;

namespace CozmatikDukkan.Controllers
{
    public class PagesController : Controller
    {
        CozmatikModel db = new CozmatikModel();
        // GET: Pages
        [HttpGet]
        public ActionResult CategoryNavigation()
        {
            List<Category> categories = db.Categories.ToList();
            return PartialView (categories);
        }
    }
}