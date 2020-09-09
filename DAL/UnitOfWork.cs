using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repository;

namespace DAL
{
    public class UnitOfWork
    {
        SqlContext _context;
        DbContextTransaction _transaction;

        public UnitOfWork()
        {
            _context = new SqlContext();
        }

        private Repository.TicketRepository _ticketRepository;

        public Repository.TicketRepository TicketRepository
        {
            get {
                if (_ticketRepository == null)
                {
                    _ticketRepository = new TicketRepository(this._context);
                }
                return  _ticketRepository;
            }

        }

        private Repository.PassengerRepository _passengerRepository;

        public Repository.PassengerRepository PassengerReository
        {
            get {
                if (_ticketRepository == null)
                {
                    _passengerRepository = new PassengerRepository(this._context);
                }
                return _passengerRepository; 
            }
        }

        private Repository.TripRepository _tripRepository;

        public Repository.TripRepository TripRepository
        {
            get {
                if (_ticketRepository == null)
                {
                    _tripRepository = new TripRepository(this._context);
                }
                return _tripRepository;
            }
        }

        public bool ApplyChanges()
        {
            bool isSuccess = false;
            _transaction = _context.Database.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
            try
            {
                _context.SaveChanges();
                _transaction.Commit();
                isSuccess = true;
            }
            catch (Exception)
            {
                _transaction.Rollback();
                isSuccess = false;

            }
            finally
            {
                _transaction.Dispose();
            }
            return isSuccess;
        }

        
    }
}
