
using UrHouse.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UrHouse.Infrastructure.Persistance.Configurations
{
    public class AddressConfig : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.Property(a => a.Country)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(a => a.City)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(a => a.Street)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(a => a.Number)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.HasOne(a => a.Apartament)
                .WithOne(b => b.Address)
                .HasForeignKey<Apartament>(b => b.AddressId);
        }
    }
}
