//using DAL.Mapping;
using DAL.Mapping;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SqlContext : DbContext
    {
        public SqlContext()
            : base("BusDb")
        {
            Database.SetInitializer<DbContext>(new DropCreateDatabaseIfModelChanges<DbContext>());

        }
        public virtual DbSet<Ticket> Employees { get; set; }

        public virtual DbSet<Passenger> Contacts { get; set; }

        public virtual DbSet<Trip> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TicketMap());
            modelBuilder.Configurations.Add(new TripMap());
            modelBuilder.Configurations.Add(new PassengerMap());

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
