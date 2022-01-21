using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiharPaymentGateway.Models
{
    public class BillDetails
    {
        public long CANumber { get; set; }
        public string ConsumerName { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
        public string Division { get; set; }
        public string SubDivision { get; set; }
        public string LT_HT { get; set; }
        public string CompanyName { get; set; }
        public string InvoiceNO { get; set; }
        public string BillMonth { get; set; }
        public DateTime DueDate { get; set; }
        public int Amount { get; set; }
        public string ErrorMessage { get; set; }
    }
}
