using KamogeloRescueBus.Models;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;

namespace KamogeloRescueBus.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service

        static List<Models.Booking> Bookings = Repository.GetBookings();
        static List<Models.Driver> Drivers = Repository.GetDrivers();
        static List<Models.Vehicle> Vehicles = Repository.GetVehicles(); 
        static List<Models.RideHistory> RHistory = new List<Models.RideHistory>();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SelectService()
        {
            List<Service> services = Repository.GetServices();
            return View(services);
        }

        public ActionResult BookingForm(string serviceID) 
        {
            List<Service> serviceList = Repository.GetServices();
            List<string> ServiceDrivers = new List<string>();
            List<string> ServiceVehicles = new List<string>();

            string sName = "";

            for (int i = 0; i < serviceList.Count; i++)
            {
                if (serviceID == serviceList[i].ServiceID)
                {
                    sName = serviceList[i].ServiceName;
                }
            }
            ViewBag.sName = sName;

            for (int i = 0; i < Drivers.Count; i++)
            {
                if (serviceID == Drivers[i].ServiceID)
                {
                    string DName = Drivers[i].DriverFName + " " + Drivers[i].DriverLName;
                    ServiceDrivers.Add(DName);
                }
            }
            ViewBag.DList = ServiceDrivers;

            for (int i = 0; i < Vehicles.Count; i++)
            {
                if (serviceID == Vehicles[i].ServiceID)
                {
                    string VType = Vehicles[i].VehicleType;
                    ServiceDrivers.Add(VType);
                }
            }
            ViewBag.VTypes = ServiceVehicles;

            return View();
        }

        public ActionResult Booking(string Fullname, string Phone, string pickupTime, string Reason, int VID, int DID, string pickupAdd)
        {
            Guid bookingID = Guid.NewGuid();
            Bookings.Add(new Models.Booking
            {
                BookingID = bookingID,
                BookingType = 0,
                BServiceID = "ServiceA",
                BFullname = Fullname,
                BPhone = Phone,
                BDate = DateTime.Now,
                BPickUpTime = pickupTime,
                BReason = Reason,
                BVehicleID = VID,
                BDriverID = DID,
                pickupAddress = pickupAdd
            });

            ViewBag.BookingID = bookingID;
            return View("BookingConfirmed");
        }

        public ActionResult BookingConfirmed()
        {
            ViewBag.ConfirmedID = ViewBag.BookingID;
            dynamic mymodel = new ExpandoObject();
            mymodel.Booking = Bookings;
            mymodel.Driver = Drivers;
            mymodel.Vehicle = Vehicles;

            return View(mymodel);
        }

        public ActionResult EmergencyBooking()
        {
            Random rndDriver = new Random();
            Random rndVehicle = new Random();

            int randomD = rndDriver.Next(0, Drivers.Count);
            int randomV = rndVehicle.Next(0, Vehicles.Count);

            int DriverID = Drivers[randomD].DriverID;
            int VehicleID = Vehicles[randomV].VehicleID;

            Guid bookingID = Guid.NewGuid();
            Bookings.Add(new Models.Booking
            {
                BookingID = bookingID,
                BookingType = 1,
                BServiceID = "ServiceA",
                BFullname = "",
                BPhone = "",
                BDate = DateTime.Now,
                BPickUpTime = "",
                BReason = "Emergency",
                BVehicleID = VehicleID,
                BDriverID = DriverID,
                pickupAddress = ""
            });

            return View("BookingConfirmed");
        }

        public ActionResult RideHistory()
        {
            List<Service> services = Repository.GetServices();

            string BookingID = " ";
            string dName = " ";
            string vType = " ";
            string BookingDate = " ";
            int bType = 0;
            string Address = " ";


            foreach (var booking in Bookings)
            {
                BookingDate = booking.BDate.ToShortDateString();
                BookingID = booking.BookingID.ToString();
                bType = booking.BookingType;
                Address = booking.pickupAddress; 

                for (int i = 0; i < Drivers.Count; i++)
                {
                    if (booking.BDriverID == Drivers[i].DriverID)
                    {
                        dName = Drivers[i].DriverFName + " " + Drivers[i].DriverLName;
                    }
                }

                for (int i = 0; i < Vehicles.Count; i++)
                {
                    if (booking.BVehicleID == Vehicles[i].VehicleID)
                    {
                        vType = Vehicles[i].VehicleType;
                    }
                }

                RHistory.Add(new Models.RideHistory
                {
                    bookingID = BookingID,
                    BookingType = bType,
                    DriverName = dName,
                    RideDate = BookingDate,
                    VehicleType = vType,
                    PickUpAddress = Address,
                });

            }

            return View(RHistory);
        }

        public ActionResult DVManagement()
        {
            return View();
        }

        public ActionResult DriversList()
        {
            List<Service> services = Repository.GetServices();

            var driverImages = new List<string>();
            var driverLNames = new List<string>();
            var driverFNames = new List<string>();
            var driverPNumbers = new List<string>();
            var serviceNames = new List<string>();
          
            foreach (var driver in Drivers)
            {
                driverImages.Add(driver.DriverImage);
                driverFNames.Add(driver.DriverFName);
                driverLNames.Add(driver.DriverLName);
                driverPNumbers.Add(driver.DriverPNumber);
                for(int i = 0; i < services.Count; i++)
                {
                    if (driver.ServiceID == services[i].ServiceID)
                    {
                        serviceNames.Add(services[i].ServiceName);
                    }
                }
            }

            return Content(
                string.Format("{0};{1};{2};{3};{4}", string.Join(",", driverImages), string.Join(",", driverFNames), string.Join(",", driverLNames),
                string.Join(",", driverPNumbers), string.Join(",",serviceNames))
                );
        }

        public ActionResult VehiclesList()
        {
            List<Service> services = Repository.GetServices();

            var vehicleImages = new List<string>();
            var vehicleTypes = new List<string>();
            var vehicleRegistrations = new List<string>();
            var serviceNames = new List<string>();

            foreach (var vehicle in Vehicles)
            {
                vehicleImages.Add(vehicle.VehicleImage);
                vehicleTypes.Add(vehicle.VehicleType);
                vehicleRegistrations.Add(vehicle.VehicleRegistration);
                for (int i = 0; i < services.Count; i++)
                {
                    if (vehicle.ServiceID == services[i].ServiceID)
                    {
                        serviceNames.Add(services[i].ServiceName);
                    }
                }
            }

            return Content(
                string.Format("{0};{1};{2};{3}", string.Join(",", vehicleImages), string.Join(",", vehicleTypes), string.Join(",", vehicleRegistrations),
                string.Join(",", serviceNames))
                );
        }

        [HttpGet]
        public ActionResult AddDriver()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddDriver(Models.Driver m) 
        {
            Drivers.Add(new Models.Driver {DriverID = Drivers.Count+1, DriverImage = m.DriverImage, DriverFName = m.DriverFName, DriverLName = m.DriverLName, DriverPNumber = m.DriverPNumber, ServiceID = m.ServiceID});

            return View("DVManagement");
        }

        [HttpGet]
        public ActionResult AddVehicle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddVehicle(Models.Vehicle m)
        {
            Vehicles.Add(new Models.Vehicle { VehicleID = Vehicles.Count + 1, VehicleImage = m.VehicleImage, VehicleType = m.VehicleType, VehicleRegistration = m.VehicleRegistration, ServiceID = m.ServiceID });

            return View("DVManagement");
        }
    }
}