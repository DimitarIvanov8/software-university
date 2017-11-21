using Microsoft.EntityFrameworkCore;
using BillsPaymentSystem.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BillsPaymentSystem.Data.EntityConfig
{
    public class BankAccountConfiguration 
        : IEntityTypeConfiguration<BankAccount>
    {
        public void Configure(EntityTypeBuilder<BankAccount> builder)
        {
            builder.HasKey(e => e.BankAccountId);

            builder.Property(e => e.BankName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode();

            builder.Property(e => e.SWIFTCode)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Ignore(e => e.PaymentMethodId);
        }
    }
}
