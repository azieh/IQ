using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task7.ExchangeRates;
using Task7.Models;
using Task7.Utility.XmlParser;

namespace Task7.Controllers
{
    public class ExchangeRatesController : Controller
    {
        [HttpGet]
        public JsonResult GetUsdAndEurExchangeRates()
        {
            IXmlParser<web_dis_rates> xmlParser = new WebXmlParser<web_dis_rates>();
            List<ExchangeRateViewModel> ratesList = new ExchangeRateLogic(xmlParser).GetUsdAndEurExchangeRates();
            return Json(ratesList, JsonRequestBehavior.AllowGet);
        }
    }
}