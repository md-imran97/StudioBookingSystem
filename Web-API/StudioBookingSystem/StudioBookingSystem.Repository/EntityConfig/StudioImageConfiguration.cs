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
    public class StudioImageConfiguration : IEntityTypeConfiguration<StudioImage>
    {
        public void Configure(EntityTypeBuilder<StudioImage> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Url).IsRequired().HasMaxLength(500);
        }
    }
}
