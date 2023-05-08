using BikeRentalCompany0.Models;
using Microsoft.EntityFrameworkCore;

namespace BikeRentalCompany0.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Bike> Bikes { get; set; }
       public DbSet<Client> Clients { get; set; }
        public DbSet<Worker> Workers { get; set; }

        public DbSet<Rental> Rentals { get; set; }
    }
}
