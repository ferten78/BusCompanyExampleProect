using BusinessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        Passenger passengerEntity;
        PassengerBusiness passengerBusiness;

        public HomeController()
        {
            passengerEntity = new Passenger();
            passengerBusiness = new PassengerBusiness();
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Passenger passenger)
        {
            passengerBusiness.Add(passenger);
            return View();
        }
    }
}