using CozmatikDukkan.Models;
using CozmatikDukkan.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace CozmatikDukkan.Controllers
{
    public class CheckOutController : Controller
    {
        CozmatikModel db = new CozmatikModel();
        // GET: CheckOut
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult BuySometing(int? id)
        {
            if (id!= null)
            {
                Product p = db.Products.Find(id);
                ViewBag.product = p;
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        [HttpPost]
        public ActionResult BuySometing(DoPayViewModel model, int? id)
        {
            Product p = db.Products.Find(id);
            model.Price = p.Price;
            model.MerchandUserName = "Cozmatik";
            model.MerchandPassword = "123Asd?";
            using (var client = new HttpClient())
            {
                //client.BaseAddress = new Uri("https://localhost:44313/API/Pay");
                client.BaseAddress = new Uri("http://cozbank.veksisdesign.com/API/Pay");
                var response = client.PostAsJsonAsync<DoPayViewModel>("Pay", model);
                string contentString = response.Result.Content.ReadAsStringAsync().Result;
                if (contentString == "\"201\"")
                {
                    return RedirectToAction("Success");
                }
            }
            return View();
        }
        [HttpGet]
        public ActionResult Success()
        {
            return View();
        }
    }
}