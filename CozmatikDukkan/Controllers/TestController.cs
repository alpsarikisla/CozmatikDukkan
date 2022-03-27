using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace CozmatikDukkan.Controllers
{
    //public class DoPayViewModel
    //{
    //    public string MerchandUserName { get; set; }
    //    public string MerchandPassword { get; set; }
    //    public string CardNumber { get; set; }
    //    public string ReqMonth { get; set; }
    //    public string ReqYear { get; set; }
    //    public string Cvv { get; set; }
    //    public decimal Price { get; set; }
    //}
    public class TestController : Controller
    {

        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult APITest()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult APITest(DoPayViewModel model)
        //{
        //    try
        //    {
        //        model.ReqMonth = "12";
        //        model.ReqYear = "2023";
        //        model.Cvv = "987";
        //        model.CardNumber = "1254789654125478";
        //        model.MerchandUserName = "Cozmatik";
        //        model.MerchandPassword = "123Asd?";
        //        model.Price = 1000;
        //        using (var client = new HttpClient())
        //        {
        //            //client.BaseAddress = new Uri("https://localhost:44313/API/Pay");
        //            client.BaseAddress = new Uri("http://cozbank.veksisdesign.com/API/Pay");
        //            var response =  client.PostAsJsonAsync<DoPayViewModel>("Pay", model);
        //            string contentString = response.Result.Content.ReadAsStringAsync().Result;
        //        }
        //    }
        //    catch
        //    {

        //    }
        //    return View();
        //}
    }
}