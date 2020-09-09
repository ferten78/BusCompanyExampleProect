using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class PassengerRepository : BaseRepository<Passenger>
    {
        public PassengerRepository(SqlContext context) : base(context)
        {

        }
     
    }
}
