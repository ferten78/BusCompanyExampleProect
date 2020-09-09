using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Passenger
    {
        public Passenger()
        {
            Ticket = new List<Ticket>();
        }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        public virtual List<Ticket> Ticket { get; set; }
    }
}
