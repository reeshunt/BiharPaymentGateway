using BiharPaymentGateway.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using biharService;
using System.Text;
using static biharService.BillInterfaceSoapClient;
using BiharPaymentGateway.Functions;

namespace BiharPaymentGateway.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecieptController : ControllerBase
    {
        private ILogger<BillController> _logger;
        private IConfiguration _configuration;
        private string strMerchantCode;
        private string strMerchantPasscode;
        private string strChecksumKey;
        private EndpointConfiguration endPoint;
        public RecieptController(ILogger<BillController> logger, IConfiguration configuration)
        {
            this._configuration = configuration;
            this._logger = logger;
            strMerchantCode = _configuration.GetValue<string>("MerchantSettings:MerchantCode");
            strMerchantPasscode = _configuration.GetValue<string>("MerchantSettings:MerchantPassword");
            strChecksumKey = _configuration.GetValue<string>("MerchantSettings:ChecksumPrivateKey");

        }
        [HttpGet("{TransactionId}")]
        public async Task<VendorPaymentReceipt> Get(string TransactionId)
        {
            VendorPaymentReceipt response = new VendorPaymentReceipt();
            EndpointConfiguration endPoint = biharService.BillInterfaceSoapClient.EndpointConfiguration.BillInterfaceSoap;
            biharService.BillInterfaceSoapClient client = new biharService.BillInterfaceSoapClient(endPoint);
            using (client)
            {
                response = await client.PaymentReceiptDetailsAsync(TransactionId,strMerchantCode, strMerchantPasscode);
            }
            return response;
        }
    }
    

}
