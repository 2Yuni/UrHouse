using UrHouse.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UrHouse.Infrastructure.Persistance.Configurations
{
    public class BookingConfig : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.Property(a => a.StartDate)
               .IsRequired();

            builder.Property(a => a.EndDate)
              .IsRequired();

            builder.HasOne(a => a.Apartament)
                .WithMany(b => b.Bookings)
                .HasForeignKey(a => a.ApartamentId);

            builder.HasOne(a => a.User)
                .WithMany(b => b.Bookings)
                .HasForeignKey(a => a.UserId);
    }
    }
}
