using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace tc.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUserEntity, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<VenueEntity> Venues { get; set; }
        public DbSet<AppointmentEntity> Appointments { get; set; }
        public DbSet<ActivityTypeEntity> ActivityTypes { get; set; }
        public DbSet<VenueActivitySetupEntity> VenueActivitySetups { get; set; }



    }
}