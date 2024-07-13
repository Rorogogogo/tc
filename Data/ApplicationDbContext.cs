using Microsoft.EntityFrameworkCore;

namespace tc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<VenueEntity> Venues { get; set; }
        public DbSet<AppointmentEntity> Appointments { get; set; }
        public DbSet<ActivityTypeEntity> ActivityType { get; set; }
        public DbSet<UserEneity> Users{ get; set; }
        public DbSet<VenueActivitySetupEntity> VenueActivitySetups { get; set; }



    }
}