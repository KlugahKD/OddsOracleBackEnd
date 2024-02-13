using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OddsOracle.Storage.Entities;

namespace OddsOracle.Storage.EntityConfigurations;

public class TipsConfiguration : IEntityTypeConfiguration<Tip>
{
    public void Configure(EntityTypeBuilder<Tip> builder)
    {
        builder.HasKey(t => t.Id);
        builder.Property(t => t.Sport).IsRequired();
        builder.Property(t => t.Match).IsRequired();
        builder.Property(t => t.Prediction).IsRequired();
        builder.Property(t => t.TotalOdds).IsRequired();
        builder.Property(t => t.Price).HasColumnType("decimal(18,2)");
        builder.Property(t => t.IsFree);
        builder.Property(t => t.IsRefundable).IsRequired();
        builder.Property(t => t.StartDate).IsRequired();
        builder.Property(t => t.EndDate).IsRequired();
    }
}