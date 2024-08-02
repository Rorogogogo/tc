using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Roles
            modelBuilder.Entity<IdentityRole<Guid>>().HasData(
                new IdentityRole<Guid> { Id = Guid.NewGuid(), Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole<Guid> { Id = Guid.NewGuid(), Name = "Standard", NormalizedName = "STANDARD" }
            );

            // Seed Venues
            for (int i = 1; i <= 16; i++)
            {
                modelBuilder.Entity<VenueEntity>().HasData(
                    new VenueEntity { Id = Guid.NewGuid(), VenueName = $"Venue{i}" }
                );
            }

            // Seed Activity Types
            modelBuilder.Entity<ActivityTypeEntity>().HasData(
                new ActivityTypeEntity { Id = Guid.NewGuid(), ActivityName = "Standard1" },
                new ActivityTypeEntity { Id = Guid.NewGuid(), ActivityName = "Standard2" }
            );


        }
    }
}
