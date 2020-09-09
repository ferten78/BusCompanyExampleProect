using Entities;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class TicketRepository: BaseRepository<Ticket>
    {
        public TicketRepository(SqlContext context): base(context)
        {

        }
    }
}
