using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiharPaymentGateway.Models
{
    public class BillDetails
    {
        public int Id { get; set; }
        public string CANumber{ get; set; }
        public string InvoiceNo{ get; set; }
        public string DueDate{ get; set; }
        public string Amount{ get; set; }
        public string CompanyCode{ get; set; }
        public string TransactionId{ get; set; }
        public string TransactionDateTime{ get; set; }
        public string ReceiptNo{ get; set; }
        public string BankRefCode{ get; set; }
        public string BankId{ get; set; } 
        public string PaymentMode{ get; set; }
        public string MerchantCode{ get; set; }
        public string MerchantPassword{ get; set; }
        public string CkeckSum { get; set; }
    }
}
