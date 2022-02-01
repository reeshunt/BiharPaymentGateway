using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BiharPaymentGateway.Models
{
    public partial class CoreDbContext : DbContext
    {
        public CoreDbContext()
        {
        }

        public CoreDbContext(DbContextOptions<CoreDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ConsumerDatum> ConsumerData { get; set; }
        public virtual DbSet<ConsumerPaymentDetail> ConsumerPaymentDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//                optionsBuilder.UseSqlServer("Server="";Trusted_Connection=True;");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ConsumerDatum>(entity =>
            {
                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.CompanyName).IsUnicode(false);

                entity.Property(e => e.ConsumerName).IsUnicode(false);

                entity.Property(e => e.Division).IsUnicode(false);

                entity.Property(e => e.EmailAddress).IsUnicode(false);

                entity.Property(e => e.ErrorMessage).IsUnicode(false);

                entity.Property(e => e.InvoiceNo).IsUnicode(false);

                entity.Property(e => e.LtHt).IsUnicode(false);

                entity.Property(e => e.SubDivision).IsUnicode(false);
            });

            modelBuilder.Entity<ConsumerPaymentDetail>(entity =>
            {
                entity.Property(e => e.Amount).IsUnicode(false);

                entity.Property(e => e.BankId).IsUnicode(false);

                entity.Property(e => e.BankRefCode).IsUnicode(false);

                entity.Property(e => e.Canumber).IsUnicode(false);

                entity.Property(e => e.CompanyCode).IsUnicode(false);

                entity.Property(e => e.InvoiceNo).IsUnicode(false);

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.PaymentMode).IsUnicode(false);

                entity.Property(e => e.ReceiptNo).IsUnicode(false);

                entity.Property(e => e.StatusFlag).IsUnicode(false);

                entity.Property(e => e.TransactionId).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
