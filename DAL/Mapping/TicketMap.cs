using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapping
{
    public class TicketMap : EntityTypeConfiguration<Ticket>
    {
        public TicketMap()
        {
            HasKey(t => t.ID);

            Property(t => t.SeatNo)
                .HasColumnType("int")
                .IsRequired();

            Property(t => t.PassengerID)
                .HasColumnType("int")
                .IsRequired();

            Property(t => t.TripID)
                .HasColumnType("int")
                .IsRequired();

       
        }
    }
}
