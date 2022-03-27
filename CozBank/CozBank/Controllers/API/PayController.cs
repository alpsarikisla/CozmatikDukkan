using CozBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace CozBank.Controllers.API
{
    public class DoPayViewModel
    {
        public string MerchandUserName { get; set; }
        public string MerchandPassword { get; set; }
        public string CardNumber { get; set; }
        public string ReqMonth { get; set; }
        public string ReqYear { get; set; }
        public string Cvv { get; set; }
        public decimal Price { get; set; }
    }
    public class PayController : ApiController
    {
        veksisd1_CozBank_DBEntities db = new veksisd1_CozBank_DBEntities();
        [ResponseType(typeof(int))]
        public IHttpActionResult GetPay(int id)
        {
            return Json(12 + id);
        }
        [ResponseType(typeof(string))]
        public IHttpActionResult PostPay(DoPayViewModel model)
        {
            int userCount = db.Users.Count(x => x.Username == model.MerchandUserName && x.Password == model.MerchandPassword);
            if (userCount != 0)
            {
                int cardCount = db.Accounts.Count(x => x.CardNumber == model.CardNumber);
                if (cardCount != 0)
                {
                    Accounts card = db.Accounts.FirstOrDefault(x => x.CardNumber == model.CardNumber);
                    if (card.Cvv == model.Cvv)
                    {
                        if (model.ReqMonth == card.CardReqMount && model.ReqYear == card.CardReqYear)
                        {
                            DateTime SonKullanma = Convert.ToDateTime("30/" + model.ReqMonth + "/" + model.ReqYear);
                            if (SonKullanma > DateTime.Now)
                            {
                                if (card.Amount >= model.Price)
                                {
                                    try
                                    {
                                        card.Amount -= model.Price;
                                        db.SaveChanges();
                                        return Json("201");
                                    }
                                    catch
                                    {
                                        return Json("301");
                                    }
                                }
                                else
                                {
                                    return Json("401");
                                }
                            }
                            else
                            {
                                return Json("501");
                            }
                        }
                        else
                        {
                            return Json("601");
                        }
                    }
                    else
                    {
                        return Json("701");
                    }
                }
                else
                {
                    return Json("801");
                }
            }
            else
            {
                return Json("901");
            }
        }

    }
}
