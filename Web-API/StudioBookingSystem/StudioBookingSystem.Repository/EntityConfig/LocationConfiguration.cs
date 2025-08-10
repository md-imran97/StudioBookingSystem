using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using StudioBookingSystem.Common.EntityModel;
using System.Reflection.Emit;

namespace StudioBookingSystem.Repository.EntityConfig
{
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasKey(l => l.Id);

            builder.Property(l => l.City).HasMaxLength(100);
            builder.Property(l => l.Area).HasMaxLength(100);
            builder.Property(l => l.Address).HasMaxLength(300);

            builder
            .HasOne(l => l.Coordinates)
            .WithOne(c => c.Location)
            .HasForeignKey<Coordinates>(c => c.Id);
        }
    }
}
