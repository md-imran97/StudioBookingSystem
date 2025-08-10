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
    public class CoordinatesConfiguration : IEntityTypeConfiguration<Coordinates>
    {
        public void Configure(EntityTypeBuilder<Coordinates> builder)
        {
           

            builder.Property(c => c.Latitude).IsRequired();
            builder.Property(c => c.Longitude).IsRequired();
        }
    }
}
