using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Trip
    {
        public Trip()
        {
            Ticket = new List<Ticket>();
        }
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string StartCity { get; set; }
        public string Arrival { get; set; }

        public virtual List<Ticket> Ticket { get; set; }
    }
}
