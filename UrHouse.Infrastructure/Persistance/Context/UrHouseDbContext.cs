using UrHouse.Domain.Models.Entities;
using UrHouse.Infrastructure.Persistance.Configurations;
using Microsoft.EntityFrameworkCore;


namespace UrHouseDbContext.Infrastructure.Persistance.Context
{
    public class UrHouseDbContext : DbContext
    {
        public UrHouseDbContext(DbContextOptions<UrHouseDbContext> options) : base(options) { }

        public DbSet<Address> Address { get; set; } 
        public DbSet<Apartament> Apartament { get; set; } 
        public DbSet<Booking> Booking { get; set; } 
        public DbSet<Realtor> Realtor { get; set; } 
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AddressConfig());
            modelBuilder.ApplyConfiguration(new ApartamentConfig());
            modelBuilder.ApplyConfiguration(new BrandConfig());
            modelBuilder.ApplyConfiguration(new EquipmentInfoConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig());
        }
    }
}
