using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiharPaymentGateway.Models
{
    public class PaymentDetails
    {
        public long CANumber { get; set; }
        public long InvoiceNo { get; set; }
        public DateTime DueDate { get; set; }
        public int Amount { get; set; }
        public string CompanyCode { get; set; }
        public string TransactionID { get; set; }
        public DateTime TransactionDateTime { get; set; }
        public string ReceiptNo { get; set; }
        public string BankReferenceCode { get; set; }
        public int BankID { get; set; }
        public string PaymentMode { get; set; }
        public string MerchantCode { get; set; }
        public string MerchantPassword { get; set; }
        public string Checksum { get; set; }
    }
}
