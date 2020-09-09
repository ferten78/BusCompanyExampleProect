using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PassengerBusiness : IBusiness<Passenger>
    {
        UnitOfWork _uof;
        bool _result;

        public PassengerBusiness()
        {
            _uof = new UnitOfWork();
        }
        public void Add(Passenger item)
        {
            if (item != null)
            {
                _uof.PassengerReository.Add(item);
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

        public void Delete(Passenger item)
        {
            if (item != null)
            {
                _uof.PassengerReository.Remove(item);
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

        public List<Passenger> GetAll()
        {
            return _uof.PassengerReository.GetAll();
        }

        public Passenger GetById(int ID)
        {
            return _uof.PassengerReository.GetByID(ID);
        }

        public void Update(Passenger item)
        {

            _uof.PassengerReository.Update(item);
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
