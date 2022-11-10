using UrHouse.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UrHouse.Infrastructure.Persistance.Configurations
{
    public class RealtorConfig : IEntityTypeConfiguration<Realtor>
    {
        public void Configure(EntityTypeBuilder<Realtor> builder)
        {

            builder.Property(d => d.FirstName)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(d => d.LastName)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(d => d.TelephoneNumber)
                  .HasMaxLength(50)
                  .IsRequired();


            builder.HasMany(a => a.Apartaments)
                .WithOne(b => b.Realtor)
                .HasForeignKey(a => a.RealtorId);

        }
    }
}
