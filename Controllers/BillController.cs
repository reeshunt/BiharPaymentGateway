using BiharPaymentGateway.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiharPaymentGateway.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BillController : ControllerBase
    {
        private readonly ILogger<BillController> _logger;

        public BillController( ILogger<BillController> logger)
        {

            this._logger = logger;
        }
        


  

        //[HttpGet]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    var rng = new Random();
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}
        [HttpGet("{id}")]
        public BillDetails Get(long CANumber)
        {
            return new BillDetails
            {
                Division = "BARAUNI",
                CANumber = 232305030671,
                ConsumerName = "KAUSHALYA DEVI",
                CompanyName = "SOUTH  BIHAR POWER DISTRIBUTION COMPANY LTD.",
                InvoiceNO = "2016061162000005",
                BillMonth = "JUN-16",
                DueDate = DateTime.Now,
                Amount = 100,
                ErrorMessage = ""

            };

        }
        //[HttpPost]
        //public string Post(PaymentDetails data)
        //{
        //    return "";
        //}
    }
}
