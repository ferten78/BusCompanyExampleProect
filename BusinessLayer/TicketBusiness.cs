using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TicketBusiness : IBusiness<Ticket>
    {
        UnitOfWork _uof;
        bool _result;
        public TicketBusiness()
        {
            _uof = new UnitOfWork();
        }
        public void Add(Ticket item)
        {
            if (item != null)
            {
                _uof.TicketRepository.Add(item);
                _result = _uof.ApplyChanges();

                if (_result == true)
                {

                }
                else
                {
                    throw new Exception("Kayıt Yapılamadı.");
                }
            }
        }

        public void Delete(Ticket item)
        {
            if (item != null)
            {
                _uof.TicketRepository.Remove(item);
                _result = _uof.ApplyChanges();

                if (_result == true)
                {

                }
                else
                {
                    throw new Exception("Silme işlemi gerçekleştirilemedi.");
                }
            }
            else
            {
                throw new Exception("Silme gerçekleştirilemedi. | Comment Remove");
            }
        }

        public List<Ticket> GetAll()
        {
            return _uof.TicketRepository.GetAll();
        }

        public Ticket GetById(int ID)
        {
            return _uof.TicketRepository.GetByID(ID);
        }

        public void Update(Ticket item)
        {
            _uof.TicketRepository.Update(item);
            _result = _uof.ApplyChanges();

            if (_result == true)
            {

            }
            else
            {
                throw new Exception("Güncelleme Yapılamadı.");
            }
        }
    }
}
