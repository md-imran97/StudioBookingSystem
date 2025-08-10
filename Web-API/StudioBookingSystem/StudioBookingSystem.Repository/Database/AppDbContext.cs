using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudioBookingSystem.Common.EntityModel;
using StudioBookingSystem.Repository.EntityConfig;

namespace StudioBookingSystem.Repository.Database
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Studio> Studios { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Coordinates> Coordinates { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Amenity> Amenities { get; set; }
        public DbSet<Availability> Availabilities { get; set; }
        public DbSet<StudioImage> StudioImages { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<TimeSlot> TimeSlots { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudioConfiguration());
            modelBuilder.ApplyConfiguration(new LocationConfiguration());
            modelBuilder.ApplyConfiguration(new CoordinatesConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new AmenityConfiguration());
            modelBuilder.ApplyConfiguration(new AvailabilityConfiguration());
            modelBuilder.ApplyConfiguration(new StudioImageConfiguration());
            modelBuilder.ApplyConfiguration(new BookingConfiguration());
            modelBuilder.ApplyConfiguration(new TimeSlotConfiguration());

            base.OnModelCreating(modelBuilder);
        }

    }
}
