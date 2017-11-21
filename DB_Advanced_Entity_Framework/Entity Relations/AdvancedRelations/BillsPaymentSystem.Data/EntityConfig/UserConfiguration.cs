using Microsoft.EntityFrameworkCore;
using BillsPaymentSystem.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BillsPaymentSystem.Data.EntityConfig
{
    public class UserConfiguration
        : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.UserId);

            builder.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode();

            builder.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode();

            builder.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(80)
                .IsUnicode(false);

            builder.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(25)
                .IsUnicode(false);
        }
    }
}
