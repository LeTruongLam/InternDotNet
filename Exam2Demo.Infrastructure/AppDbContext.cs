using Microsoft.EntityFrameworkCore;
using Exam2Demo.Domain.Entities;

namespace Exam2Demo.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Resident> Residents { get; set; }
        public DbSet<ResidentApartment> ResidentApartments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<ResidentApartment>(entity =>
            {
                entity.HasKey(ra => new { ra.ResidentId, ra.ApartmentId });

                entity.HasOne(ra => ra.Resident)
                .WithMany(r => r.ResidentApartments)
                .HasForeignKey(ra => ra.ResidentId)
                .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(ra => ra.Apartment)
              .WithMany(a => a.ResidentApartments)
              .HasForeignKey(ra => ra.ApartmentId)
              .OnDelete(DeleteBehavior.Cascade);
            });
        }

    }
}
