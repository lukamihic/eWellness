using Microsoft.EntityFrameworkCore;

using eWellness.Core.Models;
using System.Security.Cryptography;

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
                    Name = "Massage",
                    Description = "Various face and body massages",
                    IsActive= true,
                    CreatedAt = DateTime.Now
                },
                new ServiceCategory
                {
                    Id = 2,
                    Name = "Maderotherapy",
                    Description = "Various maderotherapies",
                    IsActive= true,
                    CreatedAt = DateTime.Now
                },
                new ServiceCategory
                {
                    Id = 3,
                    Name = "Spa",
                    Description = "Spa spaces",
                    IsActive= true,
                    CreatedAt = DateTime.Now
                }
            });

            var password = HashPassword("test");

            modelBuilder.Entity<User>().HasData(new List<User>
            {
                new User
                {
                    Id = 1,
                    Address = "Test address no1",
                    DateOfBirth = DateTime.Now.AddYears(-20),
                    Email = "desktop",
                    EmergencyContactName = "N/A",
                    Gender = 'M',
                    EmergencyContactPhone = "N/A",
                    Name = "Desktop App",
                    PasswordHash =  password[0],
                    PasswordSalt =  password[1],
                    Phone = "0000000000"
                },
                new User
                {
                    Id = 2,
                    Address = "Test address no2",
                    DateOfBirth = DateTime.Now.AddYears(-22),
                    Email = "mobile",
                    EmergencyContactName = "N/A",
                    Gender = 'M',
                    EmergencyContactPhone = "N/A",
                    Name = "Mobile App",
                    PasswordHash =  password[0],
                    PasswordSalt =  password[1],
                    Phone = "0000000000"
                }
            });

            modelBuilder.Entity<Client>().HasData(new List<Client>
            {
                new Client
                {
                    Id = 1,
                    IsDeleted= false,
                    CreatedAt = DateTime.Now,
                    LastAppointment = DateTime.MinValue,
                    IsMember = true,
                    MembershipExpirationDate = DateTime.MaxValue,
                    TotalAppointments = 0,
                    UserId = 2
                }
            });

            modelBuilder.Entity<Employee>().HasData(new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    IsDeleted= false,
                    CreatedAt = DateTime.Now,
                    UserId = 1,
                    Position = "Admin",
                    Salary = 5000
                }
            });

            modelBuilder.Entity<Tip>().HasData(new List<Tip>
            {
                new Tip
                {
                    Id = 1,
                    Name = "Enjoy :)",
                    Description = "Welcome to the app, enjoy it!",
                    IsActive = true,
                    CreatedByUserId = 1
                },
                new Tip
                {
                    Id = 2,
                    Name = "Cold baths brrr",
                    Description = "Cold baths strengthen immunity and improve blood flow.",
                    IsActive = true,
                    CreatedByUserId = 1
                }
            });


            modelBuilder.Entity<SpecialOffer>().HasData(new List<SpecialOffer>
            {
                new SpecialOffer
                {
                    Id = 1,
                    Name = "2 + 1",
                    Description = "Get three massages for the price of two",
                    IsActive = true,
                    OfferExpirationDate = DateTime.MaxValue,
                    IsDeleted = false,
                },
                new SpecialOffer
                {
                    Id = 2,
                    Name = "5 + 2",
                    Description = "Get seven sauna visits for the price of five",
                    IsActive = true,
                    OfferExpirationDate = DateTime.MaxValue,
                    IsDeleted = false,
                }
            });

            modelBuilder.Entity<Service>().HasData(new List<Service>
            {
                new Service
                {
                    Id = 1,
                    Name = "Full body massage",
                    Description = "Massage of the whole body for an hour",
                    Duration = 60,
                    Price = 40,
                    IsAvailable = true,
                    ServiceCategoryId = 1,
                    ImageUrl = "https://i1.sndcdn.com/artworks-000135911201-ryi7ns-t500x500.jpg"
                },
                new Service
                {
                    Id = 2,
                    Name = "Sauna",
                    Description = "Sauna visit for half an hour",
                    Duration = 30,
                    Price = 10,
                    IsAvailable = true,
                    ServiceCategoryId = 3,
                    ImageUrl = "https://i1.sndcdn.com/artworks-000135911201-ryi7ns-t500x500.jpg"
                },
                new Service
                {
                    Id = 3,
                    Name = "Maderotherapy",
                    Description = "Maderotherapy",
                    Duration = 30,
                    Price = 50,
                    IsAvailable = true,
                    ServiceCategoryId = 2,
                    ImageUrl = "https://i1.sndcdn.com/artworks-000135911201-ryi7ns-t500x500.jpg"
                }
            });


            modelBuilder.Entity<PaymentMethod>().HasData(new List<PaymentMethod>
            {
                new PaymentMethod
                {
                    Id = 1,
                    Name = "Mastercard",
                    Description = "Mastercard cards",
                    IsActive = true,
                    CreatedAt = DateTime.Now
                },
                new PaymentMethod
                {
                    Id = 2,
                    Name = "Visa",
                    Description = "Visa cards",
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
                    Description = "Diners Club cards",
                    IsActive = true,
                    CreatedAt = DateTime.Now
                },
                new PaymentMethod
                {
                    Id = 5,
                    Name = "Discovery",
                    Description = "Discovery cards",
                    IsActive = false,
                    CreatedAt = DateTime.Now
                },
                new PaymentMethod
                {
                    Id = 6,
                    Name = "Voucher",
                    Description = "Voucher payments",
                    IsActive = true,
                    CreatedAt = DateTime.Now
                },
                new PaymentMethod
                {
                    Id = 7,
                    Name = "Virman",
                    Description = "Pay by bank transfer",
                    IsActive = false,
                    CreatedAt = DateTime.Now
                },
                new PaymentMethod
                {
                    Id = 8,
                    Name = "Cash",
                    Description = "Cash payment",
                    IsActive = true,
                    CreatedAt = DateTime.Now
                }
            });
        }

        protected static List<string> HashPassword(string password)
        {
            // Generate a salt
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            // Create the Rfc2898DeriveBytes and get the hash value
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            // Combine the salt and password bytes for later use
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            // Turn the combined salt+hash into a string for storage
            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            string saltString = Convert.ToBase64String(salt);

            return new List<string>() { savedPasswordHash, saltString };
        }
    }
}
