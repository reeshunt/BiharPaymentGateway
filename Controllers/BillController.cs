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
    public class BillController : ControllerBase
    {
        private ILogger<BillController> _logger;
        private IConfiguration _configuration;
        private string strMerchantCode;
        private string strMerchantPasscode;
        private string strChecksumKey;
        private EndpointConfiguration endPoint;

        public BillController( ILogger<BillController> logger, IConfiguration configuration)
        {
            this._configuration = configuration;
            this._logger = logger;
            strMerchantCode = _configuration.GetValue<string>("MerchantSettings:MerchantCode");
            strMerchantPasscode = _configuration.GetValue<string>("MerchantSettings:MerchantPassword");
            strChecksumKey = _configuration.GetValue<string>("MerchantSettings:ChecksumPrivateKey");

        }
        
        [HttpGet("{CANumber}/{strDivision?}/{strSubDivision?}/{strLegacyNo?}")]
        public async Task<BillDetailsStruct> Get(string CANumber, string strDivision, string strSubDivision, string strLegacyNo)
        {
            BillDetailsStruct response = new BillDetailsStruct();
            EndpointConfiguration endPoint = biharService.BillInterfaceSoapClient.EndpointConfiguration.BillInterfaceSoap;
            biharService.BillInterfaceSoapClient client = new biharService.BillInterfaceSoapClient(endPoint);
            using (client)
            {
                response = await client.BillDetailsAsync(CANumber, strDivision, strSubDivision, strLegacyNo, strMerchantCode, strMerchantPasscode);
            }
            return response;
        }

        [HttpPost]
        public async Task<VendorPaymentDetails> Post(BillDetails data)
        {
            VendorPaymentDetails response = new VendorPaymentDetails();
            EndpointConfiguration endPoint = biharService.BillInterfaceSoapClient.EndpointConfiguration.BillInterfaceSoap;
            biharService.BillInterfaceSoapClient client = new biharService.BillInterfaceSoapClient(endPoint);
            var arrayOfBytes = Encoding.ASCII.GetBytes(data.Amount.ToString());
            var crc32 = new Crc32();
            strChecksumKey = crc32.Get(arrayOfBytes).ToString("X");
            using (client)
            {
                response = await client.PaymentDetailsAsync(data.CANumber, data.InvoiceNo, data.DueDate, data.Amount,
                    data.CompanyCode, data.TransactionId, data.TransactionDateTime, data.ReceiptNo, data.BankRefCode,
                    data.BankId, data.PaymentMode, strMerchantCode, strMerchantPasscode, strChecksumKey);
            }
            ///save to database as well
            ///

            return response;

        }
    }
}
