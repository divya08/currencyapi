using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        Dictionary<string, string> countryCurrencyDic = new Dictionary<string, string>();
        
        [HttpGet]
        public ActionResult<string> GetCurrency(string countryCode)
        {
            populateCurrency();
            return countryCurrencyDic[countryCode].ToString();
        }

        private void populateCurrency()
        {
            countryCurrencyDic.Add("IND", "INR");
            countryCurrencyDic.Add("USA", "USD");
            countryCurrencyDic.Add("UK", "GBP");
            countryCurrencyDic.Add("SNG", "SD");
        }
    }
}