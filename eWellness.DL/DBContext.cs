using eWellness.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace eWellness.Core
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<Client> Clients { get; set; } = null!;
        public DbSet<Appointment> Appointments { get; set; } = null!;
        public DbSet<PaymentMethod> PaymentMethods { get; set; } = null!;
        public DbSet<Payment> Payments { get; set; } = null!;
        public DbSet<Service> Services { get; set; } = null!;
        public DbSet<Tip> Tips { get; set; } = null!;
        public DbSet<ActivityLog> ActivityLogs { get; set; } = null!;
        public DbSet<ServiceCategory> ServiceCategories { get; set; } = null!;
        public DbSet<SpecialOffer> SpecialOffers { get; set; } = null!;
        public DbSet<Invoice> Invoices { get; set; } = null!;

        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            SeedData(modelBuilder);
        }

        private static void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ServiceCategory>().HasData(new List<ServiceCategory>
            {
                new ServiceCategory {
                    Id = 1,
                    Name = "Masaža",
                    Description = "Različite masaže tijela i lica",
                    IsActive= true,
                    CreatedAt = DateTime.Now
                },
                new ServiceCategory
                {
                    Id = 2,
                    Name = "Maderoterapija",
                    Description = "Različite maderoterapije tijela i lica",
                    IsActive= true,
                    CreatedAt = DateTime.Now
                },
                new ServiceCategory
                {
                    Id = 3,
                    Name = "Spa",
                    Description = "Spa prostorije u kojima nema manuelnog rada",
                    IsActive= true,
                    CreatedAt = DateTime.Now
                }
            });
            modelBuilder.Entity<PaymentMethod>().HasData(new List<PaymentMethod>
            {
                new PaymentMethod
                {
                    Id = 1,
                    Name = "Mastercard",
                    Description = "Mastercard kartice",
                    IsActive = true,
                    CreatedAt = DateTime.Now
                },
                new PaymentMethod
                {
                    Id = 2,
                    Name = "Visa",
                    Description = "Visa kartice",
                    IsActive = true,
                    CreatedAt = DateTime.Now
                },
                new PaymentMethod
                {
                    Id = 3,
                    Name = "AMEX",
                    Description = "American Express kartice",
                    IsActive = true,
                    CreatedAt = DateTime.Now
                },
                new PaymentMethod
                {
                    Id = 4,
                    Name = "Diners",
                    Description = "Diners Club kartice",
                    IsActive = true,
                    CreatedAt = DateTime.Now
                },
                new PaymentMethod
                {
                    Id = 5,
                    Name = "Discovery",
                    Description = "Discovery kartice",
                    IsActive = false,
                    CreatedAt = DateTime.Now
                },
                new PaymentMethod
                {
                    Id = 6,
                    Name = "Vaučer",
                    Description = "Plaćanje vaučerom",
                    IsActive = true,
                    CreatedAt = DateTime.Now
                },
                new PaymentMethod
                {
                    Id = 7,
                    Name = "Virman",
                    Description = "Virmansko plaćanje",
                    IsActive = false,
                    CreatedAt = DateTime.Now
                },
                new PaymentMethod
                {
                    Id = 8,
                    Name = "Cash",
                    Description = "Gotovinsko plaćanje",
                    IsActive = true,
                    CreatedAt = DateTime.Now
                }
            });
        }
    }
}
