using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class TripRepository: BaseRepository<Trip>
    {
        public TripRepository(SqlContext context): base(context)
        {

        }
    }
}
