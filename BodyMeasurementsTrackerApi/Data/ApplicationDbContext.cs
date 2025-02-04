using BodyMeasurementsTrackerApi.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BodyMeasurementsTrackerApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<BodyMeasurement> BodyMeasurements { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BodyMeasurement>()
                .HasOne(b => b.User)
                .WithMany() 
                .HasForeignKey(b => b.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
