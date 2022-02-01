using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace BiharPaymentGateway.Models
{
    [Keyless]
    public partial class ConsumerDatum
    {
        [Column("CANumber", TypeName = "decimal(18, 0)")]
        public decimal? Canumber { get; set; }
        [StringLength(80)]
        public string ConsumerName { get; set; }
        [StringLength(250)]
        public string Address { get; set; }
        [StringLength(250)]
        public string EmailAddress { get; set; }
        public int? MobileNumber { get; set; }
        [StringLength(80)]
        public string Division { get; set; }
        [StringLength(80)]
        public string SubDivision { get; set; }
        [Column("LT_HT")]
        [StringLength(40)]
        public string LtHt { get; set; }
        [StringLength(80)]
        public string CompanyName { get; set; }
        [Column("InvoiceNO")]
        [StringLength(50)]
        public string InvoiceNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BillMonth { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? Amount { get; set; }
        [StringLength(40)]
        public string ErrorMessage { get; set; }
    }
}
