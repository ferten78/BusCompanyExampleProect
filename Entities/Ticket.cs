using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Ticket
    {
        public int ID { get; set; }
        public int PassengerID { get; set; }
        public int TripID { get; set; }
        public int SeatNo { get; set; }

        public virtual Trip Trip { get; set; }
        public virtual Passenger Passenger { get; set; }
    }
}
