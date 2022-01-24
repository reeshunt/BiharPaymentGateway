using BiharPaymentGateway.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using biharService;
using BiharPaymentGateway.Functions;
using System.Text;

namespace BiharPaymentGateway.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BillController : ControllerBase
    {
        private readonly ILogger<BillController> _logger;
        private readonly IConfiguration _configuration;

        public BillController( ILogger<BillController> logger, IConfiguration configuration)
        {
            this._configuration = configuration;
            this._logger = logger;
        }
        
        [HttpGet("{CANumber}")]
        public BillDetailsStruct Get(long CANumber)
        {
            BillDetailsStruct response = new BillDetailsStruct();
            var merchantCode = _configuration.GetValue<string>("MerchantSettings:MerchantCode");
            var merchantPasscode = _configuration.GetValue<string>("MerchantSettings:MerchantPassword");
            var checksumKey = _configuration.GetValue<string>("MerchantSettings:ChecksumPrivateKey");
            
           
            var endPoint = biharService.BillInterfaceSoapClient.EndpointConfiguration.BillInterfaceSoap;
            biharService.BillInterfaceSoapClient client = new biharService.BillInterfaceSoapClient(endPoint);
            using (client)
            {
                response = client.BillDetails(CANumber.ToString(), "", "", "", merchantCode, merchantPasscode);
            }
            return response;
        }

        //[HttpPost]
        //public string Post(PaymentDetails data)
        //{
        //    var arrayOfBytes = Encoding.ASCII.GetBytes("10");//1266344399
        //    //var arrayOfBytes = Encoding.ASCII.GetBytes("5");//3192113243

        //    var crc32 = new Crc32();
        //    Console.WriteLine(crc32.Get(arrayOfBytes).ToString("X"));

        //    return "";
        //}
    }
}
