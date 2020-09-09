using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapping
{
    public class TripMap : EntityTypeConfiguration<Trip>
    {
        public TripMap()
        {
            HasKey(t => t.ID);

            Property(t => t.Date)
                .HasColumnType("date")
                .IsRequired();

            Property(t => t.StartCity)
                .HasColumnType("nvarchar")
                .IsRequired();

            Property(t=>t.Arrival)
                .HasColumnType("nvarchar")
                .IsRequired();

            HasMany(s => s.Ticket)
                .WithRequired(s => s.Trip)
                .HasForeignKey(s => s.TripID);

        }
    }
}
