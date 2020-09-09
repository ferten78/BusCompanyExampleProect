using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class TripBusiness: IBusiness<Trip>
    {
        UnitOfWork _uof;
        bool _result;

        public TripBusiness()
        {
            _uof = new UnitOfWork();
        }

        public void Add(Trip item)
        {
            if (item != null)
            {
                _uof.TripRepository.Add(item);
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

        public void Delete(Trip item)
        {
            if (item != null)
            {
                _uof.TripRepository.Remove(item);
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

        public List<Trip> GetAll()
        {
            return _uof.TripRepository.GetAll();
        }
    

        public Trip GetById(int ID)
        {
            return _uof.TripRepository.GetByID(ID);
        }

        public void Update(Trip item)
        {
            _uof.TripRepository.Update(item);
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
