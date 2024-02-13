using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OddsOracle.Storage.Entities;

namespace OddsOracle.Storage.EntityConfigurations;

public class PaymentMethodConfiguration : IEntityTypeConfiguration<PaymentMethod>
{
    public void Configure(EntityTypeBuilder<PaymentMethod> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Name).IsRequired();
        builder.Property(p => p.Details).IsRequired();
        builder.Property(p => p.Type).IsRequired();
        builder.Property(p => p.UserId).IsRequired();
        builder.Property(p => p.TransactionId).IsRequired();
        builder.Property(p => p.SubscriptionId).IsRequired();
        builder.Property(p => p.TipsId).IsRequired();
        builder.Property(p => p.PaymentStatus).IsRequired();

        builder.HasOne(p => p.User)
            .WithMany()
            .HasForeignKey(p => p.UserId);

        builder.HasOne(p => p.Tips)
            .WithMany()
            .HasForeignKey(p => p.TipsId);
    }
}