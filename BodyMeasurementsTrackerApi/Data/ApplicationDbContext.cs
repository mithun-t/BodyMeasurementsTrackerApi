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
    }
}
