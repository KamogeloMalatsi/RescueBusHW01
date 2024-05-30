using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KamogeloRescueBus.Models
{
    public class Repository
    {
        public static List<Service> GetServices()
        {
            return new List<Service>
            {
                new Service {ServiceID = "ServiceA", ServiceImage = "~/Images/Services/S_image1.jpg", ServiceName = "ALS(Advanced Life Support)", ServiceDescription = "ALS ambulance is staffed by a Paramedic and is used to transport patients who require high level of care."},
                new Service {ServiceID = "ServiceB", ServiceImage = "~/Images/Services/S_image2.jpg", ServiceName = "BLS(Basic Life Support)", ServiceDescription = "BLS ambulance provides transport to patients who are in a non life threatening condition."},
                new Service {ServiceID = "ServiceC", ServiceImage = "~/Images/Services/S_image6.jpg", ServiceName = "Patient Transport", ServiceDescription = "The most basic type of transport for patients requiring ambulatory support to and from the hospital."},
                new Service {ServiceID = "ServiceD", ServiceImage = "~/Images/Services/S_image5.jpg",ServiceName = "Medical Utility Vehicle", ServiceDescription = "A state-of-the-art small of large van that is designed to facilitate the movement and transport objects of medical importance."},
                new Service {ServiceID = "ServiceE", ServiceImage = "~/Images/Services/S_image2.jpg", ServiceName = "Event Medical Ambulance", ServiceDescription = " Ambulances that are stationed at events, such as concerts, sport games and festivals to provide medical assistance."},
                new Service {ServiceID = "ServiceF", ServiceImage = "~/Images/Services/S_image3.jpg", ServiceName = "Air Ambulance", ServiceDescription = "Air ambulance helps in the transfer of patients across long distances in both emergency and non-emergency situations"},    
            };
        }

        public static List<Driver> GetDrivers()
        {
            return new List<Driver>
            {
                new Driver { DriverID = 1, DriverImage = "~/Images/Drivers/D_image1", DriverFName = "John", DriverLName = "Smith", DriverPNumber = "+27 82 348 7792", ServiceID = "ServiceA" },
                new Driver { DriverID = 2, DriverImage = "~/Images/Drivers/D_image2", DriverFName = "Ethan", DriverLName = "Lawson", DriverPNumber = "+27 76 889 6578", ServiceID = "ServiceB" },
                new Driver { DriverID = 3, DriverImage = "~/Images/Drivers/D_image3", DriverFName = "Lebogang", DriverLName = "Nkosi", DriverPNumber = "+27 78 394 6895", ServiceID = "ServiceB" },
                new Driver { DriverID = 4, DriverImage = "~/Images/Drivers/D_image4", DriverFName = "Sipho", DriverLName = "Ndlovu", DriverPNumber = "+27 85 289 7659", ServiceID = "ServiceC" },
                new Driver { DriverID = 5, DriverImage = "~/Images/Drivers/D_image5", DriverFName = "Dylan", DriverLName = "Jones", DriverPNumber = "+27 89 489 5894", ServiceID = "ServiceD" },
                new Driver { DriverID = 6, DriverImage = "~/Images/Drivers/D_image6", DriverFName = "Themba", DriverLName = "Khumalo", DriverPNumber = "+27 72 867 9385", ServiceID = "ServiceE" },
                new Driver { DriverID = 7, DriverImage = "~/Images/Drivers/D_image7", DriverFName = "James", DriverLName = "Plant", DriverPNumber = "+27 82 485 4489", ServiceID = "ServiceF" },
                new Driver { DriverID = 8, DriverImage = "~/Images/Drivers/D_image8", DriverFName = "Katlego", DriverLName = "Motaung", DriverPNumber = "+27 63 765 8292", ServiceID = "ServiceF" },
                new Driver { DriverID = 9, DriverImage = "~/Images/Drivers/D_image2", DriverFName = "Matheo", DriverLName = "Francis", DriverPNumber = "+27 62 874 4839", ServiceID = "ServiceD" },
                new Driver { DriverID = 10, DriverImage = "~/Images/Drivers/D_image2", DriverFName = "Pearl", DriverLName = "Ferguson", DriverPNumber = "+27 76 889 6578", ServiceID = "ServiceA" },
            };
        }

        public static List<Vehicle> GetVehicles()
        {
            return new List<Vehicle>
            {
                new Vehicle { VehicleID = 1, VehicleImage = "~/Images/Vehicles/V_image1" ,VehicleType = "Type 2", VehicleRegistration = "JG 84 PK GP", ServiceID = "ServiceA" },
                new Vehicle { VehicleID = 2, VehicleImage = "~/Images/Vehicles/V_image2", VehicleType = "Type 1", VehicleRegistration = "LM 22 FJ GP", ServiceID = "ServiceB" },
                new Vehicle { VehicleID = 3, VehicleImage = "~/Images/Vehicles/V_image3", VehicleType = "Type 3", VehicleRegistration = "HH 22 MN GP", ServiceID = "ServiceC" },
                new Vehicle { VehicleID = 4, VehicleImage = "~/Images/Vehicles/V_image4", VehicleType = "Type 1", VehicleRegistration = "SK 95 TP GP", ServiceID = "ServiceD" },
                new Vehicle { VehicleID = 5, VehicleImage = "~/Images/Vehicles/V_image5", VehicleType = "Type 2", VehicleRegistration = "FJ 73 CM GP", ServiceID = "ServiceE" },
                new Vehicle { VehicleID = 6, VehicleImage = "~/Images/Vehicles/V_image6", VehicleType = "Type 3", VehicleRegistration = "SC 34 VB GP", ServiceID = "ServiceF" },
                new Vehicle { VehicleID = 7, VehicleImage = "~/Images/Vehicles/V_image7", VehicleType = "Type 3", VehicleRegistration = "RS 98 ZZ GP", ServiceID = "ServiceA" },
                new Vehicle { VehicleID = 8, VehicleImage = "~/Images/Vehicles/V_image8", VehicleType = "Type 1", VehicleRegistration = "NG 48 RT GP", ServiceID = "ServiceB" },
                new Vehicle { VehicleID = 9, VehicleImage = "~/Images/Vehicles/V_image9", VehicleType = "Type 3", VehicleRegistration = "MM 38 JG GP", ServiceID = "ServiceC" },
                new Vehicle { VehicleID = 10, VehicleImage = "~/Images/Vehicles/V_image10", VehicleType = "Type 1", VehicleRegistration = "AD 65 HF GP", ServiceID = "ServiceD" },
                new Vehicle { VehicleID = 11, VehicleImage = "~/Images/Vehicles/V_image11", VehicleType = "Type 2", VehicleRegistration = "QW 23 BN GP", ServiceID = "ServiceE" },
                new Vehicle { VehicleID = 12, VehicleImage = "~/Images/Vehicles/V_image12", VehicleType = "Type 3", VehicleRegistration = "SD 14 OK GP", ServiceID = "ServiceF" },
            };
        }

        public static List<Booking> GetBookings()
        {
            return new List<Booking>
            {
                new Booking
                {
                    BookingID = Guid.NewGuid(),
                    BookingType = 0,
                    BServiceID = "ServiceC",
                    BFullname = "Thamba Ndlovu",
                    BPhone = "+27 82 348 7792",
                    BDate = new DateTime(2023,2,22),
                    BPickUpTime = "19:30",
                    BReason = "Accident",
                    BVehicleID = 3,
                    BDriverID = 4,
                    pickupAddress = "1239 Jan Shoba Road Hatfield 0011",
                },

                new Booking
                {
                    BookingID = Guid.NewGuid(),
                    BookingType = 0,
                    BServiceID = "ServiceA",
                    BFullname = "Kamogelo Malatsi",
                    BPhone = "+27 82 128 7542",
                    BDate = new DateTime(2023,3,12),
                    BPickUpTime = "19:30",
                    BReason = "Falling",
                    BVehicleID = 1,
                    BDriverID = 7,
                    pickupAddress = "180 William Street Brooklyn 0011",
                },

                new Booking
                {
                    BookingID = Guid.NewGuid(),
                    BookingType = 1,
                    BServiceID = "ServiceF",
                    BFullname = "Jessica Nkosi",
                    BPhone = "+27 82 348 7792",
                    BDate = new DateTime(2023,4,3),
                    BPickUpTime = "20:00",
                    BReason = "Accident",
                    BVehicleID = 6,
                    BDriverID = 8,
                    pickupAddress = "1107 Prospect Street Hatfield 0012",
                },

                new Booking
                {
                    BookingID = Guid.NewGuid(),
                    BookingType = 0,
                    BServiceID = "ServiceB",
                    BFullname = "Linda Gracefield",
                    BPhone = "+27 75 564 7792",
                    BDate = new DateTime(2023,4,28),
                    BPickUpTime = "19:30",
                    BReason = "Drowning",
                    BVehicleID = 2,
                    BDriverID = 3,
                    pickupAddress = "123 Brooks Street Brooklyn 0011",
                },

                new Booking
                {
                    BookingID = Guid.NewGuid(),
                    BookingType = 1,
                    BServiceID = "ServiceD",
                    BFullname = "Kimberley Stone",
                    BPhone = "+27 73 778 2938",
                    BDate = new DateTime(2023,5,12),
                    BPickUpTime = "19:30",
                    BReason = "Accident",
                    BVehicleID = 4,
                    BDriverID = 9,
                    pickupAddress = "237 Anderson Street Menlo-Park 0014",
                },

            };
        }

    }
}