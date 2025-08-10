using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using StudioBookingSystem.Common.EntityModel;

namespace StudioBookingSystem.Repository.EntityConfig
{
    public class StudioConfiguration : IEntityTypeConfiguration<Studio>
    {
        public void Configure(EntityTypeBuilder<Studio> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Name).IsRequired().HasMaxLength(200);
            builder.Property(s => s.Type).IsRequired().HasMaxLength(100);
            builder.Property(s => s.Currency).HasMaxLength(10);

            
            builder.HasOne(s => s.Location)
                .WithOne(l => l.Studio)
                .HasForeignKey<Location>(l => l.StudioId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(s => s.Contact)
                .WithOne(c => c.Studio)
                .HasForeignKey<Contact>(c => c.StudioId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(s => s.Availability)
                .WithOne(a => a.Studio)
                .HasForeignKey<Availability>(a => a.StudioId)
                .OnDelete(DeleteBehavior.Cascade);

            
            builder.HasMany(s => s.Amenities)
                .WithOne(a => a.Studio)
                .HasForeignKey(a => a.StudioId);

            builder.HasMany(s => s.Images)
                .WithOne(i => i.Studio)
                .HasForeignKey(i => i.StudioId);

            builder.HasMany(s => s.Bookings)
                .WithOne(b => b.Studio)
                .HasForeignKey(b => b.StudioId);
        }
    }
}
