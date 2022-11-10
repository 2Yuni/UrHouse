
using UrHouse.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UrHouse.Infrastructure.Persistance.Configurations
{
    public class ApartamentConfig : IEntityTypeConfiguration<Apartament>
    {
        public void Configure(EntityTypeBuilder<Apartament> builder)
        {
            builder.HasIndex(x => x.Name);

            
        }
    }
}