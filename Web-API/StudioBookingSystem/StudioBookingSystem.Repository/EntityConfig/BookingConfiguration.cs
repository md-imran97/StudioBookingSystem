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
    public class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.UserName).IsRequired().HasMaxLength(150);
            builder.Property(b => b.Email).IsRequired().HasMaxLength(150);
            builder.Property(b => b.Date).IsRequired();
            
            builder.HasOne(b => b.TimeSlot)
            .WithOne(ts => ts.Booking)
            .HasForeignKey<TimeSlot>(ts => ts.BookingId);
        }
    }
}
