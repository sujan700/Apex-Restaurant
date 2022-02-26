using Microsoft.EntityFrameworkCore;
using ApexRestaurant.Repository.Domain;
using System;

namespace ApexRestaurant.Repository
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.FirstName);
                entity.Property(e => e.LastName).HasMaxLength(250);
                entity.Property(e => e.Address).HasMaxLength(250);
                entity.Property(e => e.PhoneRes).HasMaxLength(250);
                entity.Property(e => e.PhoneMob).HasMaxLength(250);
                entity.Property(e => e.EnrollDate).HasMaxLength(250);
                entity.Property(e => e.IsActive).HasMaxLength(250);
                entity.Property(e => e.CreatedBy).HasMaxLength(250);
                entity.Property(e => e.CreatedOn);
                entity.Property(e => e.UpdatedBy).HasMaxLength(250);
                entity.Property(e => e.UpdatedOn);

            entity.HasData(new Customer
            {
               Id = 1, 
               FirstName = "Hari",
               LastName = "Bahadur",
               Address = "Kathmandu, Nepal",
               PhoneRes = "01-552466",
               PhoneMob = "9803275067",
               EnrollDate = DateTime.Now,
               CreatedBy = "Admin"
            });

            });

        }
    }
}