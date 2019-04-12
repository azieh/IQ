using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task7.ExchangeRates;
using Task7.Models;

namespace Task7.Controllers
{
    public class ExchangeRatesController : Controller
    {
        [HttpGet]
        public JsonResult GetUsdAndEurExchangeRates()
        {
            List<ExchangeRateViewModel> ratesList = new ExchangeRateLogic().GetUsdAndEurExchangeRates();
            return Json(ratesList, JsonRequestBehavior.AllowGet);
        }
    }
}