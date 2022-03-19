using CozmatikDukkan.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CozmatikDukkan.Areas.ManagerPanel.Controllers
{
    public class ProductController : Controller
    {
        CozmatikModel db = new CozmatikModel();
        // GET: ManagerPanel/Product
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            //ViewBag.Categories = db.Categories.ToList();
            //ViewBag.Brans = db.Brands.ToList();
            ViewBag.CategoryID = new SelectList(db.Categories.Where(x => x.CategoryStatus == true), "ID", "Name");
            ViewBag.BrandID = new SelectList(db.Brands.Where(x=> x.BrandStatus == true), "ID", "Name"); ;
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product model, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    FileInfo fi = new FileInfo(file.FileName);
                    string name = Guid.NewGuid().ToString() + fi.Extension;
                    file.SaveAs(Server.MapPath("~/Assets/ProductImages/" + name));
                    model.CoverImage = name;
                }
                else
                {
                    model.CoverImage = "none.png";
                }
                db.Products.Add(model);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}