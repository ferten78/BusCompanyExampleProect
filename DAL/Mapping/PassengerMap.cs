using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PassengerMap : EntityTypeConfiguration<Passenger>
    {
        public PassengerMap()
        {
            HasKey(p => p.ID);

            Property(p => p.FirstName)
                .HasColumnType("nvarchar");

            Property(p => p.LastName)
                .HasColumnType("nvarchar");

            Property(p => p.Gender)
                .HasColumnType("nvarchar");


           HasMany(s => s.Ticket) 
                    .WithRequired(s => s.Passenger)  
                    .HasForeignKey(s => s.PassengerID);

        }
    }
}
