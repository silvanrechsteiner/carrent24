using CarRent.Feature.Cars.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace CarRent.Persistance
{
    public class CarRentDbContext : DbContext
    {
        public CarRentDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CarConfiguration());

            // Autoregistration
            //modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}