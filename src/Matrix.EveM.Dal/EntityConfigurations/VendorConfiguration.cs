using Matrix.EveM.Domain.Vendors.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Matrix.EveM.Dal.EntityConfigurations;

public class VendorConfiguration :IEntityTypeConfiguration<Vendor>
{
    public void Configure(EntityTypeBuilder<Vendor> builder)
    {
        builder.ToTable("Vendors");
        builder.HasKey(v => v.Id);
        builder.Property(v => v.Name).IsRequired().HasMaxLength(50);
        builder.Property(v => v.Description).HasMaxLength(500);
        builder.Property(v => v.ContactName).IsRequired().HasMaxLength(50);
        builder.Property(v => v.ContactNumber).IsRequired().HasMaxLength(50);
        builder.Property(v => v.ContactEmail).IsRequired().HasMaxLength(50);
        builder.Property(v => v.ServiceType).IsRequired().HasMaxLength(50);
        builder.Property(v => v.Remarks).HasMaxLength(500);
    }
}
