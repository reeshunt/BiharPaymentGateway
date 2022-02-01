using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace BiharPaymentGateway.Models
{
    public partial class ConsumerPaymentDetail
    {
        [Key]
        public int Id { get; set; }
        [Column("CANumber")]
        [StringLength(100)]
        public string Canumber { get; set; }
        [StringLength(100)]
        public string InvoiceNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        [StringLength(40)]
        public string Amount { get; set; }
        [StringLength(40)]
        public string CompanyCode { get; set; }
        [StringLength(80)]
        public string TransactionId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TransactionDateTime { get; set; }
        [StringLength(80)]
        public string ReceiptNo { get; set; }
        [StringLength(50)]
        public string BankRefCode { get; set; }
        [StringLength(40)]
        public string BankId { get; set; }
        [StringLength(20)]
        public string PaymentMode { get; set; }
        [StringLength(50)]
        public string StatusFlag { get; set; }
        [StringLength(100)]
        public string Message { get; set; }
    }
}
